using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] bool spawn = true;
    [SerializeField] Attacker[] attackersPrefab;
    [SerializeField] float minDelay = 1f;
    [SerializeField] float maxDelay = 2f;


    public void SetMaxDelay(float delay)
    {
        maxDelay = delay;
    }

    IEnumerator Start()
    {
        maxDelay = maxDelay / PlayerPrefsController.GetDifficulty();
        while (spawn && FindObjectOfType<Slider>().value != 1)
        {
            yield return new WaitForSeconds(Random.Range(minDelay, maxDelay));
            SpawnAttacker();
        }
    }

    private void SpawnAttacker()
    {
        var attackerIndex = Random.Range(0, attackersPrefab.Length);
        Spawn(attackersPrefab[attackerIndex]);
    }

    public void StopSpawning()
    {
        spawn = false;
    }

    private void Spawn(Attacker myAttacker)
    {
        Attacker newAttacker = Instantiate
            (myAttacker, transform.position, transform.rotation) as Attacker;
        newAttacker.transform.parent = transform;
    }
}
