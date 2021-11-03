using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyLR : MonoBehaviour
{
    public P1Script p1;
    public Rigidbody myRig;
    float max = 0;
    float speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        myRig = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        myRig.velocity = new Vector3(speed, 0, 0);
        max += 0.01f;
        if (max >= 10 || max <= 0)
        {
            speed *= -1;
            max -= 10;
        }
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
