using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyCircle : MonoBehaviour
{
    public P1Script p1;
    public Rigidbody myRig;
    float max = 0;
    float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        myRig = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Mathf.Cos()    Mathf.PI
        myRig.velocity = new Vector3(Mathf.Cos(max)*speed, 0, Mathf.Sin(max)*speed);
        max += 0.01f;
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
