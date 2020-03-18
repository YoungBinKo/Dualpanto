using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleBehavior : MonoBehaviour
{
    Collider col;
    public int hitPoints = 1;

    [HideInInspector]public Animator anim;//to have animator component conector
    //HideInInspector makes a variable not show up in the inspector but be serialized

    void Start()
    {
        anim = GetComponent<Animator>();

        col = GetComponent<Collider>();//get the Component from gameObj which is type of Collider
        col.enabled = false;//this collider will be disable by start
    }
    public void DestroyObj()
    {
        Destroy(gameObject);
    }
    public void SwitchCollider(int num)
    {
        col.enabled = (num == 0) ? false : true;
    }

    //FOR hitPOINTS
    public void GotHit()
    {
        hitPoints--;

        if(hitPoints > 0)
        {
            col.enabled = true;
        }
        else
        {
            Destroy(gameObject);
        }
        
    }
}
