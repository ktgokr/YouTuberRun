using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SubscriberUpDown : GateCommon
{    

    [SerializeField] TextMeshProUGUI Text_;
   
    void Start()
    {        
        // Text_.text = num.ToString();
    }
    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(classify == EnunTypes.Classify.Alter)
            {
                GameManager.instance.yellowsticker = true;     
            }
            if(num >= 0)
            {
                // Instantiate(goodParticle, pos.position, Quaternion.identity);
                other.GetComponent<Player>().PlayParticle(1);
            }
            else
            {
                // Instantiate(badParticle, pos.position, Quaternion.identity);
                other.GetComponent<Player>().PlayParticle(2);
            }

            GameManager.instance.subScribe += num;   
            transform.parent.gameObject.SetActive(false);          
            Debug.Log("Gate sub");
        }
    }
}
