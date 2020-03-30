using System;
using UnityEngine;
using UnityEngine.Events;

public class weaponsEnum : MonoBehaviour
{
    public UnityEvent crossbowEvent, swordEvent, knifeEvent, batEvent, laserEvent;
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
                crossbowEvent.Invoke();
                break;
            case weaponsList.sword:
                swordEvent.Invoke();
                break;
            case weaponsList.knife:
                knifeEvent.Invoke();
                break;
            case weaponsList.bat:
                batEvent.Invoke();
                break;
            case weaponsList.laser:
                laserEvent.Invoke();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
