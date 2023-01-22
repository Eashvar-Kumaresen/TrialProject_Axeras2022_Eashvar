using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimFire : MonoBehaviour
{
    public Transform target;

    public GameObject yCannon;
    public GameObject xCannon;

    //public float turningSpeed;
    //private float xRotation;
    //private float yRotation;

    void OnEnable()
    {
        EventManager.StartListening("TankAim", TankAim);
    }

    void OnDisable()
    {
        EventManager.StopListening("TankAim", TankAim);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //TankAim();
    }

    public void TankAim()
    {
        //1st Method
        xCannon.transform.LookAt(target);
        var LookDirection = target.position - transform.position;
        LookDirection.y = 0; //Doesnt allow vertical rotation
        transform.rotation = Quaternion.LookRotation(LookDirection);
    }
}

