using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donation : MonoBehaviour
{
    [SerializeField] float sp;
    [SerializeField] int money;
    [SerializeField] GameObject particle;
    void Update()
    {
        transform.localRotation *= Quaternion.Euler(sp, 0, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            GameManager.instance.tmpMoney += money;
            Instantiate(particle, transform.position, Quaternion.identity);
            Debug.Log($"Player : {money} is Plus");            
        }
    }

}
