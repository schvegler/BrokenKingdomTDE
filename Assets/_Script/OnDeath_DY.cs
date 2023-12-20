using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeath_DY : MonoBehaviour
{
    //Reference to game manager to handle the EXP of the player
    GameManagerDY gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManagerDY>();
    }

    //Add exp point to the palyer on enemy death
    public void AddExpOnDeath(int value)
    {
        gameManager.AddEXP(value);
    }


}
