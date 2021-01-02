using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    [SerializeField] public int lifeCount = 3;
    
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
