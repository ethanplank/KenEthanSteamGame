using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D rb;
    private int speed = 5;
    // Start is called before the first frame update
    void Start()
    {
       rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      
            rb.velocity = new Vector2(Input.GetAxis("Horizontal")*speed, Input.GetAxis("Vertical")*speed);
        
    }
}