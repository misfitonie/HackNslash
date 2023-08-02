using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Sc_PlayerControls : MonoBehaviour
{
    
    [SerializeField]
    float zValue = 0;

    [SerializeField]
    float sValue = 0;

    [SerializeField]
    float qValue = 0;

    [SerializeField]
    float dValue = 0;

    public static _Sc_PlayerControls instance;
    public bool attackIsPressed = false;

    public Vector2 direction = Vector2.zero;

    private void Start()
    {
        instance = this;
    }
    void Update()
    {

        if(Input.GetMouseButtonDown(1)){
            attackIsPressed = true;
        }
        else if(Input.GetMouseButtonUp(1)){
            attackIsPressed = false;
        }

       /* if(Input.GetKeyDown(KeyCode.UpArrow)){

            zValue = 1;
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow)){
            zValue = 0;
        }       


        if(Input.GetKeyDown(KeyCode.DownArrow)){

            sValue = -1;
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow)){
            sValue = 0;
        }  


        if(Input.GetKeyDown(KeyCode.LeftArrow)){

            qValue = -1;
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow)){
            qValue = 0;
        }   

               
        if(Input.GetKeyDown(KeyCode.RightArrow)){

            dValue = 1;
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow)){
            dValue = 0;
        }    

        direction = new Vector2(qValue+dValue,zValue+sValue);*/

    }
}