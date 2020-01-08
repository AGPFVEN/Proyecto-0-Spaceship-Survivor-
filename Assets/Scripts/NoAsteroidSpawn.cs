using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoAsteroidSpawn : MonoBehaviour
{
    public bool anoser; 

    void Start()
    {
        anoser = false;
    }

    void OnCollisionEnter2D()
    {
        anoser = true;
    }

    void OnCollisionExit()
    {
        anoser = false;
    }

    //public bool Nocool ()
    //{
    //    if (2 < 3)
    //    {
    //        return(true);
    //    }
    //    else
    //    {
    //        return(false);
    //    }
    //}
}
