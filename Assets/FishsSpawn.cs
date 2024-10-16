using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishsSpawn : MonoBehaviour
{

    public GameObject[] fishs;
    public bool movingLeft;
    public int fishIndex;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.childCount == 0)
        {

            fishIndex = Random.Range(0, 5);
            Instantiate(fishs[fishIndex], transform);
            
        }       
    }
}
