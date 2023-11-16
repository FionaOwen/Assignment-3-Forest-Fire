using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WerewolfController : MonoBehaviour
{
    [SerializeField]
    private GameObject playerGameObject;
    public Animator werewolfAnimator;
    public float minimumChargingDistance;
    public void Start()
    {
        playerGameObject = GameObject.FindGameObjectWithTag("Vampire");
    }
    private void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, playerGameObject.transform.position);
        if (distanceToPlayer > minimumChargingDistance)
        {
            StartChargeTowardsPlayer();

        }
        // We continuously check the distance between player and wolf 1.
        // If the distance between player and wolf less than minimumChargingDistance then we will stop charging else the wolf charge towards player.
    }
    public void StartChargeTowardsPlayer()
    {
        Vector3 position = -(playerGameObject.transform.position - transform.position).normalized;
        transform.Translate(position * Time.deltaTime);

    }

}
