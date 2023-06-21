using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EnunTypes;

public class SubUnSubButton : GateCommon
{
    [SerializeField] GameObject goodParticle;
    [SerializeField] GameObject badParticle;
    [SerializeField] SuborUnSub suborUnSub;
    [SerializeField] Transform pos;
    void Start()
    {
        switch(suborUnSub)
        {
            case SuborUnSub.Subscribe:
                badParticle = null;
                break;
            case SuborUnSub.UnSubscribe:
                goodParticle = null;
                break;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(num >= 0)
            {
                Instantiate(goodParticle, pos.position, Quaternion.identity);
                // other.GetComponent<Player>().PlayParticle(1);
            }
            else
            {
                Instantiate(badParticle, pos.position, Quaternion.identity);
                // other.GetComponent<Player>().PlayParticle(2);
            }

            GameManager.instance.subScribe += num;      
            Debug.Log("Button sub");
            gameObject.SetActive(false);
        }
    }
}
