using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move2d : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public KeyCode upKey;
    public KeyCode downKey;
    public KeyCode rightKey;
    public KeyCode leftKey;
    public float Speed;
    void Start()
    {
        Debug.Log("start");
        rigidbody2D = GetComponent<Rigidbody2D>();
       
         
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(upKey) && transform.position.y < 5)
        {
            rigidbody2D.velocity = Vector2.up * Speed;
        }
        else if (Input.GetKey(downKey) && transform.position.y > -5)
        {
            rigidbody2D.velocity = Vector2.down * Speed;
        }
        else if (Input.GetKey(rightKey))
        {
            rigidbody2D.velocity = Vector2.right * Speed;
        }
        else if (Input.GetKey(leftKey))
        {
            rigidbody2D.velocity = Vector2.left * Speed;
        }
        else
        {
            rigidbody2D.velocity = Vector2.zero * Speed;
        }







    }
}
