using UnityEngine;

public class BeastGenerator : MonoBehaviour
{

    public GameObject Beastprefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnBeast", 0, 5);
    }

    void SpawnBeast()
    {
        float x = Random.Range(-100, 100);
      //  Instantiate(new Vector3(x,0,0), Quaternion.identity);

        Vector3 spawnPosition = new Vector3(x, 0, 0);
        Instantiate(Beastprefab, spawnPosition, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
