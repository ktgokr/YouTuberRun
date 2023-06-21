using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using EnunTypes;

public class Player : MonoBehaviour
{
    [Header("Change")]

    [SerializeField] SubScriberGrade subGrade;
    [SerializeField] Image ButtonImage;
    [SerializeField] Sprite[] ButtonSprite;
    [SerializeField] Material[] materials;
    private Renderer cubeRenderer;
    [SerializeField] TextMeshProUGUI ChannelName;
    public TextMeshProUGUI channelName {set{ChannelName = value;}get {return ChannelName;}}
    [SerializeField] GameObject yellosticker;
    [SerializeField] TextMeshProUGUI ButtonName;
    
    [Header("Particle")]
    [SerializeField] ParticleSystem[] particles;
    bool playParicle = false;
    
    void Start()
    {
        cubeRenderer = GetComponent<Renderer>();
    }
    void Update()
    {
        if(GameManager.instance.yellowsticker == true)
        {
            yellosticker.SetActive(true);
        }
        Grade();
        if(playParicle)
        {
            StartCoroutine(ChangeButtonParticle());
        }
    }

    void Grade()
    {
        switch (GameManager.instance.subScribe)
        {
            case int n when (n < 1000):
                subGrade = SubScriberGrade.Normal;
                ButtonImage.sprite = ButtonSprite[0];
                cubeRenderer.material = materials[0];
                ButtonName.text = " ";
                break;
            case int n when (n >= 1000 && n < 10000):
                subGrade = SubScriberGrade.Silver;
                ButtonImage.sprite = ButtonSprite[1];
                cubeRenderer.material = materials[1];
                ButtonName.text = "Silver";                
                break;
            case int n when (n >= 10000 && n < 100000):
                subGrade = SubScriberGrade.Gold;
                ButtonImage.sprite = ButtonSprite[2];
                cubeRenderer.material = materials[2];
                ButtonName.text = "Gold";                
                break;
            case int n when (n >= 100000):
                subGrade = SubScriberGrade.Diamond;
                ButtonImage.sprite = ButtonSprite[3];
                cubeRenderer.material = materials[3];
                ButtonName.text = "Diamond";                
                break;
        }
        
    }

    public void PlayParticle(int i)
    {        
        switch(i)
        {
            case 1: 
                particles[0].Play();
                break;
            case 2:
                particles[1].Play();
                break;
            case 3:
                particles[2].Play();
                break;
            case 4:
                particles[3].Play();
                break;
        }
    }
    
    IEnumerator ChangeButtonParticle()
    {
        PlayParticle(4);
        yield return new WaitForSeconds(1.5f);
        playParicle = false;

    }

}
