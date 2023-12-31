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

    [SerializeField]private Rigidbody rb;
    [SerializeField] Animator ani;
    Vector3 Direction;

    void Start()
    {
        //rb = transform.GetChild(0).GetComponent<Rigidbody>();
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
            GameManager.instance.status = EnunTypes.Status.Play;
        }
        if(Input.GetKeyDown(KeyCode.B))
        {
            GameState = false;
        }
        if(GameManager.instance.status == EnunTypes.Status.End || GameManager.instance.status == EnunTypes.Status.Fail)
        {
            GameState = false;
            MapSp = 0;
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
            ani.SetBool("Walk", GameState);
        }
        else
        {
            ani.SetBool("Walk", GameState);
        }
    }
#endregion
    
    public void Dance()
    {
        // ani.SetBool("Dance", true);
        StartCoroutine(HipHopDance());
    }

    IEnumerator HipHopDance()
    {
        
        yield return new WaitForSeconds(2f);
        ani.SetBool("Dance", true);
    }

   
}
