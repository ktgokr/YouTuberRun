using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using EnunTypes;

public class PlayerController : MonoBehaviour
{
    [Header("SwipeContrl")]
    [SerializeField] bool click;
    [SerializeField] float runSpeed;    
    [SerializeField] float swipeSpeed;
    
    [Space(10)]
    [SerializeField] Transform Map;
    [SerializeField] bool GameState = false;
    [SerializeField] float MapSp;

    private Rigidbody rb;
    Vector3 Direction;

    [Header("Change")]
    public Theme ChannelType = Theme.None;
    [SerializeField] Image ThumbnailImage_;
    public Image thumbnailImage {set{ThumbnailImage_ = value;}get {return ThumbnailImage_;}}
    [SerializeField] TextMeshProUGUI ThumbNail;
    public TextMeshProUGUI thumbnail{set{ThumbNail = value;}get {return ThumbNail;}}
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        if(Input.GetMouseButton(0))
        {      
            click = true;                                                                      
        }
        else
        {
            click = false;                                  
        }

       Status();

        if(Input.GetKeyDown(KeyCode.A))
        {
            GameState = true;            
        }
        if(Input.GetKeyDown(KeyCode.B))
        {
            GameState = false;
        }
        
    }

#region MoveMent
     void FixedUpdate() 
    {
        if (click)
        {
            Vector3 displacement = new Vector3(Direction.x, 0f, 0f) * Time.fixedDeltaTime;          
            rb.velocity = new Vector3(Direction.x * Time.fixedDeltaTime * swipeSpeed, 0f, 0f) + displacement;            
        }
        else
        {                               
            rb.velocity = Vector3.zero;            
        }
    }

    void Status()
    {
        if (GameState)
        {
            Direction = new Vector3(Mathf.Lerp(Direction.x, Input.GetAxis("Mouse X"), Time.deltaTime * runSpeed), 0f);

            Direction = Vector3.ClampMagnitude(Direction, 1f);
            Map.transform.Translate(Vector3.back * MapSp * Time.deltaTime);

        }
        else
        {
            
        }
    }
#endregion
    

    public Theme ChanelTheme(Theme theme)
    {
        ChannelType = theme;
        return ChannelType;
    }
}
