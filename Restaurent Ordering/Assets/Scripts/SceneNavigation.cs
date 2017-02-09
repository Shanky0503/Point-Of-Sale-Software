using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneNavigation : MonoBehaviour
{
    public void SceneChanger(int SceneNumber)
    {
        SceneManager.LoadScene(SceneNumber);
    }
}
