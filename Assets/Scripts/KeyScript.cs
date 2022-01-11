using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{

    public GameObject DestroyableWalls;

 void OnTriggerEnter(Collider other)
    {

        Destroy(DestroyableWalls);
        
    }
}
