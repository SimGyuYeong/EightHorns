using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpgradeIcon : MonoBehaviour
{
    [SerializeField] 
    private TextMeshProUGUI nameText;
    [SerializeField] 
    private TextMeshProUGUI descText;

    public void SetSkill(UpTypes upgradeType, float value)
    {
        UpgradesFunc.UpgradeUtil(upgradeType, value, descText);
    }
}
