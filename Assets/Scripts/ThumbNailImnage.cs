using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using EnunTypes;

public class ThumbNailImnage : MonoBehaviour
{
    [SerializeField] Theme theme;
    [SerializeField] Image image_;
    

     void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(other.GetComponent<PlayerController>().ChannelType == theme)
            {
                other.GetComponent<PlayerController>().thumbnailImage.sprite = image_.sprite;
                Debug.Log("Good ThumbNailImage");
            }
            else
            {
                other.GetComponent<PlayerController>().thumbnailImage.sprite = image_.sprite;
                Debug.Log("Wrong ThumbNailImage");
            }
           
        }
    }
}
