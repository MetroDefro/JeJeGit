using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void GameStart()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("Intro");
        ManagerManager.instance.Relese = false;
    }

    public void GameRelese()
    {
        SceneManager.LoadScene("Stage1");
        ManagerManager.instance.Relese = true;
    }
}
