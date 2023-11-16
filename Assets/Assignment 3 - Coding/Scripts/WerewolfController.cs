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
        float distanceToPlayer = Vector3.Distance(transform.position, targetGameObject.transform.position);
        if (distanceToPlayer > minimumChargingDistance)
        {
            StartChargeTowardsPlayer();

        }
        else
        {
            StopCharging();
        }

        // We continuously check the distance between player and wolf 1.
        // If the distance between player and wolf less than minimumChargingDistance then we will stop charging else the wolf charge towards player.
    }
    public void StartChargeTowardsPlayer()
    {   if (!isCharging) 
        {
            werewolfAnimator.Play("walk");
            isCharging = true;
        }
        Vector3 position = -(targetGameObject.transform.position - transform.position).normalized;
        transform.rotation = Quaternion.LookRotation(-position);
        transform.Translate(position *chargingSpeed* Time.deltaTime);
        

    }
    public void StopCharging()
    {
        werewolfAnimator.Play("attack1");
        isCharging = false;
    }

}
