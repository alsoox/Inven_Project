using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UtiltiyClass
{
    public static string UpdateGold(int value)
    {
        string formatValue = string.Format("{0:N0}", value);
        return formatValue;
    }
}
