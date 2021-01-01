using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    Scene scene;
    void Start()
    {
        scene = SceneManager.GetActiveScene();
        if (scene.buildIndex == 0)
        {
            StartCoroutine(LoadStartScreen());
        }
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene(scene.buildIndex + 1);
    }

    public IEnumerator LoadGameOver()
    {
        
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(4);
    }

    IEnumerator LoadStartScreen()
    {
        yield return new WaitForSeconds(4);
        LoadNextScene();
    }
}
