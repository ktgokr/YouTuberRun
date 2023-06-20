using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EnunTypes;

public class GoodBadButton : MonoBehaviour
{
    public GoodBad goodbad;
    [SerializeField] int num;
    [SerializeField] GameObject goodParticle;
    [SerializeField] GameObject badParticle;
    [SerializeField] Transform pos;
   void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            switch(goodbad)
            {
                case GoodBad.Good:
                    GameManager.instance.good += num;
                    // UIManager.instance_.good.text = num.ToString();
                    Instantiate(goodParticle, pos.position, Quaternion.identity);
                    Debug.Log("Good Gate");
                    break;
                case GoodBad.Bad:
                    GameManager.instance.bad += num;
                    // UIManager.instance_.good.text = num.ToString();
                    Instantiate(badParticle, pos.position, Quaternion.identity);
                    Debug.Log("Bad Gate");
                    break;
            }
           
        }
    }
}
