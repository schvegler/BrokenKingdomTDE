using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using UnityEngine.UI;

public class UiToggle : MonoBehaviour
{
    //Reference to the moremountains button to disable on touch for few seconds
    MMTouchButton button;
    //Reference to dimm the image for visual feedback 
    Image img;
    //The basic color of the ui element
    Color32 onColor = new Color32(255, 255, 255, 90);
    //The touched color of the button
    Color32 offColor = new Color32(110, 110, 100, 90    );

    private void Start()
    {
        button = gameObject.GetComponent<MMTouchButton>();
        img = gameObject.GetComponent<Image>();
    }


    //Start the timeout coroutine
    public void ToggleUI(float timer)
    {

        StartCoroutine(SkillRefresh(timer));
    }


    //Timeout coroutine to disable ui for a few seconds
    IEnumerator SkillRefresh(float timer)
    {
        button.enabled = false;
        img.color = offColor;
        yield return new WaitForSeconds(timer);
        button.enabled = true;
        img.color = onColor;
    }
}
