using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEditor;
using UnityEngine;

public class IcicleSpawner : MonoBehaviour
{
    public float timer = 5f;
    public int spawnerNumber;
    public GameObject icicle;
    public int counter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        timer -= 1 * Time.deltaTime;
        
        if (timer <= 0)
        {
            if (spawnerNumber == 0)
            {
                Instantiate(icicle, new Vector3(-1.5f, 6.25f, 0), Quaternion.identity);
                counter++;
                timer = 5f;
            }
            if(spawnerNumber == 1)
            {
                Instantiate(icicle, new Vector3(0, 6.25f, 0), Quaternion.identity);
                counter++;
                timer = 5f;
            }
            if (spawnerNumber == 2)
            {
                Instantiate(icicle, new Vector3(1.5f, 6.25f, 0), Quaternion.identity);
                counter++;
                timer = 5f;
            }

        }
        spawnerNumber = Random.Range(0, 3);

    }
}
