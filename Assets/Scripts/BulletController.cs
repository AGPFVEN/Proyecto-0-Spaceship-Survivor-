using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float bTLimit = 10f;
    public float bulletSpeed = 20f;

    void FixedUpdate()
    {
        //Que pasen 40s
        if (bTLimit > 0)
        {
            bTLimit -= 1 * Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
