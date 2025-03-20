using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventory : UIBasePopup
{
    [SerializeField] Transform slotsObj;
    ItemSlot[] slots;


    private void Start()
    {
        slots = new ItemSlot[slots.Length];
        for (int i = 0; i < slots.Length; i++)
        {
            slots[i] = slotsObj.GetChild(i).GetComponent<ItemSlot>();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateUI()
    {

    }
}
