using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public int powerValue { get; private set; }
    public int armorValue { get; private set; }
    public int maxHealth { get; private set; }
    public int level { get; private set; }
    public int maxExp { get; private set; }
    public int curExp { get; private set; }
    public float critical { get; private set; }

    public string style { get; private set; }
    public string userName { get; private set; }
    public string decrip { get; private set; }

    public int gold { get; private set; }

    public Player(int powerValue, int deffenseValue, int maxHealth, int level, int exp, float critical, string style, string userName, string decrip, int gold)

    {
        this.powerValue = powerValue;
        this.armorValue = deffenseValue;
        this.maxHealth = maxHealth;
        this.level = level;
        this.curExp = exp;
        this.critical = critical;
        this.style = style;
        this.userName = userName;
        this.decrip = decrip;
        this.gold = gold;
        maxExp = 10;
    }

    public void ChangePower(int value)
    {
        powerValue += value;
    }

    public void ChangeArmor(int value)
    {
        armorValue += value;
    }
    public void ChangeHealth(int value)
    {
        maxHealth += value;
    }
    public void ChangeCritical(int value)
    {
        critical += value;
    }
}
