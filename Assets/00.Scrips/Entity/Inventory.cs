using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    public Dictionary<ItemData , int> itemDatas { get; private set; }
    public int maxQty { get; private set; }
    public int curQty { get; private set; }

    public Inventory(int maxQty)
    {
        itemDatas = new Dictionary<ItemData, int>();
        this.maxQty = maxQty;
        curQty = 0;
    }

    public void GetItem(ItemData item)
    {
        if (curQty >= maxQty)
        {
            Debug.Log("æ∆¿Ã≈€¿Ã ∞°µÊ √°Ω¿¥œ¥Ÿ");
            return;
        }

        if (itemDatas.ContainsKey(item))
        {
            itemDatas[item]++;
        }
        else
        {
            itemDatas[item] = 1;
        }
        curQty++;
    }

    public void TrowItem(ItemData item)
    {
        if (itemDatas.ContainsKey(item))
        {
            itemDatas[item]--;

            if (itemDatas[item] <= 0)
            {
                itemDatas.Remove(item);
            }
        }
        curQty--;
    }
}
