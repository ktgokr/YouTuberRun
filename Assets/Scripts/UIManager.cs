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
    [SerializeField] TextMeshProUGUI View;
    public TextMeshProUGUI view {set{ View = value;} get{return View;}}
    [SerializeField] TextMeshProUGUI Good;
    public TextMeshProUGUI good {set{ Good = value;} get{return Good;}}
    [SerializeField] TextMeshProUGUI Bad;
    public TextMeshProUGUI bad {set{ Bad = value;} get{return Bad;}}
    
    [Header("GameUI")]
    [SerializeField] GameObject PassUI;
    [SerializeField] GameObject GameUI;
    [SerializeField] GameObject FailUI;
    void Start()
    {
        Subscribe.text = "0";
        View.text = "0";
        Good.text = "0";
        Bad.text = "0";
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
                break;
            case EnunTypes.Status.End:
                    GameUI.SetActive(false);
                    FailUI.SetActive(false);
                    PassUI.SetActive(true);
                break;
            case EnunTypes.Status.Fail:
                    GameUI.SetActive(false);
                    FailUI.SetActive(true);
                    PassUI.SetActive(false);
                break;
       }
    }

    



}
