using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Sc_Camera : MonoBehaviour
{
    [SerializeField] Transform target = null;

    bool aimAtPlayer = true;

    private void Awake()
    {
        
    }

    void Start()
    {
        target = _Sc_PlayerMovement.instance.transform;
    }

    void Update()
    {
        if(aimAtPlayer == true)
        {

        }
    }
}
