// Namespaces
using UnityEngine;
using TMPro;
using BreakInfinity;

public class Controller : MonoBehaviour
{
    public Data data;
    
    [Header("Texts")]
    public TMP_Text coalText;
    public TMP_Text mineCoalText;
    public TMP_Text pickaxeLevelText;
    public TMP_Text pickaxeCostText;
    public TMP_Text ironText;
    public TMP_Text mineIronText;
    public TMP_Text meltIronCostText;

    [Header("GameObjects")]
    public GameObject MineIronPanel;
    public GameObject MeltIronPanel;
    public GameObject IronTextObject;

    public void Start()
    {
        data = new Data();
        MineIronPanel.SetActive(false);
        MeltIronPanel.SetActive(false);
        IronTextObject.SetActive(false);
    }

    public void Update()
    {
        coalText.text = $"Coal: {Methods.NotationMethod(data.coal, data.coal <= 999 ? "F0" : "F2")}";

        mineCoalText.text = $"Mine {Methods.NotationMethod(data.mineCoal, y:"F2")} Coal";

        ironText.text = $"Iron: {Methods.NotationMethod(data.iron, y:"F2")}";
        mineIronText.text = $"Mine {Methods.NotationMethod(data.mineIron, y:"F2")} Iron\nOre: {Methods.NotationMethod(data.ironOre, y:"F2")}";
    }

    public void MineCoal()
    {
        data.coal += data.mineCoal;
    }

    public void MineIron()
    {
        data.ironOre += data.mineIron;
    }
}
