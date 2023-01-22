using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTriggerTest : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        EventManager.TriggerEvent("StartWalking");
        EventManager.TriggerEvent("Crouch_Stand");
        EventManager.TriggerEvent("AimWeapon");
        EventManager.TriggerEvent("StartMoving");

        if (Input.GetKeyDown("g"))
        {
            EventManager.TriggerEvent("test");
        }

        if (Input.GetKeyDown("space"))
        {
            EventManager.TriggerEvent("Teleport");
            EventManager.TriggerEvent("TeleportVehicle");
        }

        if (Input.GetKeyDown("a"))
        {
            EventManager.TriggerEvent("TankAim");
        }
    }
}
