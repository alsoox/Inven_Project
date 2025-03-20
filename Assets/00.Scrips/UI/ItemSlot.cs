using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    Image itemImage;
    ItemData curItem;
    public int index;

    void SetSlot()
    {
        if (curItem == null) return;

        itemImage.enabled = true;
        itemImage.sprite = curItem.icon;
    }

    void ClerSlot()
    {
        curItem = null;
        itemImage.sprite = null;
        itemImage.enabled = false;
    }
}
