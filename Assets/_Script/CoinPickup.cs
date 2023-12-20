using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    //Coin values to generate a random from these two
    public int coinMinValue = 10;
    public int coinMaxVale = 50;

    //Audio Clip to refer to the coin sound on pickup
    public AudioClip pickupSound;

    //Reference to the "SelfMade"game manager
    GameManagerDY _gameManagerDY;

    //The generated random coin added to the player
    int _realValue;

    
    AudioSource audioSource;



    private void Start()
    {
        _gameManagerDY = GameObject.FindAnyObjectByType<GameManagerDY>();
        _realValue = Random.Range(coinMinValue, coinMaxVale);
        audioSource = gameObject.GetComponent<AudioSource>();
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            audioSource.PlayOneShot(pickupSound);
            gameObject.GetComponent<BoxCollider>().enabled = false;
            _gameManagerDY.SetPlayerGold(_realValue);
            gameObject.GetComponent<Renderer>().enabled = false;
            
            StartCoroutine(SelfDestroy());
            
        }
    }

    IEnumerator SelfDestroy()
    {
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
    }



}
