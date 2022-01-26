using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartRemain : UIelement
{
    /// <summary>
    /// This class inherit from ui element and handle updating heart remaining display
    /// </summary>

    [Tooltip("The text UI for heart remaining display")]
    public Text displayText = null;
    public GameObject player = null;

    public void Update()
    {
        UpdateUI();
    }

    public void DisplayHeartRemain()
    {
        if(player != null)
        {
            if (displayText != null)
            {
                displayText.text = player.GetComponent<Health>().currentLives.ToString();
            }
        }
        
    }

    public override void UpdateUI()
    {
        /// call the base UpdateUI function from the UIElments class
        base.UpdateUI();

        DisplayHeartRemain();
    }


}
