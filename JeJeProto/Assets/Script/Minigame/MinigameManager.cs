using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinigameManager : MonoBehaviour
{
    public static MinigameManager instance;

    public GameObject Toy;
    public GameObject Parts;

    private GameObject Mini1UI;
    private GameObject Mini2UI;

    private int pointAmount;
    private int endAmount;

    public bool isMini2;

    private Transform buttonFamily;
    private Transform[] buttons;

    private GameObject MG1;
    private GameObject MG2;
    private GameObject MMG1;
    private GameObject MMG2;

    //UI 텍스트
    private Text timerT;
    private Text countT;

    //제한
    public int bNum;
    private int maxC;
    public int rimitC;
    private float rimitT;

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

    }

    public void StartGame(GameObject M1, GameObject M2, int PA, int EA, int MC, int BN, int RT)
    {
        Vector3 pos1 = new Vector3(10, 11, 0);
        Vector3 pos2 = new Vector3(10, 11, 0);
        MG1 = M1;
        MG2 = M2;
        pointAmount = PA;
        endAmount = EA;
        maxC = MC;
        bNum = BN;

        MMG1 = Instantiate(MG1, MG1.transform.position, MG1.transform.rotation);
        MMG2 = Instantiate(MG2, MG2.transform.position, MG2.transform.rotation);

        buttonFamily = GameObject.Find("ButtonFamily").transform;
        buttons = buttonFamily.gameObject.GetComponentsInChildren<Transform>();

        Mini1UI = GameObject.Find("MiniGameUI1");
        Mini2UI = GameObject.Find("MiniGameUI2");
        Mini2UI.SetActive(false);
        Mini1UI.SetActive(true);
        isMini2 = false;

        timerT = GameObject.Find("TimerT").transform.GetComponent<Text>();
        rimitT = RT;
        rimitC = maxC;
    }
    // Update is called once per frame
    void Update()
    {
        if (MMG1 == null)
            return;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CameraManager.instance.MainCameraOn();
            Reset();
        }
        if (isMini2)
        {
            Mini2UI.SetActive(true);
            Mini1UI.SetActive(false);
            countT = GameObject.Find("CountText").transform.GetComponent<Text>(); 
        }
        UpdateUI();
    }

    void UpdateUI()
    {
        if (timerT != null)
        {
            rimitT -= Time.deltaTime;
            timerT.text = "제한시간: " + Mathf.Floor(rimitT).ToString() + "초";
            
            if (rimitT <= 0 && !isMini2)
            {
                CameraManager.instance.MainCameraOn();
                Reset();
            }
            
        }
            
        if (countT != null)
        {
            countT.text = "제한 칸수: " + rimitC + "칸";
            if(rimitC == 0)
            {
                CameraManager.instance.MainCameraOn();
                Reset();
            }
                
        }
            
    }

    private void Reset()
    {
        Destroy(MMG1);
        Destroy(MMG2);
        
    }
    public void MiniGameClear()
    {
        int sum = 0;
        int point = 0;
        int ends = 0;
        for(int i = 1; i < buttons.Length; i++)
        {
            if (buttons[i].gameObject.GetComponent<MinigameLine>().clicked)
            {
                sum++;
                if (buttons[i].gameObject.GetComponent<MinigameLine>().strongButton)
                    point++;
                if (buttons[i].gameObject.GetComponent<MinigameLine>().endButton)
                    ends++;
            }
        }
        // end 다 채웠나?
        if (endAmount != ends)
            return;
        //먼저 목표 수만큼 실이 있는지 확인
        if (maxC == sum)
            if (pointAmount == point)
            {
                SoundManager.instance.MinigameClearSound();
                Toy.GetComponent<CsBrokenToy>().Fixed();
            }
            else
            {
                SoundManager.instance.MinigameFailSound();
                CameraManager.instance.MainCameraOn();
            }             
        else
        {
            SoundManager.instance.MinigameFailSound();
            CameraManager.instance.MainCameraOn();
        }

        Reset();
    }
}
