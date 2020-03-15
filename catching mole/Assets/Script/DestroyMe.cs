using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMe : MonoBehaviour
{
    Collider col;

    void Start()
    {
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
}
