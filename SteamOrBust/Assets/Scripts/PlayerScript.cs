using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5f;
    public float closeEnough = 0.05f;
    public float collideRadius = 0.2f;
    public MSM msm;
    public Transform moveDest;
    // Start is called before the first frame update
    void Start()
    {
       rb=GetComponent<Rigidbody2D>();
       moveDest.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, moveDest.position, speed * Time.deltaTime); 
        //rb.velocity = new Vector2(Input.GetAxis("Horizontal")*speed, Input.GetAxis("Vertical")*speed);
        Vector2 inp = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        if (Mathf.Abs(inp.x) > Mathf.Abs(inp.y))
            inp = new Vector2(inp.x, 0);
        else
            inp = new Vector2(0, inp.y);
        inp.Normalize();

        if (Vector3.Distance(transform.position, moveDest.position) < closeEnough)
        {
            if(!Physics2D.OverlapCircle(moveDest.position + new Vector3(inp.x, inp.y), collideRadius))
            {
                moveDest.position += new Vector3(inp.x, inp.y);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Portal")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            //  msm.Shuffle();
        }
        if (collision.gameObject.tag == "ReturnPortal")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

        }
        if (collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }
}
