using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SelectorScript : MonoBehaviour
{
    public string[] stateString = {"1x1", "2x2", "L", "1"};
    public int state = 0;
    public GameObject Up1;
    public GameObject Up2;
    public GameObject Down1;
    public GameObject Right1;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        state = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        rb.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Up1.GetComponent<Rigidbody2D>().position =rb.position+new Vector2(0, 1);
        Up2.GetComponent<Rigidbody2D>().position = rb.position + new Vector2(0, 2);
        Down1.GetComponent<Rigidbody2D>().position = rb.position + new Vector2(0, -1);
        Right1.GetComponent<Rigidbody2D>().position = rb.position + new Vector2(1, 0);

        if (stateString[state] == "1x1")
        {
            Up1.SetActive(false);
            Up2.SetActive(false);
            Down1.SetActive(false);
            Right1.SetActive(false);
            transform.localScale = new Vector2(1, 1);
        }
        if (stateString[state] == "2x2")
        {
            transform.localScale = new Vector2(2, 2);
        }
        if (state == 3)
        {
            transform.localScale = new Vector2(1,1);
            Up1.SetActive(true);
            Up2.SetActive(true);
            Down1.SetActive(true);
            Right1.SetActive(false);
        }
        if (stateString[state] == "L")
        {
            transform.localScale = new Vector2(1, 1);

            Up1.SetActive(true);
            Up2.SetActive(true);
            Down1.SetActive(false);
            Right1.SetActive(true);

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            state++;
            if (state > 3)
            {
                state = 0;
            }
        }
    }
    //    private void OnTriggerEnter2D(Collision2D collision)
    //    {
    //        if (Input.GetMouseButtonDown(0))
    //        {
    //            collision.gameObject.GetComponent<SpriteRenderer>().color=Color.white;
    //        }
    //    }
}
