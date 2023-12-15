using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Gun" , menuName = "ScriptableObjects/Silah")]
public class GunScriptable : ScriptableObject
{
    public string gunName;
    public string gunCountry;
    public Sprite originFlag;
    public string gunType;
    public string gunCode;
    public float bulletFireRate;
    public float shootingRange;
    public int bulletCount;


    public GameObject menuGan;
    public GameObject gameGun;
}
