using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGeneral : MonoBehaviour
{
    public enemyT p1;
    public GameObject[] et;
    // Start is called before the first frame update
    void Start()
    {
        et = GameObject.FindGameObjectsWithTag("ENEMYT");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider C)
    {
        if (C.gameObject.tag == "P1")
        {
            foreach(GameObject x in et)
                x.GetComponent<enemyT>().myFlag = 1;
        }
    }
}
