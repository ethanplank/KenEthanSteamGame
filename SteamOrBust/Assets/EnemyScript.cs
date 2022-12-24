using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    // Start is called before the first frame update
    public bool goRight;
    private Rigidbody2D rb;
    private int speed = 5;
    void Start()
    {
       // goRight = true;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       // if (goRight)
        //{
            rb.velocity = new Vector2(speed, 0);
       // }
       // else {
        //    rb.velocity = new Vector2(-speed, 0);
         //   }

                
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        speed = -speed;
    }
}
