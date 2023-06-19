using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SubscriberUpDown : MonoBehaviour
{    
    [SerializeField] int num;
    [SerializeField] TextMeshProUGUI Text_;

    void Start()
    {
        // Text_ = GetComponent<TextMeshProUGUI>();
        Text_.text = "Subscribe " + num.ToString();
    }
    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            GameManager.instance.subScribe += num; 
        }
    }
}
