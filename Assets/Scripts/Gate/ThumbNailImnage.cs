using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using EnunTypes;

public class ThumbNailImnage : MonoBehaviour
{
    // [SerializeField] Theme theme;
    [SerializeField] Image image_;
    [SerializeField] int viewNum;
    [SerializeField] int viewWrongNum;
    [SerializeField] GameObject goodParticle;
    [SerializeField] GameObject badParticle;
    [SerializeField] Transform pos;
    

     void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            // if(other.GetComponent<Player>().ChannelType == theme)
            // {
            //     other.GetComponent<Player>().thumbnailImage.sprite = image_.sprite;
            //     UIManager.instance_.AddImageSprite(image_);
            //     Instantiate(goodParticle, pos.position, Quaternion.identity);
            //     Debug.Log("Good ThumbNailImage");
            // }
            // else
            // {
            //     other.GetComponent<Player>().thumbnailImage.sprite = image_.sprite;
            //     UIManager.instance_.AddImageSprite(image_);
            //     Instantiate(badParticle, pos.position, Quaternion.identity);
            //     Debug.Log("Wrong ThumbNailImage");
            // }
           
        }
    }
}
