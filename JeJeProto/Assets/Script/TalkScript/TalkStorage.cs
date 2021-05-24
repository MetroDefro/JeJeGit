using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkStorage : MonoBehaviour
{
    Dictionary<int, string[]> talkData;

    void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        GenerateData();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerateData()
    {
        // 저장시
        talkData.Add(900, new string[] {
            "제제", "기본", "얘들아 우리 잠시 쉬고 가자"
        });
        // 로드시
        talkData.Add(901, new string[] {
            "즐리", "기본", "제제야 다시 출발해볼까?",
            "즐리", "기본", "제제야 다시 출발해볼까?"
        });


        // 1스테이지 대화 스크립트
        // 시작
        talkData.Add(500, new string[] {
            "제제", "기본", "즐리야 너말고 다른 친구들은 어디있어?",
            "즐리", "기본", "내가 친구들은 먼저 보냈어 장난감 왕국으로 향하다 보면 만날 수 있을거야",
            "제제", "기본", "그렇다면 다른 친구들도 만나러 가자!"
        });

        // 자석 만남
        talkData.Add(501, new string[] {
            "제제", "놀람", "혹시 너 마그넷이니?",
            "마그넷", "놀람", "어?? 제제야 어떻게 여기있는거야?? 혹시 즐리가 데리고 온거야?",
            "제제", "슬픔", "맞아 즐리가 같이 장난감 왕국에 가자고 했어",
            "마그넷", "기본", "즐리야 어쩌다가 제제도 오게 된거야 우리 오늘 조용히 다녀오자고 했는데…",
            "즐리", "슬픔", "미안해… 제제방에서 나올려다가 들켜버렸지 뭐야 그래서 같이 가자고 한거야",
            "마그넷", "기쁨", "어쩔 수 없지 우리 다같이 가자 바로 앞에는 블럭도 있을거야 방금까지 나랑 같이 있었거든"
        });

        // 블럭 만남
        talkData.Add(502, new string[] {
            "블럭", "놀람", "어…? 제제가 여기에??",
            "마그넷", "기본", "지금 너가 생각하고 있는게 맞아 즐리가 들켜서 같이 온거야",
            "즐리", "슬픔", "미안해 애들아 들켜버렸어...",
            "블럭", "기본", "뭐 어쩔 수 없지 그래도 들킨게 제제라서 다행이야",
            "제제", "기본", "그러면 블럭아 같이 장난감 왕국 갈래?",
            "블럭", "기쁨", "좋아 같이하자!"
        });

        // 큐브 만남
        talkData.Add(503, new string[] {
            "즐리", "기본", "제제야 저기 앞에 마지막 친구...",
            "제제", "기쁨", "큐브! 맞지!",
            "즐리", "기쁨", "맞아 큐브야",
            "제제", "기쁨", "큐브야 안녕!",
            "큐브", "놀람", "제제가? 여기에?",
            "마그넷, 블럭", "기본", "그 반응도 우리가 이미 다했어",
            "큐브", "기본", "앗… 그렇다면 나도 같이 가도 될까?",
            "제제", "기쁨", "당연하지! 같이가자"
        });

        // 인형 재료 습득
        talkData.Add(504, new string[] {
            "인형을 고칠 수 있는 재료를 얻었다."
        });

        // 1스테이지 UI 스크립트
        talkData.Add(0, new string[] {
            "Shift키를 누르면 달릴 수 있고 Space 바를 누르면 점프를 할 수 있어."
        });

        talkData.Add(1, new string[] {
            "블록 부수기 스킬은 키보드 1번을 누른 뒤 부술 수 있는 블록에 마우스 왼쪽 클릭으로 부술 수 있어."
        });

        talkData.Add(2, new string[] {
            "자석 스킬은 키보드 2번을 누르고 스킬 사용 가능한 블록에 마우스 왼쪽 클릭으로는 당기고 마우스 오른쪽 클릭은 밀 수 있어."
        });

        talkData.Add(3, new string[] {
            "쌓기 스킬은 키보드 3번을 누른 뒤 원하는 장소에 마우스 왼쪽 클릭을 하면 스킬을 사용할 수 있어"
        });

        talkData.Add(4, new string[] {
            "잘 보이지 않는 블럭도 있으니 잘 확인하여 넘어가도록 하자"
        });

        talkData.Add(5, new string[] {
            "앞에 있는 발판에 올라가면 사라지는 블록이 있을거야"
        });

        talkData.Add(6, new string[] {
            "앞에 있는 발판에 올라간다면 움직이는 블록이 있을거야"
        });

        talkData.Add(7, new string[] {
            "회전 스킬은 4번을 누른 뒤 스킬사용이 가능한 블록에 마우스 왼쪽 클릭을 이용하여 사용할 수 있어"
        });

        talkData.Add(8, new string[] {
            "앞에 있는 버섯에서 인형을 고칠 수 있는 재료를 얻을 수 있어"
        });

        // 1스테이지 끝

        // 인형과 대화 스크립트

        // 찢어진 인형
        // 고치기 전
        talkData.Add(1000, new string[] {
            "찢어진 인형", "고장", "흑흑흑 도와주세요.",
            "제제", "슬픔", "너무 심하게 망가졌잖아 어쩌다가 이렇게 된거니?",
            "찢어진 인형", "고장", "낮에 아이들이 저를 험하게 가지고 놀다가 찢어지니깐 버렸어요.",
            "제제", "슬픔", "그동안 많이 힘들었겠다. 내가 재료를 가지고 있으니 재료를 사용해서 고쳐줄게 이리와서 나에게 상처를 보여줘",
            "즐리", "슬픔", "맞아! 제제는 우리가 망가져도 잘 고쳐줬어 걱정하지마 친구야",
        });

        // 도중
        talkData.Add(1001, new string[] {
            "찢어진 인형", "고장", "흑흑흑 아파."
        });

        // 고친 후
        talkData.Add(1002, new string[] {
            "찢어진 인형", "기본", "나를 고쳐줘서 고마워! 내 뒤로 가면 바로 장난감 왕국으로 들어갈 수 있어 지금 내 힘으로 장막을 없애줄께!",
        });
    }

    public string GetTalk(int id, int talkIndex)
    {
        //Debug.Log("id: " + id + " talkIndex: " + talkIndex);
        if (talkIndex == talkData[id].Length)
            return null;
        else
            return talkData[id][talkIndex];
    }
}
