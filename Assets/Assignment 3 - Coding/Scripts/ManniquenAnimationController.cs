using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManniquenAnimationController : MonoBehaviour
{
    public Animator manniquenAnimator;
    public GameObject werewolfPrefab;
    public string lastAnimationNameForTransition;
    public bool targetToPlayer;

    // This method is responsible for transitioning the mannequin to a werewolf.
    public void transitionToWerewolf() 
    {
        // Check if the current animation state of the mannequin matches the specified animation name.
        if (manniquenAnimator.GetCurrentAnimatorStateInfo(0).IsName(lastAnimationNameForTransition) 
            && manniquenAnimator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f) 
        {
            // If the conditions are met, instantiate a werewolf at the mannequin's position and rotation.
            WerewolfController wc =  Instantiate(werewolfPrefab,gameObject.transform.position, gameObject.transform.rotation).GetComponent<WerewolfController>();

            // Set the targetToPlayer property of the spawned werewolf based on the targetToPlayer variable in this script.
            wc.targetThePlayer = targetToPlayer;

            // Output a log message indicating that the condition for spawning a werewolf has been achieved.
            Debug.Log("Wolf condition for spawning acheived!");

            // Destroy the mannequin GameObject.
            Destroy(gameObject);
        }
        else
        {
            // If the conditions are not met, do nothing.
        }
    }

    private void Update()
    {
        // Call the transitionToWerewolf method in each frame to check for the transition conditions.
        transitionToWerewolf();
    }
}
