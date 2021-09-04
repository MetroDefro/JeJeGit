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
    private Transform buttonFamily2;
    private Transform buttonFamily3;
    private Transform buttonFamily4;
    private Transform[] buttons;
    private Transform[] buttons2;
    private Transform[] buttons3;
    private Transform[] buttons4;

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

    public GameObject ClearIMG;
    public GameObject FailIMG;

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

    public void StartGame(GameObject M1, GameObject M2, int PA, int EA, int MC, int BN, int RT, GameObject toy)
    {
        Vector3 pos1 = new Vector3(50, 11, 0);
        Vector3 pos2 = new Vector3(70, 11, 0);
        MG1 = M1;
        MG2 = M2;
        pointAmount = PA;
        endAmount = EA;
        maxC = MC;
        bNum = BN;

        MMG1 = Instantiate(MG1, pos1, MG1.transform.rotation);
        MMG2 = Instantiate(MG2, pos2, MG2.transform.rotation);

        buttonFamily = GameObject.Find("ButtonFamily").transform;
        buttons = buttonFamily.gameObject.GetComponentsInChildren<Transform>();
        if(GameObject.Find("ButtonFamily (1)") != null)
        {
            buttonFamily2 = GameObject.Find("ButtonFamily (1)").transform;
            buttons2 = buttonFamily2.gameObject.GetComponentsInChildren<Transform>();
        }
        if (GameObject.Find("ButtonFamily (2)") != null)
        {
            buttonFamily3 = GameObject.Find("ButtonFamily (2)").transform;
            buttons3 = buttonFamily3.gameObject.GetComponentsInChildren<Transform>();
        }
        if (GameObject.Find("ButtonFamily (3)") != null)
        {
            buttonFamily4 = GameObject.Find("ButtonFamily (3)").transform;
            buttons4 = buttonFamily4.gameObject.GetComponentsInChildren<Transform>();
        }

        Mini1UI = GameObject.Find("MiniGameUI1");
        Mini2UI = GameObject.Find("MiniGameUI2");
        Mini2UI.SetActive(false);
        Mini1UI.SetActive(true);
        isMini2 = false;

        timerT = GameObject.Find("TimerT").transform.GetComponent<Text>();
        rimitT = RT;
        rimitC = maxC;
        Toy = toy;
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
                //게임오버
                StartCoroutine(Clear(false));
            }
            
        }
            
        if (countT != null)
        {
            countT.text = "제한 칸수: " + rimitC + "칸";
            if(rimitC == -1)
            {
                //게임오버
                StartCoroutine(Clear(false));
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
        if(buttons2 != null)
        {
            for (int i = 1; i < buttons2.Length; i++)
            {
                if (buttons2[i].gameObject.GetComponent<MinigameLine>().clicked)
                {
                    sum++;
                    if (buttons2[i].gameObject.GetComponent<MinigameLine>().strongButton)
                        point++;
                    if (buttons2[i].gameObject.GetComponent<MinigameLine>().endButton)
                        ends++;
                }
            }
        }
        if (buttons3 != null)
        {
            for (int i = 1; i < buttons3.Length; i++)
            {
                if (buttons3[i].gameObject.GetComponent<MinigameLine>().clicked)
                {
                    sum++;
                    if (buttons3[i].gameObject.GetComponent<MinigameLine>().strongButton)
                        point++;
                    if (buttons3[i].gameObject.GetComponent<MinigameLine>().endButton)
                        ends++;
                }
            }
        }
        if (buttons4 != null)
        {
            for (int i = 1; i < buttons2.Length; i++)
            {
                if (buttons4[i].gameObject.GetComponent<MinigameLine>().clicked)
                {
                    sum++;
                    if (buttons4[i].gameObject.GetComponent<MinigameLine>().strongButton)
                        point++;
                    if (buttons4[i].gameObject.GetComponent<MinigameLine>().endButton)
                        ends++;
                }
            }
        }
        // end 다 채웠나?
        if (endAmount != ends)
            return;
        //먼저 목표 수만큼 실이 있는지 확인
        if (maxC == sum)
            if (pointAmount == point)
            {
                //클리어
                StartCoroutine(Clear(true));
            }
            else
            {
                //게임오버
                StartCoroutine(Clear(false));
            }             
        else
        {
            //게임오버
            StartCoroutine(Clear(false));
        }
    }

    IEnumerator Clear(bool isClear)
    {
        Vector3 pos = new Vector3(CameraManager.instance.subC.transform.position.x, 25, 0);
        Transform Par = GameObject.Find("Parent").transform;
        if (isClear)
        {
            SoundManager.instance.MinigameClearSound();
            Instantiate(ClearIMG, pos, ClearIMG.transform.rotation).transform.parent = Par;
            yield return new WaitForSeconds(2f);
            Reset();
            Toy.GetComponent<CsBrokenToy>().Fixed();
        }
        else
        {
            SoundManager.instance.MinigameFailSound();
            Instantiate(FailIMG, pos, FailIMG.transform.rotation).transform.parent = Par;
            yield return new WaitForSeconds(2f);
            Reset();
            CameraManager.instance.MainCameraOn();
        }
    }
}
