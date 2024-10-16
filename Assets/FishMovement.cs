using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMovement : MonoBehaviour
{

    public bool moveLeft;
    public int minPos = -13;
    public int maxPos = 13;
    public float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(0f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= 1f * Time.deltaTime;
        if(timer <= 0f)
        {
            if (!moveLeft)
            {
                transform.position = transform.position + new Vector3(2f * 1f * Time.deltaTime, 0, 0);
            }
            if (moveLeft)
            {
                transform.position = transform.position + new Vector3(-2f * 1f * Time.deltaTime, 0, 0);
            }

            if (transform.position.x >= maxPos || transform.position.x <= minPos)
            {
                Destroy(gameObject);
                timer = Random.Range(0f, 5f);
            }

        }
    }
}
