using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    [SerializeField] GameObject winLabel;
    [SerializeField] GameObject loseLabel;
    int numberOfAttackers = 0;
    bool levelTimerFinished = false;
    [SerializeField] float nextLevelDelay = 2f;

    private void Start()
    {
        loseLabel.SetActive(false);
        winLabel.SetActive(false);
    }

    void Update()
    {

        if (numberOfAttackers <= 0 && levelTimerFinished)
        {
            StartCoroutine(WinScreen());
        }
    }

    IEnumerator WinScreen()
    {
        winLabel.SetActive(true);
        yield return new WaitForSeconds(nextLevelDelay);
        FindObjectOfType<SceneLoader>().LoadNextScene();
    }

    public void LoseScreen()
    {
        loseLabel.SetActive(true);
        Time.timeScale = 0;
    }

    public void AttackerSpawned()
    {
        numberOfAttackers++;
    }

    public void AttackerKilled()
    {
        numberOfAttackers--;
    }

    public void LevelTimerFinished()
    {
        levelTimerFinished = true;
        StopSpawners();
    }

    private void StopSpawners()
    {
        AttackerSpawner[] spawnerArray = FindObjectsOfType<AttackerSpawner>();
        foreach (AttackerSpawner spawner in spawnerArray)
        {
            spawner.StopSpawning();
        }
    }
}
