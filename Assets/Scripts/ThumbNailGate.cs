using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EnunTypes;
using TMPro;

public class ThumbNailGate : MonoBehaviour
{
    [SerializeField] Theme theme;
    [SerializeField] TextMeshProUGUI Text;
    

     void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(other.GetComponent<PlayerController>().ChannelType == theme)
            {
                other.GetComponent<PlayerController>().thumbnail.text = Text.text;
                Debug.Log("Good ThumbNail");
            }
            else
            {
                other.GetComponent<PlayerController>().thumbnail.text = Text.text;
                Debug.Log("Wrong ThumbNail");
            }
           
        }
    }
}
