
using UnityEngine;
using UnityEngine.UI;

public class Upgrades : MonoBehaviour
{
    public Controller control;

    public void BuyPickaxeUpgrade()
    {
        if (control.data.coal >= control.data.pickaxeUpgradeCost)
        {
            control.data.coal -= control.data.pickaxeUpgradeCost;
            control.data.pickaxeUpgradeLevel += 1;
            control.data.pickaxeUpgradeCost *= 1.09;
            control.data.mineCoal += 1;

            control.MineIronPanel.SetActive(true);
            control.MeltIronPanel.SetActive(true);
            control.IronTextObject.SetActive(true);
        }
        control.pickaxeLevelText.text = "Level: " + control.data.pickaxeUpgradeLevel;
        control.pickaxeCostText.text = "Cost: " + control.data.pickaxeUpgradeCost.ToString("F0") + " Coal";
    }

    public void MeltIron()
    {
        if (control.data.coal >= control.data.meltIronCost && control.data.ironOre >= 1)
        {
            control.data.coal -= control.data.meltIronCost;
            control.data.iron += 1;
            control.data.ironOre -= 1;
        }
        control.meltIronCostText.text = "Uses " + control.data.meltIronCost.ToString("F0") + " Coal";
    }
}
