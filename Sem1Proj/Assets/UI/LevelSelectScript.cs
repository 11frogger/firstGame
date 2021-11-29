using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelectScript : MonoBehaviour
{

    GameObject recordText;
    GameObject levelNameText;
    GameObject goldTrophy;
    GameObject silverTrophy;
    GameObject bronzeTrophy;
    GameObject emptyTrophy;
    GameObject[] trophy;
    int levelNum;
    //int[,] recordTimes;
    // Start is called before the first frame update
    void Start()
    {
        levelNum = 0; //change to value 1 for final game?
        recordText = GameObject.Find("RecordText");
        levelNameText = GameObject.Find("LevelNameText");
        trophy = new GameObject[4] { GameObject.Find("TrophyPicG"), GameObject.Find("TrophyPicS"), GameObject.Find("TrophyPicB"), GameObject.Find("TrophyPicE") };
        for (int i = 0; i < 3; i++)
        {
            trophy[i].SetActive(false);
        }
        /*
        goldTrophy = GameObject.Find("TrophyPicG");
        silverTrophy = GameObject.Find("TrophyPicS");
        bronzeTrophy = GameObject.Find("TrophyPicB");
        emptyTrophy = GameObject.Find("TrophyPicE");
        */
        /*
        recordTimes = new int[11, 4]
        {
            {0, 20, 30, 40},
            {1, 20, 30, 40},
            {2, 20, 30, 40},
            {3, 20, 30, 41},
            {4, 20, 30, 32},
            {5, 20, 30, 26},
            {6, 20, 30, 10},
            {7, 20, 30, 6},
            {8, 20, 30, 40},
            {9, 20, 30, 10},
            {10, 20, 30, 40}
        };*/
        setLevelText(2);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setLevelDestination()
    {
        switch (levelNum)
        {
            case 0:
                GameControl.control.currentLevel = 0;
                SceneManager.LoadScene("PrototypeScene");
                break;
            case 1:
                GameControl.control.currentLevel = 1;
                //SceneManager.LoadScene("PrototypeScene");
                SceneManager.LoadScene("Track1");
                break;
            case 2:
                GameControl.control.currentLevel = 2;
                SceneManager.LoadScene("Track2");
                break;
            case 3:
                GameControl.control.currentLevel = 3;
                SceneManager.LoadScene("Track3");
                break;
            case 4:
                GameControl.control.currentLevel = 4;
                SceneManager.LoadScene("Track4");
                break;
            case 5:
                GameControl.control.currentLevel = 5;
                SceneManager.LoadScene("Track5");
                break;
            case 6:
                GameControl.control.currentLevel = 6;
                SceneManager.LoadScene("Track6");
                break;
            case 7:
                GameControl.control.currentLevel = 7;
                SceneManager.LoadScene("Track7");
                break;
            case 8:
                GameControl.control.currentLevel = 8;
                SceneManager.LoadScene("Track8");
                break;
            case 9:
                GameControl.control.currentLevel = 9;
                SceneManager.LoadScene("Track9");
                break;
            case 10:
                GameControl.control.currentLevel = 10;
                SceneManager.LoadScene("Track10");
                break;
            default:
                SceneManager.LoadScene("MenuScene");
                break;
        }
    }

    public void setLevelText(int x)
    {
        if (x == 2)
        {
            //if (levelNum == 10)
            if(levelNum == 5)
            {
                levelNum = 1;
            }
            else
            {
                levelNum += 1;
            }
        }

        if (x == 1)
        {
            if (levelNum == 1)
            {
                //levelNum = 10;
                levelNum = 5;
            }
            else
            {
                levelNum -= 1;
            }
        }

        /*switch(levelNum)
        {
            case 0:*/
        recordText.GetComponent<Text>().text = "Gold: " + GameControl.control.timeRecord[levelNum, 0] +
                                                        "\nSilver: " + GameControl.control.timeRecord[levelNum, 1] +
                                                        "\nBronze: " + GameControl.control.timeRecord[levelNum, 2] +
                                                        "\n\nRecord Time: " + GameControl.control.timeRecord[levelNum, 3];
        levelNameText.GetComponent<Text>().text = "Track " + levelNum;
        for (int k = 0; k < 3; k++)
        {
            trophy[k].SetActive(false);
        }
        trophy[3].SetActive(true);
        for (int i = 2; i >= 0; i--)
        {
            /*for (int k = 0; k < 4; k++)
            {
                trophy[k].SetActive(false);
            }*/
            //trophy[i].SetActive(true);
            if (GameControl.control.timeRecord[levelNum, 3] <= GameControl.control.timeRecord[levelNum, i])
            {
                //change trophy pic
                trophy[i + 1].SetActive(false);
                
                trophy[i].SetActive(true);


                /*
                switch (p)
                {
                    case 1:
                        p1.SetActive(true);
                        p2.SetActive(false);
                        p3.SetActive(false);
                        p4.SetActive(false);
                        p5.SetActive(false);
                        break;
                    case 2:
                        p1.SetActive(false);
                        p2.SetActive(true);
                        p3.SetActive(false);
                        p4.SetActive(false);
                        p5.SetActive(false);
                        break;
                    case 3:
                        p1.SetActive(false);
                        p2.SetActive(false);
                        p3.SetActive(true);
                        p4.SetActive(false);
                        p5.SetActive(false);
                        break;
                    case 4:
                        p1.SetActive(false);
                        p2.SetActive(false);
                        p3.SetActive(false);
                        p4.SetActive(true);
                        p5.SetActive(false);
                        break;
                    default:
                        break;
                
            }*/
            }
            /*case 1:
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
            case 7:
            case 8:
            case 9:
            case 10:
            default:
                levelNum = 1;
                break;
        }*/
        }

    }
}
