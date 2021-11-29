using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelHandlerM : MonoBehaviour
{
    
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject p4;
    public GameObject p5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setPanel(int p)
    {
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
            case 5:
                p1.SetActive(false);
                p2.SetActive(false);
                p3.SetActive(false);
                p4.SetActive(false);
                p5.SetActive(true);
                break;
            default:
                break;
        }
    }
}
