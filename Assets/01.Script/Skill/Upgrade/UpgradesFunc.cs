using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public enum UpTypes
{
    ATK = 0,
    SPD,
    RNG,
}
public static class UpgradesFunc
{
    public static void UpgradeUtil(UpTypes upgradeType, float value, TextMeshProUGUI desc)
    {
        switch(upgradeType)
        {
            case UpTypes.ATK:
                desc.text = "공격력";
                break;
            case UpTypes.SPD:
                desc.text = "공격 속도";
                break;
            case UpTypes.RNG:
                desc.text = "공격 범위";
                break;
        }

        desc.text += $" {value}% 증가";
    }
}
