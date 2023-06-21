using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfluenceGate : GateCommon
{
    
    void Start()
    {
        // badParticle = null;
    }

    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            // Instantiate(goodParticle, pos.position, Quaternion.identity);
            GameManager.instance.subScribe += num;       
            other.GetComponent<Player>().PlayParticle(4);  
            transform.parent.gameObject.SetActive(false);
        }
    }
}
