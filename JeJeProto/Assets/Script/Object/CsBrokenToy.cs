using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsBrokenToy : MonoBehaviour
{
    private GameObject player;
    public GameObject toy;

    private Animator animator;

    public int id;
    public int nowId;

    private bool fix;

    public GameObject MG1;
    public GameObject MG2;
    public int maxC;
    public int Bnum;
    public int pointAmount;
    public int endAmound;
    public int RimitT;

    //고친 장난감 이미지
    //public GameObject fixedToy;

    public int[] parts = { 0, 0, 0, 0, 0, 0 };

    // 파티클
    public GameObject Magic;
    public GameObject MagicT;

    void Awake()
    {
        player = GameObject.Find("Player");
        animator = GetComponent<Animator>();
        nowId = id;
        fix = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.inter)
            Inter();
        Talking();
        /*
        if (!TalkManager.instance.isTalking && nowId == id+2)
            Destroy(gameObject);
        */
    }


    //상호작용
    private void Inter()
    {
        if (Vector3.Distance(player.transform.position, transform.position) > 0.5)
            return;

        if (TalkManager.instance.isTalking)
            return;

        //Debug.Log("인터렉션");
        //일단 도감에 들어감, 미션 생김
        if (toy.activeSelf == false)
        {
            toy.SetActive(true);
            // 처음 상호작용하면 일어날 이벤트 진행.
            FirstInter();
        }
        else
        {
            //통상적인 상호작용 이벤트
            //Fix() 소환해서 먼저 고칠 수 있는지 확인
            IsCanFix();
        }

        if (fix)
        {
            TalkManager.instance.Talk(nowId);
            return;
        }


    }

    private void FirstInter()
    {
        // 처음 상호작용하면 일어날 이벤트 작성.
        animator.SetBool("Connect", true);
        TalkManager.instance.Talk(nowId);
    }

    private void IsCanFix()
    {
        //고칠 수 있는지 확인부터
        //못고쳤다면 리턴
        for(int i = 0; i<parts.Length; i++)
        {
            if (GameManager.instance.SeePart(i) < parts[i])
                return;
        }

        MinigameManager.instance.Toy = this.gameObject;
        CameraManager.instance.SubCameraOn();
        MinigameManager.instance.StartGame(MG1, MG2, pointAmount, endAmound, maxC, Bnum, RimitT);

    }

    public void Fixed()
    {
        CameraManager.instance.MainCameraOn();
        //고쳐지면 나올 파티클
        GameObject effect = Instantiate(Magic, MagicT.transform.position, transform.rotation);
        Destroy(effect, 3f);

        //도감 이미지 변경
        //fixedToy.SetActive(true);

        //고쳐지면 나올 이벤트
        nowId = id + 2;
        TalkManager.instance.Talk(nowId);

        for (int i = 0; i < parts.Length; i++)
        {
            GameManager.instance.MinusPart(i, parts[i]);
        }

        animator.SetBool("Fix", true);
        GameManager.instance.token += 30;

        GameManager.instance.isFixed = true;

        fix = true;


    }

    private void Talking()
    {
        if (Vector3.Distance(player.transform.position, transform.position) > 0.5)
            return;
        if (!TalkManager.instance.isTalking)
            return;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            TalkManager.instance.Talk(nowId);
        }          
    }

    // 장난감은 3단계로 이루어짐. 구분하는 것은 toy.액티브와 fix bool임.

    public void SaveToy(int i)
    {
        PlayerPrefsX.SetBool("toyActive" + i, toy.activeSelf);  
        PlayerPrefsX.SetBool("fix" + i, fix);
    }

    public void LoadToy(int i)
    {
        toy.SetActive(PlayerPrefsX.GetBool("toyActive" + i));
        fix = PlayerPrefsX.GetBool("fix" + i);
        animator.SetBool("Connect", toy.activeSelf);
        animator.SetBool("Fix", fix);
    }
}
