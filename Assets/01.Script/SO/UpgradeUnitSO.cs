using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SO/Upgrade/Unit", menuName = "SO/Upgrade/Unit")]
public class UpgradeUnitSO : ScriptableObject
{
    //나중에 가면 종류로 변경 예정
    [Header("가면 종류")]
    public string MaskName;
    [Header("업그레이드 타입")]
    public ST SkillType;

    [Header("업그레이드 데이터 리스트")]
    public List<Data> upgradeDataList; 
}
[Serializable]
public class Data
{
    [Header("업그레이드 종류")]
    public UpTypes UpgradeType;

    [Space]
    [Header("능력 이름")]
    public string UpgradeName;
    [Header("업그레이드 수치")]
    public float UpgradeValue;
}
