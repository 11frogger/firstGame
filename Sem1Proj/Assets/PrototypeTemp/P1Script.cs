using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P1Script : MonoBehaviour
{
    public int terrainType = 0;
    public int hp = 3;
    float speed = 1;
    float spdD = 50;
    public Rigidbody myRig;
    int time = 0;
    public int timeSaved = 0;
    public GameObject ctt;
    public GameObject tt;
    public GameObject chp;
    public GameObject p1;
    public GameObject p2;
    float yAngle = 0;

    // Start is called before the first frame update
    void Start()
    {
        ctt = GameObject.Find("CTimeText");
        chp = GameObject.Find("HPText");
        tt = GameObject.Find("TimeText");
        p1 = GameObject.Find("GamePanel");
        p2 = GameObject.Find("RestartPanel");
        myRig = this.gameObject.GetComponent<Rigidbody>();
        p2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float z = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Horizontal");
        time = (int)System.TimeSpan.FromSeconds(Time.timeSinceLevelLoad).TotalSeconds - timeSaved;
        if (terrainType == 1)
        {
            
            endOfTrack(time + "");
            terrainType = 0;
        }
        if (terrainType > 2)
        {

            myRig.velocity = transform.forward * speed;
            speed += z / spdD;
            myRig.transform.Rotate(0, yAngle + x/3, 0, Space.Self);
        }
        if (terrainType > 1)
        {
            //myRig.velocity = new Vector3(myRig.velocity.x + x, 0, myRig.velocity.z + z).normalized * speed;
            
            //myRig.velocity = new Vector3(myRig.velocity.x + x,myRig.velocity.y,myRig.velocity.z + z).normalized * speed;
            
            myRig.velocity = transform.forward * speed;
            speed += z/spdD;
            myRig.transform.Rotate(0, yAngle + x, 0, Space.Self);

            //myRig.rotation = new Vector3(0, yAngle + x, 0);
            //myRig.velocity += new Vector3(myRig.velocity.x, myRig.velocity.y, myRig.velocity.z).normalized * SPEED;
        }
        ctt.GetComponent<Text>().text = "" + time;
        chp.GetComponent<Text>().text = "" + hp;
        if (hp == 0)
        {
            
            endOfTrack("Fail: You Died");
        }
    }
    
    void OnCollisionStay(Collision C)
    {
        if (C.gameObject.tag == "SNOWFLOOR")
        {
            terrainType = 2;
        }
        if (C.gameObject.tag == "ICEFLOOR")
        {
            terrainType = 3;
        }
        if (C.gameObject.tag == "FINISHFLOOR")
        {
            terrainType = 1;
        }
    }

    void OnCollisionExit(Collision C)
    {
        terrainType = 0;
    }
    
    

    public void endOfTrack(string t)
    {
        myRig.constraints = RigidbodyConstraints.FreezePosition;
        p1.SetActive(false);
        p2.SetActive(true);
        tt = GameObject.Find("RestartPanel/TimeText");
        tt.GetComponent<Text>().text = "Time: " + t;
    }

    
}
