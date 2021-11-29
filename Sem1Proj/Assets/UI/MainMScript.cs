using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onStartButtonClick()
    {
        // start a new scene with new character and items
        SceneManager.LoadScene("PrototypeScene");
    }
    public void onInstructionsButtonClick()
    {
        // start a new scene with new character and items
        SceneManager.LoadScene("PrototypeScene");
    }
    public void onOptionsButtonClick()
    {
        // start a new scene with new character and items
        SceneManager.LoadScene("PrototypeScene");
    }
    public void onCreditsButtonClick()
    {
        // start a new scene with new character and items
        SceneManager.LoadScene("PrototypeScene");
    }
}
