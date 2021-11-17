using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyT : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 goal1;
    UnityEngine.AI.NavMeshAgent myNav = null;
    public int goal = 0;
    //int SPEED = 1;
    public int myFlag = 0;
    // Start is called before the first frame update
    void Start()
    {
        myNav = this.gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

        if (myFlag == 1)
        {
            goal1 = GameObject.Find("P1").transform.position;
            myNav.destination = goal1;
            myNav.Resume();
            myFlag = 0;
        }
    }
}
