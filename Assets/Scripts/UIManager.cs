using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UIManager : MonoBehaviour
{
    #region singleton
    public static UIManager instance_ = null;
    private void Awake()
    {
        if(instance_ != null)
        {
            Destroy(this.gameObject);
        }    
        instance_ = this;
        
    }
    #endregion
    [Header("Text")]
    [SerializeField] TextMeshProUGUI Subscribe;
    public TextMeshProUGUI subscribe {set{ Subscribe = value;} get{return Subscribe;}}

    
    [Header("GameUI")]
    [SerializeField] GameObject PassUI;
    [SerializeField] GameObject GameUI;
    [SerializeField] GameObject FailUI;
    [SerializeField] GameObject WarningUI;
    bool warn = true;
    

    [Header("HideBtn")]
    [SerializeField] GameObject SubscribeBTN;
    [SerializeField] GameObject ShopBTN;
    [SerializeField] GameObject SettingBTN;
    [SerializeField] GameObject TapBTN;
    [SerializeField] GameObject NoThanksBTN;
    void Start()
    {
        Subscribe.text = "0";       
        SubscribeBTN.SetActive(false);
        NoThanksBTN.SetActive(false);
        WarningUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       switch(GameManager.instance.status)
       {
            case EnunTypes.Status.Play:
                    GameUI.SetActive(true);
                    FailUI.SetActive(false);
                    PassUI.SetActive(false);
                    SubscribeBTN.SetActive(true);
                    ShopBTN.SetActive(false);
                    SettingBTN.SetActive(false);
                    TapBTN.SetActive(false);
                break;
            case EnunTypes.Status.End:
                    StartCoroutine(Ending());
                break;
            case EnunTypes.Status.Fail:
                    GameUI.SetActive(false);
                    FailUI.SetActive(true);
                    PassUI.SetActive(false);
                break;
       }

        if(GameManager.instance.yellowsticker == true)
        {
            if(warn)
            {
                StartCoroutine(WarningSign());
            }
            
        }
    }

    IEnumerator Ending()
    {
        yield return new WaitForSeconds(2f);
        SubscribeBTN.SetActive(false);
        GameUI.SetActive(false);
        PassUI.SetActive(true);
        FailUI.SetActive(false);
        yield return new WaitForSeconds(2f);
        NoThanksBTN.SetActive(true);
    }
    
    IEnumerator WarningSign()
    {
        WarningUI.SetActive(true);
        yield return new WaitForSeconds(2f);
        WarningUI.SetActive(false);
        // yield return new WaitForSeconds(1f);
        // WarningUI.SetActive(true);
        // yield return new WaitForSeconds(1f);
        // WarningUI.SetActive(false);
        warn = false;
    }



}
