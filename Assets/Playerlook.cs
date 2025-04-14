using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerlook : MonoBehaviour
{
   float MouseSpeed=80;
   [SerializeField]Transform player;
   float xRotaion=0; 
     private void  Update()
    {
    float mouseX=Input.GetAxis("Mouse X");
    float mouseY=Input.GetAxis("Mouse Y");

    xRotaion-=mouseY;
    

    //Player.Rotate(Vector3.up*mouseX);
   } 
}