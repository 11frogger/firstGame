using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireworkSpawner : MonoBehaviour
{

    public GameObject myPrefab;
    float max = 0;
    float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "P1")
        {
            for(int i = 0; i < 6; i++)
            {
                GameObject temp = GameObject.Instantiate(myPrefab);
                Rigidbody tempRig = temp.GetComponent<Rigidbody>();
                tempRig.position = other.transform.position + (other.transform.forward *10);
                tempRig.velocity = new Vector3(Mathf.Cos(max)*speed, Mathf.Sin(max)*speed, 0);
                max += 6.28f/6f;
            }

        }
    }
}
