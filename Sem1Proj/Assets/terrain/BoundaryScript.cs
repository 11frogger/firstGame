using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryScript : MonoBehaviour
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

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "P1")
        {
            
            other.GetComponent<P1Script>().endOfTrack("You Fell", 0);
        }
        else if(other.gameObject.tag == "MainCamera")
        {

        }
        else
        {
            GameObject.Destroy(other.gameObject);
        }
    }
}
