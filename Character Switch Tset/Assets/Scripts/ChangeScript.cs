using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScript : MonoBehaviour
{
    //changes player sprite
    
    SpriteRenderer sR;
    public Sprite[] animals;
    public int a;

    void Start()
    {
        sR = gameObject.GetComponent<SpriteRenderer>() ;
    }
    
    public void Change()
    {
        sR.sprite = animals[a];
    }

    public void Button0()
    {
        a = 0;
    }

    public void Button1()
    {
        a = 1;
    }

    public void Button2()
    {
        a = 2;
    }
}
