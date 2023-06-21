using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapOn : MonoBehaviour
{

    private void OnTriggerExit(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            other.GetComponent<Player>().CapOn();
        }
    }
}
