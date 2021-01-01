using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{

    // Start is called before the first frame update
    void Update()
    {   
        var timer = FindObjectOfType<Slider>().value;
        var enemyCount = FindObjectsOfType<Attacker>().Length;

        if (enemyCount <= 0 && timer == 1)
        {
            StartCoroutine(NextLevel());
        }
        
    }

    IEnumerator NextLevel()
    {
        yield return new WaitForSeconds(2f);
        FindObjectOfType<SceneLoader>().LoadNextScene();
    }
}
