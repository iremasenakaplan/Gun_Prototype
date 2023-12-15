using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GunList", menuName ="ScriptablesObjects/SilahlarList")]

public class GunListScriptable : ScriptableObject
{
    public GunScriptable[] guns;
}
