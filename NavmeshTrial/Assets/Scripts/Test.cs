using System.Collections;
using UnityEngine.Events;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private UnityAction someListener;

    void Awake()
    {
        someListener = new UnityAction(someFunction);
    }

    void OnEnable()
    {
        EventManager.StartListening("test", someListener);
    }

    void OnDisable()
    {
        EventManager.StopListening("test", someListener);
    }

    void someFunction()
    {
        Debug.Log("Some function was called");
    }

}