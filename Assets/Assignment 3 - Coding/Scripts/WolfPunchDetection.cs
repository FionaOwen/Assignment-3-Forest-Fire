using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfPunchDetection : MonoBehaviour
{
    public Animator wolfAnimator;
    private int numberOfTimesPunched;
    [SerializeField]
    private int maxNumberOfTimesPunched;

    // This method is called when another collider enters the trigger zone of this GameObject.
    public void OnTriggerEnter(Collider other)
    {
        // Check if the entering collider has the tag "Hand."
        if (other.tag == "Hand")
        {
            // Increment the numberOfTimesPunched when the "Hand" enters the trigger zone.
            numberOfTimesPunched = +1;

            // Output a log message with the current number of times punched.
            Debug.Log("Number of times punched " + numberOfTimesPunched);
        }
    }

    // This method checks if the number of times punched is greater than the maximum allowed.
    public void PunchCheck()
    {
        // Check if the numberOfTimesPunched is greater than the maxNumberOfTimesPunched.
        if (numberOfTimesPunched > maxNumberOfTimesPunched)
        {
            // If the condition is met, play the "sit" animation using the wolfAnimator.
            wolfAnimator.Play("sit");
        }
    }
}
