using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    public Vector3 spawnRange;
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnRange.x, spawnRange.x), 0f,
                Random.Range(-spawnRange.z, spawnRange.z));
            Instantiate<GameObject>(prefab, spawnPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
