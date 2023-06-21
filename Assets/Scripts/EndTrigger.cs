using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            // GameManager.instance.gameState = false;
            GameManager.instance.status = EnunTypes.Status.End;
        }
    }
}
