using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeWindowController : MonoBehaviour
{
    [SerializeField]
    private GameObject[] wolfArray;


    // This method is called when another collider enters the trigger zone of this GameObject.
    public void OnTriggerEnter(Collider other)
    {
        // Check if the entering collider has the tag "UserVampire."
        if (other.tag == "UserVampire")
        {
            // Check if the first element of the wolfArray is not null.
            if (wolfArray[0] != null)
            {
                // Deactivate (set inactive) the first wolf in the array.
                wolfArray[0].SetActive(false);

                // Output a log message indicating that the player escaped through the window.
                Debug.Log("Player escaped through the window");
            }
            else
            {
                // If the first element of the wolfArray is null, do nothing and return.
                return;
            }
        }
        // Check if the entering collider has the tag "VampireNPC1."
        else if (other.tag == "VampireNPC1")
        {
            // Check if the second element of the wolfArray is not null.
            if (wolfArray[1] != null)
            {
                // Deactivate (set inactive) the second wolf in the array.
                wolfArray[1].SetActive(false);

                // Output a log message indicating that Sophie (assumed character) escaped through the window.
                Debug.Log("Sophie escaped through the window");
            }
            else
            {
                // If the second element of the wolfArray is null, do nothing and return.
                return;
            }
        }
    }

    // This method finds all GameObjects with the tag "Wolf" and assigns them to the wolfArray.
    public void FindTheCompleteWolfPack()
    {
        wolfArray = GameObject.FindGameObjectsWithTag("Wolf");
    }

    private void Update()
    {
        // Call the FindTheCompleteWolfPack method in each frame to update the wolfArray.
        FindTheCompleteWolfPack();
    }
}
