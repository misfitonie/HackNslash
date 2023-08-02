using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class _Sc_PlayerMovement : MonoBehaviour
{
    public static _Sc_PlayerMovement instance = null;
    public Camera cam= null;
    NavMeshAgent agent = null;

    private void Awake()
    {
        instance = this;
        agent = transform.GetComponent<NavMeshAgent>();
    }
    private void Start()
    {
        
    }
    private void Update()
    {
        if(Input.GetMouseButton(0))
        {
           Ray ray = cam.ScreenPointToRay(Input.mousePosition);
           RaycastHit hit;

           if( Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
           
        }
    }
}
