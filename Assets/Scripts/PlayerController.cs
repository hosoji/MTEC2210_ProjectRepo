using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1f;
    SpriteRenderer sr;
    public Color ourColor;
    public LettersScript textScript;



    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

    }


    void Update()
    {

        float xMove = Input.GetAxisRaw("Horizontal");

        print(xMove);
        transform.Translate(xMove * speed * Time.deltaTime, 0, 0);


        if (Input.GetKey(KeyCode.R))
        {
            sr.color = ourColor;
            textScript.ChangeText("Pink");
            
            
        }
        else
        {
            sr.color = Color.white;
            textScript.ChangeText("White");
        }



    }


}
