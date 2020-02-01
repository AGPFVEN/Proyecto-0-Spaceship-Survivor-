using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditorScript : MonoBehaviour
{
    //Declaring player and enemys
    public GameObject enemys;
    public GameObject wall;

    void Start()
    {
        
    }

    void Update()
    {
        Physics2D.IgnoreCollision(enemys.GetComponent<BoxCollider2D>(), wall.GetComponent<BoxCollider2D>());
    }
}
