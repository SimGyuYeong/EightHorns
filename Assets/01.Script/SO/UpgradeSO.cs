using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SO/Upgrade", menuName = "SO/Upgrade")]
public class UpgradeSO : ScriptableObject
{
    //���߿� ���� ������ ���� ����
    [Header("���� ����")]
    public string MaskName;
    [Header("���׷��̵� Ÿ��")]
    public ST SkillType;

    [Header("���׷��̵� ������ ����Ʈ")]
    public List<Data> upgradeDataList; 
}
[Serializable]
public class Data
{
    [Header("���׷��̵� ����")]
    public UpTypes UpgradeType;

    [Space]
    [Header("�ɷ� �̸�")]
    public string UpgradeName;
    [Header("���׷��̵� ��ġ")]
    public float UpgradeValue;
}
