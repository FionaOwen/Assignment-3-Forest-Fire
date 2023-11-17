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
        // This method is responsible for making the NPC follow the user.
        // It calculates the direction from the NPC to the targetObject (user).
        Vector3 followDirection = targetObject.transform.position - transform.position;

        // Calculate the rotation needed to look at the targetObject while keeping the up direction as Vector3.up.
        Quaternion quaternionRotation = Quaternion.LookRotation(followDirection, Vector3.up);

        // Smoothly rotate the NPC towards the target using Quaternion.Slerp.
        transform.rotation = Quaternion.Slerp(transform.rotation, quaternionRotation, Time.deltaTime * 5f);

        // Calculate the distance between the NPC and the targetObject.
        float distanceToFollow = followDirection.magnitude;

        // If the distance is greater than the followDistance, start following the user.
        if (distanceToFollow > followDistance)
        {
            // Play the "Slow Run" animation.
            npcAnimator.Play("Slow Run");

            // Move the NPC towards the targetObject using Translate and the specified followSpeed.
            transform.Translate(followDirection.normalized * followSpeed * Time.deltaTime, Space.World);
        }
        else
        {
            // If the distance is less than or equal to the followDistance, play the "Idle" animation.
            npcAnimator.Play("Idle");
        }
    }

  
    private void Update()
    {
        // Call the FollowTheUser method to make the NPC follow the user.
        FollowTheUser();
    }
}
