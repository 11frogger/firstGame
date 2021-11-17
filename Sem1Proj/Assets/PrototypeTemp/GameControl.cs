using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public static GameControl control;
    public int[] timeRecord;
    // Start is called before the first frame update
    void Awake()
    {
        if(control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;
        }
        else if(control != this) {
            Destroy(gameObject);
        }
        timeRecord = new int[11];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
