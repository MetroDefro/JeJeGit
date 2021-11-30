using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{


    public GameObject MenuB;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StopB()
    {
        Application.Quit();
    }

    public void ContinueB()
    {
        MenuB.SetActive(false);
    }
}
