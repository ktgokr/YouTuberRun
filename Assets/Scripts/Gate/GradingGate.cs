using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EnunTypes;

public class GradingGate : GateCommon
{    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            switch(classify)
            {
                case Classify.Safe:
                    GameManager.instance.subScribe += num;
                    // Instantiate(goodParticle, pos.position, Quaternion.identity);
                    other.GetComponent<Player>().PlayParticle(1);
                    Debug.Log("Good Gate");
                    break;
                case Classify.Alter:
                    GameManager.instance.yellowsticker = true;              
                    // Instantiate(badParticle, pos.position, Quaternion.identity);
                    other.GetComponent<Player>().PlayParticle(2);
                    Debug.Log("Bad Gate");
                    break;
                case Classify.Danger:
                    GameManager.instance.status = Status.Fail;
                    // Instantiate(badParticle, pos.position, Quaternion.identity);
                    other.GetComponent<Player>().PlayParticle(2);
                    Debug.Log("Bad Gate");
                    break;
            }
            transform.parent.gameObject.SetActive(false);
           
        }
    }
}
