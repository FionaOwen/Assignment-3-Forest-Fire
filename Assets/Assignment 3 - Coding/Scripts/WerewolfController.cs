using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WerewolfController : MonoBehaviour
{
    [SerializeField]
    private GameObject targetGameObject;
    public Animator werewolfAnimator;
    public float minimumChargingDistance;
    public float chargingSpeed;
    public bool isCharging;
    public bool targetThePlayer;


    public void Start()
    {
        // It sets the initial targetGameObject based on the value of the targetThePlayer variable.
        if (targetThePlayer)
        {
            targetGameObject = GameObject.FindGameObjectWithTag("UserVampire");
        }
        else 
        {
            targetGameObject = GameObject.FindGameObjectWithTag("VampireNPC1");
        }
    }
          
    
    private void Update()
    {
        // It calculates the distance between the werewolf and the targetGameObject.
        float distanceToPlayer = Vector3.Distance(transform.position, targetGameObject.transform.position);

        // If the distance to the target is greater than the minimumChargingDistance, start charging.
        if (distanceToPlayer > minimumChargingDistance)
        {
            StartChargeTowardsPlayer();

        }
        else
        {
            // If the distance is less than or equal to minimumChargingDistance, stop charging.
            StopCharging();
        }
    }


    public void StartChargeTowardsPlayer()
    {  
        // This method is called to start the charging behavior.
        // If the werewolf is not already charging, it plays the "walk" animation and sets isCharging to true.
        if (!isCharging) 
        {
            werewolfAnimator.Play("walk");
            isCharging = true;
        }
        // Calculate the normalized direction vector from the werewolf to the targetGameObject.
        Vector3 position = (targetGameObject.transform.position - transform.position).normalized;

        // Rotate the werewolf to face the target.
        transform.rotation = Quaternion.LookRotation(position);

        // Move the werewolf towards the target using Translate and the specified charging speed.
        transform.Translate(position *chargingSpeed* Time.deltaTime, Space.World);
    }


    public void StopCharging()
    {
        // This method is called to stop the charging behavior.
        // It plays the "attack1" animation and sets isCharging to false.
        werewolfAnimator.Play("attack1");
        isCharging = false;
    }

}
