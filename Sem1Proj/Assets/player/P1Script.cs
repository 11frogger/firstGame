using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P1Script : MonoBehaviour
{
    public int terrainType = 0;
    public int hp = 3;
    float speed = 0.2f;
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
    string timeResult;
    public int finalTime = 999;

    // Start is called before the first frame update
    void Start()
    {
        ctt = GameObject.Find("CTimeText");
        chp = GameObject.Find("HPText");
        tt = GameObject.Find("TimeText");
        p1 = GameObject.Find("GamePanel");
        p2 = GameObject.Find("RestartPanel");
        myRig = this.gameObject.GetComponent<Rigidbody>();
        p1.SetActive(true);
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
            
            endOfTrack(time + "", 1);
            terrainType = 0;
        }
        if (terrainType > 2)
        {

            myRig.velocity += transform.forward.normalized * speed * z;
            //speed += z / spdD;
            myRig.transform.Rotate(0, yAngle + x/3, 0, Space.Self);
        }
        if (terrainType > 1)
        {
            //myRig.velocity = new Vector3(myRig.velocity.x + x, 0, myRig.velocity.z + z).normalized * speed;
            
            //myRig.velocity = new Vector3(myRig.velocity.x + x,myRig.velocity.y,myRig.velocity.z + z).normalized * speed;
            
            myRig.velocity += transform.forward.normalized * speed * z * 1;
            //myRig.velocity = new Vector3(h, 0, z).normalized * SPEED + new Vector3(0, myRig.velocity.y, abc);
            //speed += z/spdD;
            myRig.transform.Rotate(0, yAngle + x, 0, Space.Self);

            //myRig.rotation = new Vector3(0, yAngle + x, 0);
            //myRig.velocity += new Vector3(myRig.velocity.x, myRig.velocity.y, myRig.velocity.z).normalized * SPEED;
        }
        ctt.GetComponent<Text>().text = "" + time;
        chp.GetComponent<Text>().text = "" + hp;
        if (hp <= 0)
        {
            
            endOfTrack("You Died", 0);
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
    
    

    public void endOfTrack(string t, int isNum)
    {
        myRig.constraints = RigidbodyConstraints.FreezePosition;
        p1.SetActive(false);
        p2.SetActive(true);
        tt = GameObject.Find("RestartPanel/TimeText");
        tt.GetComponent<Text>().text = "Time: " + t;
        finalTime = time;
        if(isNum == 1)
        {
            if(finalTime < GameControl.control.timeRecord[GameControl.control.currentLevel, 3])
            {
                GameControl.control.timeRecord[GameControl.control.currentLevel, 3] = finalTime;
            }
            if(finalTime < GameControl.control.timeRecord[GameControl.control.currentLevel, 2])
            {
                timeResult = "Bronze";
            }
            if (finalTime < GameControl.control.timeRecord[GameControl.control.currentLevel, 1])
            {
                timeResult = "Silver";
            }
            if (finalTime < GameControl.control.timeRecord[GameControl.control.currentLevel, 0])
            {
                timeResult = "Gold";
            }
        }
        else
        {
            timeResult = "Invalid Time";
        }
        tt = GameObject.Find("RestartPanel/TrophyText");
        tt.GetComponent<Text>().text = "Gold: " + GameControl.control.timeRecord[GameControl.control.currentLevel, 0] +
                                                        "\nSilver: " + GameControl.control.timeRecord[GameControl.control.currentLevel, 1] +
                                                        "\nBronze: " + GameControl.control.timeRecord[GameControl.control.currentLevel, 2] +
                                                        "\n\nRecord Time: " + GameControl.control.timeRecord[GameControl.control.currentLevel, 3] +
                                                        "\n\nYou got: " + timeResult;
    }

    
}
