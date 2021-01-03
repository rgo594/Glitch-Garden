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
            StartCoroutine(LoadStartScreenFromSplash());
        }
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene(scene.buildIndex + 1);
    }

    public IEnumerator LoadGameOver()
    {
        
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Game Over");
    }

    IEnumerator LoadStartScreenFromSplash()
    {
        yield return new WaitForSeconds(4);
        LoadNextScene();
    }

    public void LoadStartMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    } 

    public void LoadOptionsScene()
    {
        SceneManager.LoadScene(5);
    }

    public void RestartScene()
    {
        Time.timeScale = 1;
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }
}
