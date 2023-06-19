using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EnunTypes;

public class GoodBadButton : MonoBehaviour
{
    public GoodBad goodbad;
    [SerializeField] int num;    
   void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            switch(goodbad)
            {
                case GoodBad.Good:
                    GameManager.instance.good += num;
                    Debug.Log("Good Gate");
                    break;
                case GoodBad.Bad:
                    GameManager.instance.good += num;
                    Debug.Log("Bad Gate");
                    break;
            }
           
        }
    }
}
