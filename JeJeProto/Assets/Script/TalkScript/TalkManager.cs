using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkManager : MonoBehaviour
{
    public static TalkManager instance;

    // 대화
    public TalkStorage talkStorage;
    public int talkIndex;
    public GameObject talkPanel;
    public GameObject MinitalkPanel;
    public bool isTalking;

    public Text talkText;
    public Text nameText;
    public Text miniText;

    // UI 제거
    public GameObject canvasUI;

    // 스프라이트
    public GameObject[] sprites;

    // 번호
    private int n;

    // 0.즐리 1.블럭 2.마그넷 3.큐브 4.사람인형

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
        n = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //대화 스크립트
    public bool Talk(int id)
    {
        // 네임데이터 저장소에서 얻어옴
        string nameData = talkStorage.GetTalk(id, talkIndex);
        // 네임 데이트에 아무것도 안왔다면
        if (nameData == null)
        {
            // 인덱스 초기화
            talkIndex = 0;

            // 텍스트 비워 놓음
            nameText.text = null;
            talkText.text = null;
            // 판넬 제거
            talkPanel.SetActive(false);

            // 제제 스프라이트 끔
            sprites[0].SetActive(false);
            // 상대 스프라이트 끔
            for (int i = 0; i < sprites.Length; i++)
                sprites[i].SetActive(false);

            // UI 다시 키기
            canvasUI.SetActive(true);
            // 0.1초 후에 isTalking 꺼지도록
            StartCoroutine(WaitForIt());
            return false;
        }
        isTalking = true;
        // 제제 스프라이트 키고 UI 제거
        sprites[0].SetActive(true);
        canvasUI.SetActive(false);
        // 네임을 설정
        nameText.text = nameData;

        // 네임데이터가 제제가 아닌 경우 일단 대화 상대 스프라이트를 끈다
        if(nameData != "제제")
        {
            for (int i = 1; i < sprites.Length; i++)
                sprites[i].SetActive(false);
        }
        // 네임데이터에 따라 대화 상대 스프라이트 켬
        if (nameData == "제제")
            n = 0;
        else if (nameData == "즐리")
            n = 1;
        else if (nameData == "블럭")
            n = 2;
        else if (nameData == "마그넷")
            n = 3;
        else if (nameData == "큐브")
            n = 4;
        else if (nameData == "찢어진 인형")
            n = 5;
        sprites[n].SetActive(true);

        talkIndex++;
        // 표정데이터 저장소에서 얻어옴
        string expressionData = talkStorage.GetTalk(id, talkIndex);

        if (expressionData == "기본")
            sprites[n].GetComponent<Image>().sprite = sprites[n].GetComponent<CsSprite>().standing;
        else if (expressionData == "슬픔")
            sprites[n].GetComponent<Image>().sprite = sprites[n].GetComponent<CsSprite>().sad;
        else if (expressionData == "기쁨")
            sprites[n].GetComponent<Image>().sprite = sprites[n].GetComponent<CsSprite>().happy;
        else if (expressionData == "놀람")
            sprites[n].GetComponent<Image>().sprite = sprites[n].GetComponent<CsSprite>().surprise;
        else if (expressionData == "고장")
            sprites[n].GetComponent<Image>().sprite = sprites[n].GetComponent<CsSprite>().beforeFix;

        talkIndex++;

        // 토크데이터 저장소에서 얻어옴
        string talkData = talkStorage.GetTalk(id, talkIndex);

        // 토크텍스트 설정
        talkText.text = talkData;

        talkIndex++;
        talkPanel.SetActive(true);
        SoundManager.instance.TalkSound();
        return true;
    }

    //미니창
    public void SmallTalk(int id)
    {
        string talkData = talkStorage.GetTalk2(id);

        miniText.text = talkData;

        MinitalkPanel.SetActive(true);
        
        return;
    }

    public void Exitarea()
    {
        miniText.text = null;
        MinitalkPanel.SetActive(false);

        return;
    }

    IEnumerator WaitForIt()
    {
        yield return new WaitForSeconds(0.1f);
        isTalking = false;
    }
}
