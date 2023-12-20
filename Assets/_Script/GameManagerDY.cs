using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Feedbacks;
using MoreMountains.NiceVibrations;

public class GameManagerDY : MonoBehaviour
{
    [Header ("Feedbacks")]
    public MMFeedback levelUpFeedback;

    //Handle the player Exp level
    [SerializeField]
    float _playerExp = 0;
  
    //Cashflow!!! :D
    [SerializeField]
    int _playerGold = 0;

    //Prefab of the level up effect
    public GameObject lvlFX;
    //Audioclup of lvl up Effect
    public AudioClip lvlSFX;

    //A more complex level system - region -

    //equation : XP_required_for_level_n = base_xp * (growth_factor ^ (n - 1)) - exp. lvl 5 = 100 * (2ˆ(5 - 1)) where n is the lvl 

    #region player level

    //The basic xp for calculation the rest 
    float _baseXP = 100;
    //Groth_factor for calculation
    float _growthFactor = 1.5f;

    //The exp the player has
    [SerializeField]
    float _currentExp;

    //The EXP the player needs to lvl up
    [SerializeField]
    float _lvlExp = 100;

    //Handle player level up
    [SerializeField]
    int _playerLVL = 1;

    AudioSource aSource;


    #endregion

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteAll();

        aSource = gameObject.GetComponent<AudioSource>();

        //Get all the saved data (gold, exp, lvl)
        if (PlayerPrefs.HasKey("_playerGold")) {
            _playerGold = PlayerPrefs.GetInt("_playerGold");
        }
        if (PlayerPrefs.HasKey("_playerExp"))
        {
            _playerExp = PlayerPrefs.GetFloat("_playerExp");
        }
        if (PlayerPrefs.HasKey("_playerLVL"))
        {
            _playerLVL = PlayerPrefs.GetInt("_playerLVL");
        }
        if (PlayerPrefs.HasKey("_lvlExp"))
        {
            _lvlExp = (PlayerPrefs.GetFloat("_lvlExp"));
        } else
        {
            _lvlExp = 70    ;
        }

    }

    //Add gold pickup, or gold from quest
    public void SetPlayerGold(int value)
    {
        _playerGold += value;
        PlayerPrefs.SetInt("_playerGold", value);

    }

    //Spend the players money
    public void SpendPlayerGold(int price) {
        if (_playerGold >= price)
        {
            _playerGold -= price;
        }
    }

    //Function to add exp on enemy kill
    public void AddEXP(float value)
    {
        _playerExp += value;
        if ((_currentExp + value) >= _lvlExp)
        {
            _playerLVL++;
            LevelUpFx();
            _currentExp = _lvlExp;
            _lvlExp = _baseXP * (1.5f * (_playerLVL - 1f));
            PlayerPrefs.SetFloat("_lvlExp", _lvlExp);
        } else
        {
            _currentExp += value;
        }
        PlayerPrefs.SetInt("_playerLVL", _playerLVL);
        PlayerPrefs.SetFloat("_playerExp", _playerExp );
    }

    //Intantiate Level up VFX at the player location
    void LevelUpFx()
    {
        //Find the player's location
        Vector3 instPos =  GameObject.FindGameObjectWithTag("Player").transform.position;
        Instantiate(lvlFX, instPos, Quaternion.identity);
        aSource.PlayOneShot(lvlSFX);
        levelUpFeedback.Play(instPos);
        MMVibrationManager.Haptic(HapticTypes.HeavyImpact, true, this);

    }
}
