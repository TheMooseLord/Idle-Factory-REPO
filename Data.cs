using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BreakInfinity;

public class Data
{
    public BigDouble coal;
    public BigDouble mineCoal;

    public BigDouble iron;
    public BigDouble ironOre;
    public BigDouble mineIron;

    public BigDouble pickaxeUpgradeLevel;
    public BigDouble pickaxeUpgradeCost;

    public BigDouble meltIronCost;

    public Data()
    {
        coal = 0;
        mineCoal = 1;

        iron = 0;
        ironOre = 0;
        mineIron = 1;

        pickaxeUpgradeLevel = 1;
        pickaxeUpgradeCost = 10;

        meltIronCost = 15;
    }
}
