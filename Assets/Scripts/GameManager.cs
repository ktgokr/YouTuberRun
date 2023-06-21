using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using EnunTypes;

public class GameManager : MonoBehaviour
{
     #region singleton
    public static GameManager instance = null;
    private void Awake()
    {
        if(instance != null)
        {
            Destroy(this.gameObject);
        }    
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
    #endregion

    [SerializeField] bool GameState = true;
    public bool gameState {set{GameState = value;} get{return GameState;}}
    public Status status;

    [SerializeField] bool yellowSticker = false; 
    public bool yellowsticker {set{yellowSticker = value;} get{return yellowSticker;}}

#region RelateNum
    [Header("Money")]
    [SerializeField] int Money;
    [SerializeField] int TmpMoney;
    public int tmpMoney{set{TmpMoney = value;} get{return TmpMoney;}}
     [Header("SubScriber")]
    [SerializeField] int SubScribe;
    [SerializeField] int TmpSubScribe;
    public int subScribe{set{TmpSubScribe = value;} get{return TmpSubScribe;}}
    
#endregion
    
    
    void Start()
    {
        status = Status.Play;
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetKeyDown(KeyCode.P))
        // {
        //     if(TmpMoney < 0)
        //         TmpMoney = 0;
        //     if (TmpSubScribe < 0)
        //         TmpSubScribe = 0;
        //     if (Tmpview < 0)
        //         Tmpview = 0;
        //     if (TmpGood < 0)
        //         TmpGood = 0;
        //     if (TmpBad < 0)
        //         TmpBad = 0;
        //     Money = TmpMoney;
        //     SubScribe = TmpSubScribe;
        //     Good = TmpGood;
        //     Bad = TmpBad;
        //     View = Tmpview;
        //     // UIManager.instance_.UpdateImage();            
        // }
        if(status == Status.End)
        {
            if(TmpMoney < 0)
                TmpMoney = 0;
            if (TmpSubScribe < 0)
                TmpSubScribe = 0;

            if (yellowSticker)
            {
                TmpMoney = 0;
            }
            Money = TmpMoney;
            SubScribe = TmpSubScribe;                                
        }
        
        TextUpdate();
    }

    void TextUpdate()
    {
        UIManager.instance_.subscribe.text = TmpSubScribe.ToString();                
    }

    
}
