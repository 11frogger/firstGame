using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Collision : MonoBehaviour
{
    public P1Script p1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionStay(Collision C)
    {
        if (C.gameObject.tag == "SNOWFLOOR")
        {
            p1.GetComponent<P1Script>().terrainType = 2;
        }
        if (C.gameObject.tag == "ICEFLOOR")
        {
            p1.GetComponent<P1Script>().terrainType = 3;
        }
        if (C.gameObject.tag == "FINISHFLOOR")
        {
            p1.GetComponent<P1Script>().terrainType = 1;
        }
    }

    void OnCollisionExit(Collision C)
    {
        p1.GetComponent<P1Script>().terrainType = 0;
    }
}
