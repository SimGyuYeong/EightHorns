using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SO/Upgrade/Group", menuName = "SO/Upgrade/Group")]
public class UpgradeGroupSO : ScriptableObject
{
    public List<UpgradeUnitSO> UpgradeUnits;
}
