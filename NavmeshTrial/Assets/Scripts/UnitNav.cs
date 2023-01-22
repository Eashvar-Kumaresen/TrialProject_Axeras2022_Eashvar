using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class UnitNav : MonoBehaviour
{
    public Transform[] cells;
    public Transform[] coverPositions;
    public Transform aimPoint = null;

    public NavMeshAgent Agent;
    public NavMeshAgent Agent1;
    public NavMeshAgent Agent2;
    
    private int destinationPoint = 0;

    Animator animator;
    Animator animator1;
    Animator animator2;

    string TagName = "CoverPosition";

    void OnEnable()
    {
        EventManager.StartListening("StartWalking", StartWalking);
        EventManager.StartListening("Teleport", Teleport);
        EventManager.StartListening("Crouch_Stand", Crouch_Stand);
        EventManager.StartListening("AimWeapon", AimWeapon);
        //Debug.Log("Walkk");
    }

    void OnDisable()
    {
        EventManager.StopListening("StartWalking", StartWalking);
        EventManager.StopListening("Teleport", Teleport);
        EventManager.StopListening("Crouch_Stand", Crouch_Stand);
        EventManager.StopListening("AimWeapon", AimWeapon);
        //Debug.Log("Walkk");
    }

    void Teleport()
    {
        //EventManager.StopListening("Teleport", Teleport);
        StartCoroutine(TeleportNow());
    }

    IEnumerator TeleportNow()
    {
        Agent.Stop();
        Agent1.Stop();
        Agent2.Stop();
        animator.SetBool("isWalking", false);
        animator1.SetBool("isWalking", false);
        animator2.SetBool("isWalking", false);
        Agent.Warp(cells[destinationPoint].transform.GetChild(1).position);
        Agent1.Warp(cells[destinationPoint].transform.GetChild(2).position);
        Agent2.Warp(cells[destinationPoint].transform.GetChild(3).position);
        Agent.Resume();
        Agent1.Resume();
        Agent2.Resume();
        yield return null;
    }

    void Start()
    {
        animator = transform.GetChild(0).GetComponent<Animator>();
        animator1 = transform.GetChild(1).GetComponent<Animator>();
        animator2 = transform.GetChild(2).GetComponent<Animator>();

        Agent = transform.GetChild(0).GetComponent<NavMeshAgent>();
        Agent1 = transform.GetChild(1).GetComponent<NavMeshAgent>();
        Agent2 = transform.GetChild(2).GetComponent<NavMeshAgent>();

        Agent.stoppingDistance = 1f;
        Agent1.stoppingDistance = 1f;
        Agent2.stoppingDistance = 1f;
    }

    void Update()
    {
        if (!Agent.pathPending && Agent.remainingDistance <= Agent.stoppingDistance) //&& currentTime >= timeDelay)
        {
            animator.SetBool("isWalking", false);
            //Crouch_Stand();
            //AimWeapon();
        }
        
        if (!Agent1.pathPending && Agent1.remainingDistance <= Agent1.stoppingDistance) //&& currentTime >= timeDelay)
        {
            animator1.SetBool("isWalking", false);
        }
        
        if (!Agent2.pathPending && Agent2.remainingDistance <= Agent2.stoppingDistance) //&& currentTime >= timeDelay)
        {
            animator2.SetBool("isWalking", false);
        }
    }

    public void StartWalking()
    {
        if (cells.Length == 0)
        {
            return;
        }

        if (Input.GetKeyDown("1"))
        {
            destinationPoint = 7;
            Agent.destination = cells[destinationPoint].transform.GetChild(1).position;
            Agent1.destination = cells[destinationPoint].transform.GetChild(2).position;
            Agent2.destination = cells[destinationPoint].transform.GetChild(3).position;
            animator.SetBool("isWalking", true);
            animator1.SetBool("isWalking", true);
            animator2.SetBool("isWalking", true);
        }

        if (Input.GetKeyDown("2"))
        {
            destinationPoint = 6;
            Agent.destination = cells[destinationPoint].transform.GetChild(1).position;
            Agent1.destination = cells[destinationPoint].transform.GetChild(2).position;
            Agent2.destination = cells[destinationPoint].transform.GetChild(3).position;
            animator.SetBool("isWalking", true);
            animator1.SetBool("isWalking", true);
            animator2.SetBool("isWalking", true);
        }

        if (Input.GetKeyDown("3"))
        {
            destinationPoint = 5;
            Agent.destination = cells[destinationPoint].transform.GetChild(1).position;
            Agent1.destination = cells[destinationPoint].transform.GetChild(2).position;
            Agent2.destination = cells[destinationPoint].transform.GetChild(3).position;
            animator.SetBool("isWalking", true);
            animator1.SetBool("isWalking", true);
            animator2.SetBool("isWalking", true);
        }

        if (Input.GetKeyDown("4"))
        {
            destinationPoint = 4;
            Agent.destination = cells[destinationPoint].transform.GetChild(1).position;
            Agent1.destination = cells[destinationPoint].transform.GetChild(2).position;
            Agent2.destination = cells[destinationPoint].transform.GetChild(3).position;
            animator.SetBool("isWalking", true);
            animator1.SetBool("isWalking", true);
            animator2.SetBool("isWalking", true);
        }

        if (Input.GetKeyDown("5"))
        {
            destinationPoint = 3;
            Agent.destination = cells[destinationPoint].transform.GetChild(1).position;
            Agent1.destination = cells[destinationPoint].transform.GetChild(2).position;
            Agent2.destination = cells[destinationPoint].transform.GetChild(3).position;
            animator.SetBool("isWalking", true);
            animator1.SetBool("isWalking", true);
            animator2.SetBool("isWalking", true);
        }

        if (Input.GetKeyDown("6"))
        {
            destinationPoint = 2;
            Agent.destination = cells[destinationPoint].transform.GetChild(1).position;
            Agent1.destination = cells[destinationPoint].transform.GetChild(2).position;
            Agent2.destination = cells[destinationPoint].transform.GetChild(3).position;
            animator.SetBool("isWalking", true);
            animator1.SetBool("isWalking", true);
            animator2.SetBool("isWalking", true);
        }

        if (Input.GetKeyDown("7"))
        {
            destinationPoint = 1;
            Agent.destination = cells[destinationPoint].transform.GetChild(1).position;
            Agent1.destination = cells[destinationPoint].transform.GetChild(2).position;
            Agent2.destination = cells[destinationPoint].transform.GetChild(3).position;
            animator.SetBool("isWalking", true);
            animator1.SetBool("isWalking", true);
            animator2.SetBool("isWalking", true);
        }

        if (Input.GetKeyDown("8"))
        {
            destinationPoint = 0;
            Agent.destination = cells[destinationPoint].transform.GetChild(1).position;
            Agent1.destination = cells[destinationPoint].transform.GetChild(2).position;
            Agent2.destination = cells[destinationPoint].transform.GetChild(3).position;
            animator.SetBool("isWalking", true);
            animator1.SetBool("isWalking", true);
            animator2.SetBool("isWalking", true);
        }
    }

    public void Crouch_Stand()
    {
        if (Input.GetKeyDown("c"))
        {
            //Agent.destination = coverPositions.transform.GetChild(1).position;
            //Agent1.destination = coverPositions.transform.GetChild(2).position;
            //Agent2.destination = coverPositions.transform.GetChild(3).position;
            animator.SetBool("isCrouch", true);
            animator1.SetBool("isCrouch", true);
            animator2.SetBool("isCrouch", true);
            //GameObject.FindGameObjectsWithTag(TagName);
        }
        else if (Input.GetKeyDown("space"))
        {
            animator.SetBool("isCrouch", false);
            animator1.SetBool("isCrouch", false);
            animator2.SetBool("isCrouch", false);
        }
    }

    public void AimWeapon()
    {
        if(Input.GetKey("mouse 0"))
        {
            // Debug.Log("Fired");
            Vector3 targetDirection = aimPoint.position - Agent.transform.position;
            Vector3 localTargetDirection = Agent.transform.InverseTransformDirection(targetDirection);
            // Debug.Log(targetDirection);
            // Debug.Log(localTargetDirection);
            // Debug.Log("horizontal angle: " + Vector3.SignedAngle(Agent.transform.forward, targetDirection, Agent.transform.up));
            // Debug.Log("vertical angle: " + Vector3.SignedAngle(Agent.transform.forward, targetDirection, Agent.transform.right));

            float angleHorizontal = Mathf.Atan(localTargetDirection.x / localTargetDirection.z) * Mathf.Rad2Deg;
            float angleVertical = Mathf.Atan(localTargetDirection.y / localTargetDirection.z) * Mathf.Rad2Deg;

            if (localTargetDirection.z < 0 && localTargetDirection.x < 0)
            {
                angleHorizontal = -90f;
            }
            else if (localTargetDirection.z < 0 && localTargetDirection.x > 0)
            {
                angleHorizontal = 90f;
            }
            else
            {
                angleHorizontal = Mathf.Atan(localTargetDirection.x / localTargetDirection.z) * Mathf.Rad2Deg;
            }

            if (localTargetDirection.z < 0 && localTargetDirection.y < 0)
            {
                angleVertical = -90f;
            }
            else if (localTargetDirection.z < 0 && localTargetDirection.y > 0)
            {
                angleVertical = 90f;
            }
            else
            {
                angleVertical = Mathf.Atan(localTargetDirection.y / localTargetDirection.z) * Mathf.Rad2Deg;
            }

            Debug.Log("angleHorizontal" + angleHorizontal);
            Debug.Log("angleVertical" + angleVertical);
            animator.SetFloat("AimVertical", angleVertical);
            animator.SetFloat("AimHorizontal", angleHorizontal);
        }

        if (Input.GetKeyDown("a"))
        {
            animator.SetBool("isAiming", true);
            animator1.SetBool("isAiming", true);
            animator2.SetBool("isAiming", true);
        }
        else if (Input.GetKeyDown("space"))
        {
            animator.SetBool("isAiming", false);
            animator1.SetBool("isAiming", false);
            animator2.SetBool("isAiming", false);
        }

    }
}


