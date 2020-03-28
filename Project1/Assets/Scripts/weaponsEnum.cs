using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponsEnum : MonoBehaviour
{
    public enum weaponsList
    {
     crossbow,
     sword,
     knife,
     bat,
     laser,
    }

    public weaponsList currentWeapon;
void Start()
{
    currentWeapon = weaponsList.crossbow;
}

    // Update is called once per frame
    void Update()
    {
        switch (currentWeapon)
        {
            case weaponsList.crossbow:
                break;
            case weaponsList.sword:
                break;
            case weaponsList.knife:
                break;
            case weaponsList.bat:
                break;
            case weaponsList.laser:
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
