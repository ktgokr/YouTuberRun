using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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

    [Header("Money")]
    [SerializeField] int Money;
    [SerializeField] int TmpMoney;
    public int tmpMoney{set{TmpMoney = value;} get{return TmpMoney;}}
     [Header("SubScriber")]
    [SerializeField] int SubScribe;
    [SerializeField] int TmpSubScribe;
    public int subScribe{set{TmpSubScribe = value;} get{return TmpSubScribe;}}
    
    [Header("Good/Bad")]
    [SerializeField] int Good;
    [SerializeField] int TmpGood;
    public int good{set{TmpGood = value;} get{return TmpGood;}}
    [SerializeField] int Bad;
    [SerializeField] int TmpBad;
    public int bad {set{TmpBad = value;} get{return TmpBad;}}


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            Money = TmpMoney;
            SubScribe = TmpSubScribe;
            Good = TmpGood;
            Bad = TmpBad;
        }
    }
}
