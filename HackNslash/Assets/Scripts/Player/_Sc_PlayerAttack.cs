using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Sc_PlayerAttack : MonoBehaviour
{
        [SerializeField]
    bool isAttacking = false;
    // Update is called once per frame
    void Update()
    {
        
        if(_Sc_PlayerControls.instance.attackIsPressed == true){

            isAttacking = true;

        }
    }


    void Attack(){
        
    }
}
