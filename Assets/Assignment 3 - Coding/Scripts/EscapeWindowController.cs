using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeWindowController : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "UserVampire")
        {
            Debug.Log("Player escaped through the window");
        }
        else if (other.tag == "VampireNPC1")
        {
            Debug.Log("Sophie escaped through the window");
        }
    }
}
