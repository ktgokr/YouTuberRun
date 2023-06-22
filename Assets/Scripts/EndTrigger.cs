using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    [SerializeField] ParticleSystem particle;
    [SerializeField] ParticleSystem particle_;
    [SerializeField] Animator ani;
    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {            
            GameManager.instance.status = EnunTypes.Status.End;
            particle.Play();
            particle_.Play();
            ani.SetBool("Dance", true);
        }
    }
}
