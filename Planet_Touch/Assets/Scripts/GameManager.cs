using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null; 

    private void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
        else if(instance==this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public void LoadEarthLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadMoonLevel()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadJupiterLevel()
    {
        SceneManager.LoadScene(3);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }
}
