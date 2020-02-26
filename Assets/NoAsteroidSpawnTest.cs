using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoAsteroidSpawnTest : MonoBehaviour
{
    Collider col;
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponentInChildren<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    { 

    }
}
