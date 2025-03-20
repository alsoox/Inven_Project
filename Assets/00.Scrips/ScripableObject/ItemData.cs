using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum ValueType
{
    Power,
    Armor,
    Health,
    Critical
}

[CreateAssetMenu(fileName = "Item", menuName = "New Item")]
public class ItemData : ScriptableObject
{
    [Header("Info")]
    public Sprite icon;
    public ValueType valuetype;
    public int value;
    public bool isEquip;
}
