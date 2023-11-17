using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class FollowUser : MonoBehaviour
{
    public Transform targetObject;
    public float followDistance;
    public float followSpeed;
    public Animator npcAnimator;

    private void Start()
    {
        // It sets the initial targetObject to the GameObject with the tag "UserVampire".
        targetObject = GameObject.FindGameObjectWithTag("UserVampire").transform;
    }
    public void FollowTheUser()
    {
        Vector3 followDirection = targetObject.transform.position - transform.position;
        //transform.LookAt(targetObject);
        Quaternion quaternionRotation = Quaternion.LookRotation(followDirection, Vector3.up);
        transform.rotation = Quaternion.Slerp(transform.rotation, quaternionRotation, Time.deltaTime * 5f);

        float distanceToFollow = followDirection.magnitude;

        if(distanceToFollow > followDistance)
        {
            npcAnimator.Play("Slow Run");
            transform.Translate(followDirection.normalized * followSpeed * Time.deltaTime, Space.World);
        }
        else
        {
            npcAnimator.Play("Idle");
        }
    }

  

    private void Update()
    {
        FollowTheUser();
    }
}
