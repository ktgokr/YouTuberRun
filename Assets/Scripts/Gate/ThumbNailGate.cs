using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EnunTypes;
using TMPro;

public class ThumbNailGate : MonoBehaviour
{
    [SerializeField] Theme theme;
    [SerializeField] int viewNum;
    [SerializeField] int viewWrongNum;
    [SerializeField] GameObject goodParticle;
    [SerializeField] GameObject badParticle;
    [SerializeField] Transform pos;
    [SerializeField] TextMeshProUGUI Text;
    

    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(other.GetComponent<Player>().ChannelType == theme)
            {
                other.GetComponent<Player>().thumbnail.text = Text.text;
                GameManager.instance.view += viewNum;
                // UIManager.instance_.view.text = viewNum.ToString();
                Instantiate(goodParticle, pos.position, Quaternion.identity);
                Debug.Log("Good ThumbNail");
            }
            else
            {
                other.GetComponent<Player>().thumbnail.text = Text.text;
                GameManager.instance.view += viewWrongNum;
                // UIManager.instance_.view.text = viewNum.ToString();
                Instantiate(badParticle, pos.position, Quaternion.identity);
                Debug.Log("Wrong ThumbNail");
            }
           
        }
    }
}
