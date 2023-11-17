using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfPunchDetection : MonoBehaviour
{
    public Animator wolfAnimator;
    private int numberOfTimesPunched;
    [SerializeField]
    private int maxNumberOfTimesPunched;

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Hand")
        {
            numberOfTimesPunched = +1;
            Debug.Log("Number of times punched " + numberOfTimesPunched);
        }
    }

    public void PunchCheck()
    {
        if(numberOfTimesPunched > maxNumberOfTimesPunched)
        {
            wolfAnimator.Play("sit");
        }
    }
}
