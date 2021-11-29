using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyT : MonoBehaviour
{
    // Start is called before the first frame update
    //public P1Script p1;
    Vector3 goal1;
    UnityEngine.AI.NavMeshAgent myNav = null;
    //public int goal = 0;
    //int SPEED = 1;
    public int myFlag = 0;
    // Start is called before the first frame update
    void Start()
    {
        myNav = this.gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
        //goal1 = GameObject.Find("Player1").transform.position;
        //myNav.destination = goal1;
        //myNav.Resume();
    }

    // Update is called once per frame
    void Update()
    {
        //goal1 = p1.transform.position;
        //myNav.destination = goal1;
        //myNav.Resume();
        
        if (myFlag == 1)
        {
            goal1 = GameObject.Find("Player1").transform.position;
            myNav.destination = goal1;
            //goal1 = p1.transform.position;
            //myNav.destination = goal1;
            //myNav.SetDestination(goal1);
            //myNav.Resume();
            myFlag = 0;
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
