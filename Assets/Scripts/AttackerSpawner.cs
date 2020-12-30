using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] bool spawn = true;
    [SerializeField] Attacker attackerPrefab;
    [SerializeField] float minDelay = 1f;
    [SerializeField] float maxDelay = 5f;

    // Update is called once per frame
    void Update()
    {
        //StartCoroutine(SpawnEnemies());
    }
    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minDelay, maxDelay));
            SpawnAttacker();
        }
    }

    private void SpawnAttacker()
    {
        Instantiate(attackerPrefab, transform.position, transform.rotation);
    }
}
