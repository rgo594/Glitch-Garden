using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    [SerializeField] public float lifeCount = 3;

    private void Start()
    {
        lifeCount = 11 - PlayerPrefsController.GetDifficulty();
        GetComponent<Text>().text = lifeCount.ToString();
    }

    public void ModifyLifeCount(int lifeChange)
    {
        lifeCount += lifeChange;
        GetComponent<Text>().text = lifeCount.ToString();
        if (lifeCount <= 0)
        {
            FindObjectOfType<LevelController>().LoseScreen();
        }
    }
}
