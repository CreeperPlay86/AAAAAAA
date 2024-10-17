using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Hook : MonoBehaviour
{

    public int counter = 0;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Score: " + counter.ToString();

        if (counter >= 10)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fish"))
        {
            Destroy(other.gameObject);
            counter++;
        }
        if (other.CompareTag("Trash"))
        {
            Destroy(other.gameObject);
            counter--;
        }
    }
}
