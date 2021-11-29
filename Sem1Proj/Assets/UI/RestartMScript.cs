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
        switch(GameControl.control.currentLevel)
        {
            case 0:
                SceneManager.LoadScene("PrototypeScene");
                break;
            case 1:
                SceneManager.LoadScene("Track1");
                break;
            case 2:
                SceneManager.LoadScene("Track2");
                break;
            case 3:
                SceneManager.LoadScene("Track3");
                break;
            case 4:
                SceneManager.LoadScene("Track4");
                break;
            case 5:
                SceneManager.LoadScene("Track5");
                break;
            default:
                SceneManager.LoadScene("PrototypeScene");
                break;
        }
        
    }
}
