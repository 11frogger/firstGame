using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
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

    void OnTriggerEnter(Collider C)
    {
        if (C.gameObject.tag == "P1")
        {
            C.GetComponent<P1Script>().hp -= 1;
            GameObject.Destroy(this.gameObject);
        }

    }
}
