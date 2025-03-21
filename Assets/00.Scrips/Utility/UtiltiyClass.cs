using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UtiltiyClass
{
    /// <summary>
    /// 1000 단위 "콤마(,)" 표시
    /// </summary>

    public static string UpdateGold(int value)
    {
        string formatValue = string.Format("{0:N0}", value);
        return formatValue;
    }
}
