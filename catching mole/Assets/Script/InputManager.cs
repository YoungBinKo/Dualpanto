using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    
    void Update()
    {
        if(Input.GetMouseButtonDown(0))//0:left mouse button, 1:right mouse button 2:middle
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);//creat ray
            //Ray ScreenPointToRay(Vector3 position) : Return a ray going from camera through a screen point.
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))//physics check
            {
                if(hit.collider.tag == "Mole") 
                {
                    MoleBehavior mole = hit.collider.gameObject.GetComponent<MoleBehavior>();
                    //get the MoleBehavior from the Mole, that i hit

                    mole.SwitchCollider(0);//turning off

                    mole.anim.SetTrigger("hit");//using Trigger for calling animation

                    //Debug.Log(hit.collider.gameObject + " got hit ");//check what we hit Mole
                }
                
            }
        }
    }
}
