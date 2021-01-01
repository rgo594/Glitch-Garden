using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    [SerializeField] int lifeCount = 3;
    
    public void ModifyLifeCount(int lifeChange)
    {
        lifeCount += lifeChange;
        GetComponent<Text>().text = lifeCount.ToString();
        if (lifeCount <= 0)
        {
            StartCoroutine(FindObjectOfType<SceneLoader>().LoadGameOver());
        }
    }

/*    IEnumerator LoadGameOver()
    {
        yield return new WaitForSeconds(2f);
        FindObjectOfType<SceneLoader>().LoadGameOver();
    }*/
}
