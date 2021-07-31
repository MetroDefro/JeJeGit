using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public static CameraManager instance;
    public Camera mainC;
    public Camera subC;

    public GameObject UI;
    //public GameObject minigameUI;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        mainC.enabled = true;
        subC.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SubCameraOn()
    {
        subC.transform.position = new Vector3(50, 30, 0);
        UI.SetActive(false);
        mainC.enabled = false;
        subC.enabled = true;
    }

    public void MainCameraOn()
    {
        UI.SetActive(true);
        mainC.enabled = true;
        subC.enabled = false;
    }
}
