using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heroControllerScript : MonoBehaviour
{
    public Animator myAnime;
    float h;
    float v;
    // Start is called before the first frame update
    void Start()
    {
        myAnime = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
        if (h>0)
        {
            myAnime.SetInteger("FBLRNNNN", 3);
            if (h<=0)
            {
                myAnime.SetInteger("FBLRNNNN", 7);
            }
        }
        else if (h < 0)
        {
            myAnime.SetInteger("FBLRNNNN", 2);
            if (h >= 0)
            {
                myAnime.SetInteger("FBLRNNNN", 6);
            }
        }
        else if (v > 0)
        {
            myAnime.SetInteger("FBLRNNNN", 0);
            if (v <= 0)
            {
                myAnime.SetInteger("FBLRNNNN", 4);
            }
        }
        else if (v < 0)
        {
            myAnime.SetInteger("FBLRNNNN", 1);
            if (v >= 0)
            {
                myAnime.SetInteger("FBLRNNNN", 5);
            }
        }
    }
}
