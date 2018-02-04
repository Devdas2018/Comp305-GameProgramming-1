using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickHandler : MonoBehaviour {
    //private int someNumber;
    public GameObject PixelguyObject;
    public Sprite sprite;
    private SpriteRenderer spriteRenderer;
    Rigidbody2D rBody;

    // Use this for initialization
    void Start()
    {
        //Debug.Log(someNumber);
        //rBody= PixelguyObject.GetComponent<Rigidbody2D>();
        spriteRenderer = PixelguyObject.GetComponent<SpriteRenderer>();
        //rBody.velocity = new Vector2(2, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseDown()
    {
        //rBody.velocity*=-1;
        spriteRenderer.sprite = sprite;
       
    }
    
}
