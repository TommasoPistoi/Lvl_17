using UnityEngine;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class COunterHUD : MonoBehaviour
{
    [SerializeField] Text slotText;

    pubic int slots = 0; 



    private void Awake ( ) 
    {
        UpdatedSlots(); 
    }

    public int Slots
    {
        get
        {
            return slots;
        }

        set 
        { 
            slots = value;
            UpdatedSlots(); 
        }
    }

    private void UpdatedSlots()
    {
        slotText.text = slots.ToString();
    }

}
