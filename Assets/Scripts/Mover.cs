using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    [SerializeField]  Transform target;
    Ray lastRay;

     public void Update()
     {
         if (Input.GetMouseButtonDown(0))
         {
             lastRay = Camera.main.ScreenPointToRay(Input.mousePosition);
         }
         Debug.DrawRay(lastRay.origin, lastRay.direction * 100, Color.black);
         
         GetComponent<NavMeshAgent>().destination = target.position;
     }
}
