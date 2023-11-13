using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManniquenAnimationController : MonoBehaviour
{
    public Animator manniquenAnimator;
    public GameObject werewolfPrefab;
    public string lastAnimationNameForTransition;
    public void transitionToWerewolf() 
    { 
        if (manniquenAnimator.GetCurrentAnimatorStateInfo(0).IsName(lastAnimationNameForTransition) 
            && manniquenAnimator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f) 
        {
            Instantiate(werewolfPrefab,gameObject.transform.position, gameObject.transform.rotation);
            Debug.Log("Wolf condition for spawning acheived!");

            Destroy(gameObject);
        }
    }

    private void Update()
    {
        transitionToWerewolf();
    }
}
