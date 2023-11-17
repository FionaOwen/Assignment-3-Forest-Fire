using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeWindowController : MonoBehaviour
{
    [SerializeField]
    private GameObject[] wolfArray;


    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "UserVampire")
        {
            if (wolfArray[0] != null)
            {
                wolfArray[0].SetActive(false);
                Debug.Log("Player escaped through the window");
            }
            else
            {
                return;
            }
        }
        else if (other.tag == "VampireNPC1")
        {
            if (wolfArray[1] != null)
            {
                wolfArray[1].SetActive(false);
                Debug.Log("Sophie escaped through the window");
            }
            else
            {
                return;
            }
        }
    }

    public void FindTheCompleteWolfPack()
    {
        wolfArray = GameObject.FindGameObjectsWithTag("Wolf");
    }

    private void Update()
    {
        FindTheCompleteWolfPack();
    }
}
