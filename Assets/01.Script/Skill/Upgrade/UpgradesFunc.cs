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
                desc.text = "���ݷ�";
                break;
            case UpTypes.SPD:
                desc.text = "���� �ӵ�";
                break;
            case UpTypes.RNG:
                desc.text = "���� ����";
                break;
        }

        desc.text += $" {value}% ����";
    }
}
