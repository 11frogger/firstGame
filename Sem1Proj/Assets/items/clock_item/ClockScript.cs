using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockScript : MonoBehaviour
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

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "P1")
        {
            other.GetComponent<P1Script>().timeSaved += 15;
            GameObject.Destroy(this.gameObject);
        }

    }
}
