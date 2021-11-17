using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool isGameOver = false;

    public bool isLoading;

    //UI
    public GameObject canvasUI;

    //퍼즐들 저장
    private GameObject[] puzzles;
    //오브젝트들 저장
    private GameObject[] objects;
    //토크에리어들 저장
    private GameObject[] talkArea;
    //장난감들 저장
    private GameObject[] toy;
    //현재 열린 펫
    public int pet = 1;
    //파츠
    private GameObject[] partsBoxes;
    private bool[] partsActive;
    //캐릭터
    private GameObject player;
    private GameObject[] saveHouse;
    //스킬 장난감
    public GameObject book;
    public GameObject bear;
    public GameObject stack;
    public GameObject magnet;
    public GameObject cube;

    //E키 UI
    public GameObject Ekey;

    //E키 사용하는 모든 것
    public GameObject[] EUse;

    //스킬판 돌아가는것
    public GameObject skillImg;
    //각도
    private float skillRoZ;
    //UI 위해서스킬
    public int skill;
    public bool inter { get; private set; }

    private int parts;

    //장난감
    public bool isFixed { get; set; }

    private int iNum;
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        saveHouse = GameObject.FindGameObjectsWithTag("SaveHouse");

        player = GameObject.Find("Player");
        puzzles = GameObject.FindGameObjectsWithTag("Puzzle");
        objects = GameObject.FindGameObjectsWithTag("Object");
        partsBoxes = GameObject.FindGameObjectsWithTag("Parts");
        talkArea = GameObject.FindGameObjectsWithTag("TalkArea");
        toy = GameObject.FindGameObjectsWithTag("Toy");
        partsActive = new bool[partsBoxes.Length];
    }

    // Start is called before the first frame update
    void Start()
    {
        if (!ManagerManager.instance.Relese)
            SaveGame();

        if (ManagerManager.instance.Relese)
            GameLoad();
        player.transform.position = new Vector3(5, 0, 5);
    }

    // Update is called once per frame
    void Update()
    {
        SetSkillUi();

        Skill1();
        Skill2();
        Skill3();
        Skill4();

        //상호작용 버튼
        inter = Input.GetKeyDown("e");

        Ekey.SetActive(false);

        for (int i = 0; i < EUse.Length; i++)
        {
            if(EUse[i].activeSelf)
                if (Vector3.Distance(player.transform.position, EUse[i].transform.position) <= 0.5)
                    Ekey.SetActive(true);
        }

        Talking();


    }

    private void SetSkillUi()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SoundManager.instance.RulletSound();
            skill = 1;
            skillRoZ = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (pet >= 1)
            {
                SoundManager.instance.RulletSound();
                skill = 2;
                skillRoZ = 180;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (pet >= 2)
            {
                SoundManager.instance.RulletSound();
                skill = 3;
                skillRoZ = 270;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            if (pet >= 3)
            {
                SoundManager.instance.RulletSound();
                skill = 4;
                skillRoZ = 90;
            }
        }
        if ((skillImg.transform.eulerAngles.z < skillRoZ + 0.5) && (skillImg.transform.eulerAngles.z > skillRoZ - 0.5))
            return;
        skillImg.transform.Rotate(new Vector3(0, 0, 10f));
       


    }

    //스킬1
    private void Skill1()
    {
        //스킬 1이 아니면 리턴
        if (skill != 1)
        {
            bear.SetActive(false);
            return;
        }

        //곰돌이 활성화
        bear.SetActive(true);

    }
    private void Skill3()
    {
        //스킬 2이 아니면 리턴
        if (skill != 3)
        {
            stack.SetActive(false);
            return;
        }

        //활성화
        stack.SetActive(true);

    }
    private void Skill2()
    {
        //스킬 3이 아니면 리턴
        if (skill != 2)
        {
            magnet.SetActive(false);
            return;
        }

        //활성화
        magnet.SetActive(true);

    }

    private void Skill4()
    {
        //스킬 4이 아니면 리턴
        if (skill != 4)
        {
            cube.SetActive(false);
            return;
        }

        //활성화
        cube.SetActive(true);

    }

    //부품 획득
    public void GetPart()
    {
        parts++;
    }
    //부품 몇 개인지 확인
    public int SeePart()
    {
        return parts;
    }
    public void MinusPart()
    {
        parts--;
    }

    //고친 장난감 수 더하기
    public void CountFix()
    {
        ManagerManager.instance.CountFixedToy++;
    }

    public void SaveGame()
    {
        PlayerPrefsX.SetVector3("player", player.transform.position);
        for (int i = 0; i < objects.Length; i++)
            objects[i].GetComponent<CsObject>().SaveObject(i);
        PlayerPrefs.SetInt("parts", parts);
        // 파츠 활성화된 상태인지 비활성화된 상태인지도 조사해서
        for (int i = 0; i<partsBoxes.Length; i++)
            partsActive[i] = partsBoxes[i].activeSelf;
        PlayerPrefsX.SetBoolArray("Boxes", partsActive);

        // 텍스트 에리아
        for (int i = 0; i < talkArea.Length; i++)
            talkArea[i].GetComponent<CsTalkArea>().SaveTalkArea(i);

        // 장난감은 3단계로 이루어짐. 구분하는 것은 toy.액티브와 fix bool
        for (int i = 0; i < toy.Length; i++)
            toy[i].GetComponent<CsBrokenToy>().SaveToy(i);

        for (int i = 0; i < puzzles.Length; i++)
            puzzles[i].GetComponent<CsPuzzle>().SavePuzzle(i);

        Debug.Log("저장되었습니다");

        //저장하기
        PlayerPrefs.Save();

        for(int i = 0; i<saveHouse.Length; i++)
        {
            if (Vector3.Distance(player.transform.position, saveHouse[i].transform.position) < 0.5)
            {
                TalkManager.instance.Talk(900);
                iNum = 900;
            }

        }

    }

    public void GameOver()
    {
        isGameOver = true;
        GameLoad();
        isGameOver = false;
    }

    public void GameLoad()
    {
        canvasUI.SetActive(false);

        player.transform.position = PlayerPrefsX.GetVector3("player");
        for (int i = 0; i < objects.Length; i++)
            objects[i].GetComponent<CsObject>().LoadObject(i);
        parts = PlayerPrefs.GetInt("parts");

        for (int i = 0; i < partsBoxes.Length; i++)
            partsBoxes[i].SetActive(partsActive[i]);
        partsActive = PlayerPrefsX.GetBoolArray("Boxes");
        // 대화
        for (int i = 0; i < talkArea.Length; i++)
            talkArea[i].GetComponent<CsTalkArea>().LoadTalkArea(i);
        for (int i = 0; i < toy.Length; i++)
            toy[i].GetComponent<CsBrokenToy>().LoadToy(i);

        for (int i = 0; i < puzzles.Length; i++)
            puzzles[i].GetComponent<CsPuzzle>().LoadPuzzle(i);

        for (int i = 0; i < saveHouse.Length; i++)
        {
            if (Vector3.Distance(player.transform.position, saveHouse[i].transform.position) < 0.5)
            {
                TalkManager.instance.Talk(901);
                iNum = 901;
            }

        }


        PlayerPrefs.Save();

        


        Debug.Log("불러왔습니다");

    }

    private void Talking()
    {
        for (int i = 0; i < saveHouse.Length; i++)
            if (saveHouse[i] == null)
                return;
        for (int i = 0; i < saveHouse.Length; i++)
        {
            if ((Vector3.Distance(player.transform.position, saveHouse[i].transform.position) < 0.5))
            {
                if (!TalkManager.instance.isTalking)
                    return;

                if (Input.GetKeyDown(KeyCode.Space))
                {
                    TalkManager.instance.Talk(iNum);
                }
            }
        }


    }
}