using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using MoreMountains.TopDownEngine;


public class PlayerAISwitch : MonoBehaviour
{
   
    
    //This script enables and disables the ability to rotate the player in the weapon direction.
    MoreMountains.TopDownEngine.CharacterOrientation3D orientation;
    MoreMountains.Tools.AIBrain characterBrain;
    MoreMountains.TopDownEngine.CharacterHandleWeapon weaponHeandler;
    //Referencen for camera target to reset "look forward" on move
    public GameObject camTarget;
    GameObject player;
    
    private void Start()
    {
        
        characterBrain = GameObject.FindObjectOfType<MoreMountains.Tools.AIBrain>();
        player = characterBrain.transform.parent.gameObject;
        weaponHeandler = player.GetComponent<CharacterHandleWeapon>();

        int playerChildCount = player.transform.childCount;
        camTarget = player.transform.GetChild(playerChildCount-1).gameObject;


         //Turn on and off player orientation wia script
        //orientation = gameObject.GetComponent<MoreMountains.TopDownEngine.CharacterOrientation3D>();
    }

    public void ToggleWeapon(bool value) {

        GameObject player = characterBrain.transform.parent.gameObject;
        float _attackRadius = 4f;
        if (!value)
        {
            characterBrain.canAddTarget = false;
        } else
        {
            characterBrain.canAddTarget = true;
            if (player.GetComponentInChildren<MeleeWeapon>()) {
                _attackRadius = (player.GetComponentInChildren<MeleeWeapon>().AreaOffset.z) * 5;
            }
            if (player.GetComponentInChildren<ProjectileWeapon>())
            {
                _attackRadius = 8;
                GameObject.FindAnyObjectByType<InputManager>().SetWeaponDistance(8);
            } 
           
            characterBrain.gameObject.GetComponent<AIDecisionDetectTargetRadius3D>().Radius = _attackRadius;
            characterBrain.gameObject.GetComponent<AIDecisionDistanceToTarget>().Distance = _attackRadius;
            
        }
        weaponHeandler.AbilityPermitted = value;
        GameObject.FindObjectOfType<MeleeWeapon>().transform.GetChild(0).gameObject.SetActive(value);

    }


    public void RestartBrain() {
        characterBrain.ResetBrain();
    }


    public void ResetCamTarget() {
     
        camTarget.transform.localPosition = new Vector3(0, 0,0);
        if (characterBrain == null)
        {
            characterBrain = GameObject.FindObjectOfType<MoreMountains.Tools.AIBrain>();
        }

        if (characterBrain.Target != null)
        {
            characterBrain.Target.GetComponent<Outline>().enabled = false;
            characterBrain.Target = null;
        }
        
        
    }

    public void PauseMainAttack()
    {
        StartCoroutine(AttackPause(1.5f));
    }

    IEnumerator AttackPause(float value)
    {
        weaponHeandler.AbilityPermitted = false;
        yield return new WaitForSeconds(value);
        weaponHeandler.AbilityPermitted = true;
    }


    //-----------------//-----------------//-----------------//-----------------//-----------------
    //Turn on and off player orientation wia script

    // public void TurnOnWeaponOrientation(bool value)
    // {
    //     if (value)
    //     {
    //         orientation.ShouldRotateToFaceWeaponDirection = true;
    //     }
    //     else
    //     {
    //         orientation.ShouldRotateToFaceWeaponDirection = false;
    //     }
    // }  
    //-----------------//-----------------//-----------------//-----------------//-----------------
}
