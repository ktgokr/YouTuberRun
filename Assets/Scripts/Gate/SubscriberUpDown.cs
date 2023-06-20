using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SubscriberUpDown : MonoBehaviour
{    
    [SerializeField] int num;
    [SerializeField] TextMeshProUGUI Text_;
    [SerializeField] GameObject goodParticle;
    [SerializeField] GameObject badParticle;
    [SerializeField] Transform pos;

    void Start()
    {        
        Text_.text = "Subscribe " + num.ToString();
    }
    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(num >= 0)
            {
                Instantiate(goodParticle, pos.position, Quaternion.identity);
            }
            else
            {
                Instantiate(badParticle, pos.position, Quaternion.identity);
            }

            GameManager.instance.subScribe += num; 
            // UIManager.instance_.subscribe.text = num.ToString();
        }
    }
}
