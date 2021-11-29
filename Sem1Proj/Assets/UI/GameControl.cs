using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public static GameControl control;
    public int[,] timeRecord;
    public int currentLevel;
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
    }

    void Start()
    {
        control.timeRecord = new int[11, 4]
        {
            {0, 999, 999, 999},
            {1, 20, 300, 999},
            {2, 20, 300, 40},
            {3, 20, 300, 41},
            {4, 20, 300, 32},
            {5, 20, 300, 26},
            {6, 20, 30, 10},
            {7, 20, 30, 6},
            {8, 20, 30, 40},
            {9, 20, 30, 10},
            {10, 20, 30, 40}
        };
        currentLevel = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
