using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public int sceneNum;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SceneLoad()
    {
        SceneManager.LoadScene(sceneNum);
    }

    public void exitGame()
    {
        Application.Quit();
    }

    public void startTime()
    {
        Time.timeScale = 1f;
    }
}
