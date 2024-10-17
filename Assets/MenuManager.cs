using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void level_1()
    {
        SceneManager.LoadScene("game 1");
    }

    public void level_2()
    {
        SceneManager.LoadScene("game 2");
    }
}
