using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    private Color origColor;
    // Start is called before the first frame update
    void Start()
    {
        origColor=gameObject.GetComponent<SpriteRenderer>().color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
    private void OnMouseEnter()
    {
        gameObject.GetComponent<SpriteRenderer>().color = Color.black;
    }
    private void OnMouseExit()
    {
        gameObject.GetComponent<SpriteRenderer>().color = origColor;
    }
}
