using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleBehavior : MonoBehaviour
{
    public GameObject[] moles;//array of GameObject

    void Start()
    {
        //Invoke("Spawn", 3f);//call methode after giving of time in second, make sure it's same name as methode
        Invoke("Spawn", Random.Range(3f, 7f));//invoke once again
    }
    //spawn after start
    void Spawn()
    {
        int num = Random.Range(0, moles.Length);//randomly spawn gameobject
        //Range(float min, float max); REturns a random float number between and min and max

        GameObject mole = Instantiate(moles[num],transform.position,Quaternion.identity) as GameObject;//instantiate choosing Object
        //Instantiate(objct original, Vector3 position, Quaternion rotation) Clones the object original and returns the clone
        
        Invoke("Spawn", Random.Range(3f, 7f));//invoke once again

    }
}
