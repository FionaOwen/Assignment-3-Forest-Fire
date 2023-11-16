using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManniquenAnimationController : MonoBehaviour
{
    public Animator manniquenAnimator;
    public GameObject werewolfPrefab;
    public string lastAnimationNameForTransition;
    public bool targetToPlayer;
    public void transitionToWerewolf() 
    { 
        if (manniquenAnimator.GetCurrentAnimatorStateInfo(0).IsName(lastAnimationNameForTransition) 
            && manniquenAnimator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f) 
        {
            WerewolfController wc =  Instantiate(werewolfPrefab,gameObject.transform.position, gameObject.transform.rotation).GetComponent<WerewolfController>();
            wc.targetThePlayer = targetToPlayer;  
            Debug.Log("Wolf condition for spawning acheived!");

            Destroy(gameObject);
        }
    }

    private void Update()
    {
        transitionToWerewolf();
    }
}
