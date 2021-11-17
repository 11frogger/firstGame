using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelHandlerM : MonoBehaviour
{
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject p4;
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
            case 0:
                p1.SetActive(true);
                p2.SetActive(false);
                break;
            case 1:
                p1.SetActive(false);
                p2.SetActive(true);
                break;
            default:
                break;
        }
    }
}
