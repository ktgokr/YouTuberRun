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

    [SerializeField] List<Image> images;
    [SerializeField] List<Sprite> SpriteList;
    
    [Header("VLog")]
    [SerializeField] RectTransform Vlog;
    [SerializeField] float VlogSp;
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
        if(GameManager.instance.gameState == false)
        {
            UIManager.instance_.UpdateImage();  
            StartCoroutine(PlayVlog_());            
        }
    }

    public void UpdateImage()
    {
        for(int i = 0; i < images.Count; i++)
        {
            images[i].sprite  = SpriteList[i];
        }
    }


    IEnumerator PlayVlog_()
    {
        Vlog.anchoredPosition += Vector2.left * VlogSp * Time.deltaTime;
        yield return new WaitForSeconds(8f);
        VlogSp =0;
    }
    public void AddImageSprite(Image image_)
    {
        SpriteList.Add(image_.sprite);
    }
}
