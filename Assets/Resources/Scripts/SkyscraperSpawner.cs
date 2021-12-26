using UnityEngine;
using System.Collections;

public class SkyscraperSpawner : MonoBehaviour
{

    public GameObject[] prefabs;

    public static float speed = 10f;
    public float S;
    void Start()
    {


        StartCoroutine(SpawnSkyscrapers());
    }


    IEnumerator SpawnSkyscrapers()
    {
        while (true)
        {
            S = speed;
            Instantiate(prefabs[Random.Range(0, prefabs.Length)], new Vector3(26, Random.Range(-20, -12), 11),
                Quaternion.Euler(-90f, 0f, 0f));

            // randomly increase the speed by 1
            if (Random.Range(1, 4) == 1)
            {
                speed += 1f;
            }

            // wait between 1-5 seconds for a new skyscraper to spawn
            yield return new WaitForSeconds(Random.Range(1, 5));
        }
    }
}
