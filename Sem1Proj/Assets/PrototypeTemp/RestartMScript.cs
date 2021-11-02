using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartMScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onBackButtonClick()
    {
        // start a new scene with new character and items
        SceneManager.LoadScene("MenuScene");
    }

    public void onRestartButtonClick()
    {
        // start a new scene with new character and items
        SceneManager.LoadScene("PrototypeScene");
    }
}
