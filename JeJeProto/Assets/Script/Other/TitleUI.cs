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
        ManagerManager.instance.CountFixedToy = 0;
        ManagerManager.instance.stageNum = 1;
        SceneManager.LoadScene("Intro");
        ManagerManager.instance.Relese = false;
    }

    public void GameRelese()
    {
        if(PlayerPrefs.GetInt("stageNum") == 2)
        {
            SceneManager.LoadScene("Stage2");
            ManagerManager.instance.Relese = true;
        }
        else if (PlayerPrefs.GetInt("stageNum") == 1)
        {
            SceneManager.LoadScene("Stage1");
            ManagerManager.instance.Relese = true;
        }
        else if (PlayerPrefs.GetInt("stageNum") == 0)
        {

        }


    }
}
