using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    //turns the buttons on and off
    
    public ButtonHide bH;
    public ChangeScript cS;

    void Start()
    {

    }
    
    void Update()
    {
        if(Input.GetKey(KeyCode.E))
        {
            Eun();
        }
        else
        {
            Euf();
        }
    }

    void Euf()
    {
        bH.Off();

    }

    void Eun()
    {
        bH.On();
        cS.Change();
    }
}