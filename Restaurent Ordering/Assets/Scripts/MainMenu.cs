using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public bool MainMenuSelected = false;
        
    public void LoadScene (string Scenename)
    {
        MainMenuSelected = true;
        if (MainMenuSelected)
        {
            SceneManager.LoadScene(Scenename);
        }
               
    }	
}
