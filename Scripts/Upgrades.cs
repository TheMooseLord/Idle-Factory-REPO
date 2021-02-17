
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
        control.pickaxeLevelText.text = $"Level: {Methods.NotationMethod(control.data.pickaxeUpgradeLevel, y:"F2")}";
        control.pickaxeCostText.text = $"Cost: {Methods.NotationMethod(control.data.pickaxeUpgradeCost, y:"F2")} Coal";
    }

    public void MeltIron()
    {
        if (control.data.coal >= control.data.meltIronCost && control.data.ironOre >= 1)
        {
            control.data.coal -= control.data.meltIronCost;
            control.data.iron += 1;
            control.data.ironOre -= 1;
        }
        control.meltIronCostText.text = $"Uses {Methods.NotationMethod(control.data.meltIronCost, y:"F2")} Coal";
    }
}
