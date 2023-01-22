using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class VehicleMovement : MonoBehaviour
{
    public NavMeshAgent vehicle;
    public Transform[] cells;

    private int vehiclePoints = 0;

    void OnEnable()
    {
        EventManager.StartListening("TeleportVehicle", TeleportVehicle);
        EventManager.StartListening("StartMoving", StartMoving);
    }

    void OnDisable()
    {
        EventManager.StopListening("TeleportVehicle", TeleportVehicle);
        EventManager.StopListening("StartMoving", StartMoving);
    }

    void TeleportVehicle()
    {
        //EventManager.StopListening("TeleportVehicle", TeleportVehicle); 
        StartCoroutine(TeleportVehicleNow());
    }

    IEnumerator TeleportVehicleNow()
    {
        vehicle.GetComponent<NavMeshAgent>().enabled = false;
        vehicle.Warp(cells[vehiclePoints].transform.position);
        vehicle.GetComponent<NavMeshAgent>().enabled = true;
        yield return null;
    }

    // Start is called before the first frame update
    void Start()
    {
        vehicle = transform.GetComponent<NavMeshAgent>();
        vehicle.stoppingDistance = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        //StartMoving();
    }

    public void StartMoving()
    {
        if (Input.GetKeyDown("1") && vehicle.remainingDistance <= vehicle.stoppingDistance)
        {
            vehiclePoints = 7;
            vehicle.destination = cells[vehiclePoints].transform.position;
        }

        if (Input.GetKeyDown("2"))
        {
            vehiclePoints = 6;
            vehicle.destination = cells[vehiclePoints].transform.position;
        }

        if (Input.GetKeyDown("3"))
        {
            vehiclePoints = 5;
            vehicle.destination = cells[vehiclePoints].transform.position;
        }

        if (Input.GetKeyDown("4"))
        {
            vehiclePoints = 4;
            vehicle.destination = cells[vehiclePoints].transform.position;
        }

        if (Input.GetKeyDown("5"))
        {
            vehiclePoints = 3;
            vehicle.destination = cells[vehiclePoints].transform.position;
        }

        if (Input.GetKeyDown("6"))
        {
            vehiclePoints = 2;
            vehicle.destination = cells[vehiclePoints].transform.position;
        }

        if (Input.GetKeyDown("7"))
        {
            vehiclePoints = 1;
            vehicle.destination = cells[vehiclePoints].transform.position;
        }

        if (Input.GetKeyDown("8"))
        {
            vehiclePoints = 0;
            vehicle.destination = cells[vehiclePoints].transform.position;
        }
    }
}
