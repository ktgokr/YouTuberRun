using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EnunTypes;

public class ChannelType : MonoBehaviour
{
    [SerializeField] Theme channel;

    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            switch(channel)
            {
                case Theme.Trip:
                    other.GetComponent<PlayerController>().ChanelTheme(Theme.Trip);
                    Debug.Log("Trip Channel");
                    break;
                case Theme.Movie:
                    other.GetComponent<PlayerController>().ChanelTheme(Theme.Movie);
                    Debug.Log("Movie Channel");
                    break;
            }
           
        }
    }
}
