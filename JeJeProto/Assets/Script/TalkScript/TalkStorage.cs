﻿using System.Collections;
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
            "제제", "기본", "지금까지 여행을 저장했어!"
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
            "즐리", "기본", "내가 다른 친구들은 먼저 보냈어 장난감 왕국으로 향하다 보면 만날 수 있을거야",
            "제제", "기본", "그렇다면 빨리 가서 다른 친구들도 만나서 같이 가자!"
        });

        // 자석 만남
        talkData.Add(501, new string[] {
            "제제", "놀람", "혹시 너 마그넷이니?",
            "마그넷", "놀람", "어...? 제제가 여기에? 지금 새벽인데?! 설마… 즐리야 너가 제제한테 들켜서 같이 가자고 한거야?",
            "즐리", "슬픔", "미안해... 제제한테 들켜서 같이 장난감 왕국에 가자고 했어...",
            "마그넷", "기본", "그래도 우리 친구인 제제한테 들켜서 그나마 다행이야 뭐 이렇게 된거 제제도 같이 장난감 왕국에 가자.",
            "제제", "기쁨", "정말 같이 가도 되는거야?! 마그넷도 같이 가자고해서 정말 기뻐!",
            "마그넷", "기쁨", "계획이 틀어졌지만 그래도 이 기회에 제제랑 같이 여행을 떠날 수 있어서 나도 기뻐 우리 빨리 가자 바로 앞에는 블럭도 있을거야 방금까지 나랑 같이 있었거든."
        });

        // 블럭 만남
        talkData.Add(502, new string[] {
            "블럭", "놀람", "오잉?! 제제가 여기에?? 내가 잠깐 사이에 제제를 그리워해서 헛것이 보이는건가?",
            "마그넷", "기본", "그건 헛것을 보는게 아니고 진짜 제제가 맞아 즐리가 제제한테 들켜서 같이 오게 되었어.",
            "즐리", "슬픔", "미안해 블럭아 제제 방에서 나오다가 들켜버렸어...",
            "블럭", "기본", "뭐 어쩔 수 없지! 이렇게 된이상 제제랑 재밌게 장난감 왕국으로 놀러가면 되는거지!",
            "제제", "기본", "그러면 블럭아 같이 장난감 왕국 가도 되는거야?",
            "블럭", "기쁨", "물론이지 제제랑 같이 여행을 갈 수 있어서 너무 기뻐!",
            "블럭", "기본", "그런데 1층에 있는 큐브는 어떻게 생각할지는 잘 모르겠네… 그래도 가보자!",
            "제제", "기쁨", "그래! 서둘러서 큐브에게 가자!"
        });

        // 큐브 만남
        talkData.Add(503, new string[] {
            "즐리", "기본", "제제야 저기 앞에 큐브가 있는거 같아… 큐브는 계획이 틀어지는걸 굉장히 싫어하는데...",
            "제제", "기본", "정말? 나는 너희랑 처음 이야기해보는거라 큐브가 계획이 틀어지는걸 싫어하는지 몰랐어… 그래도 이런걸 알게되서 기쁜걸?",
            "즐리", "슬픔", "그렇지 평소에 같이 놀긴 했지만 대화를 한적은 이번이 처음이니까.",
            "큐브", "놀람", "뭐야 내가 잘못본건가? 제제가 여기에 있는거야?",
            "즐리", "슬픔", "미안해 큐브야 내 실수로 제제에게 들켜서 같이 오게 되었어...",
            "큐브", "기본", "계획이랑 달라서 조금 짜증이나지만 그래도 제제한테 들킨거니까 봐줄게 다 같이 장난감 왕국으로",
            "마그넷, 블럭", "기쁨", "큐브까지 같이 장난감 왕국으로 가자고하다니 진짜 즐거운 여행이 될 것 같아!",
            "큐브", "기본", "그런데 저기 건너편에 우는 소리가 들리던데 가다가 울음소리의 주인을 만나면 무슨일이 있는지 물어보자.",
            "제제", "놀람", "혹시 유령은 아니겠지? 나 갑자기 너무 무서워졌어.",
            "즐리", "기본", "괜찮아 제제야 우리가 꼭 지켜줄게"
        });

        // 2스테이지 대화 스크립트
        talkData.Add(504, new string[] {
            "블럭", "기쁨", "와! 드디어 장난감 왕국에 들어왔다!",
            "큐브", "기본", "그런데 평소와 다른곳으로 떨어진거 같은데?",
            "제제", "놀람", "여기가 장난감 왕국이야?",
            "즐리", "슬픔", "장난감 왕국은 맞는거 같은데 나도 여기는 처음 보는거 같아.",
            "제제", "기본", "장난감 성과 엄청 먼곳은 아니겠지?",
            "즐리", "기본", "저기 앞에 여기서 사는 주민이 있나봐 주민에게 가서 물어보자.",
            "제제", "기쁨", "처음으로 만나는 장난감 왕국에 사는 주민이라니 빨리 가보자!",
            "제제", "기쁨", "안녕하세요!",
            "몽몽이", "슬픔", "뭐야 사람이잖아? 빨리 마을에서 여기서 나가!",
            "제제", "놀람", "어…? 내가 뭐 잘못한건가?",
            "즐리", "놀람", "아니야 이마을 무언가 반응이 이상해...",
            "마그넷", "기본", "뭐야 왜 처음 보는 사람한테 저렇게 화내는거야! 예의가 없네 그냥 장난감 성으로 가버리자!",
            "큐브", "기본", "맞아 우리의 목적은 장난감 왕을 만나러 가는거잖아? 저기 선착장이 있는데 배타고 가면 될 것 같아.",
            "제제", "슬픔", "그런데 여기에 있는 인형들 보니 나는 왠지 도와줘야할 것 같은 기분이야.",
            "블럭", "놀람", "그러게 여기 마을에 있는 장난감들 모습을 봐 다들 다친 상태야.",
            "즐리", "슬픔", "마그넷과 큐브는 그냥 가자고하고 제제와 블럭은 도와주고 싶다는 것 같은데  나는 저 친구들 도와줘야한다고 생각해",
            "큐브", "기본", "그러면 나는 제제의 선택에 따르겠어.",
            "마그넷", "기본", "나도 같은 생각이야.",
            "즐리", "기본", "그러면 제제에게 어떻게 할건지 맡기고 우리는 제제를 따라가자!"
        });

        talkData.Add(505, new string[] {
            "제제", "기쁨", "안녕하세요!",
            "몽몽이", "슬픔", "뭐야 사람이잖아? 빨리 마을에서 여기서 나가!",
            "제제", "놀람", "어…? 내가 뭐 잘못한건가?",
            "즐리", "놀람", "아니야 이마을 무언가 반응이 이상해...",
            "마그넷", "기본", "뭐야 왜 처음 보는 사람한테 저렇게 화내는거야! 예의가 없네 그냥 장난감 성으로 가버리자!",
            "큐브", "기본", "맞아 우리의 목적은 장난감 왕을 만나러 가는거잖아? 저기 선착장이 있는데 배타고 가면 될 것 같아.",
            "제제", "슬픔", "그런데 여기에 있는 인형들 보니 나는 왠지 도와줘야할 것 같은 기분이야.",
            "블럭", "놀람", "그러게 여기 마을에 있는 장난감들 모습을 봐 다들 다친 상태야.",
            "즐리", "슬픔", "마그넷과 큐브는 그냥 가자고하고 제제와 블럭은 도와주고 싶다는 것 같은데  나는 저 친구들 도와줘야한다고 생각해",
            "큐브", "기본", "그러면 나는 제제의 선택에 따르겠어.",
            "마그넷", "기본", "나도 같은 생각이야.",
            "즐리", "기본", "그러면 제제에게 어떻게 할건지 맡기고 우리는 제제를 따라가자!"
        });

        talkData.Add(506, new string[] {
            "제제", "기본", "여기는 어디로 가는 길이지?",
            "즐리", "기본", "여기는 장난감 성으로 가는 배가 있는 선착장 가는 길이야 선착장으로 갈래?"
        });

        talkData.Add(507, new string[] {
            "제제", "기본", "여기는 어디로 가는 길이야?",
            "즐리", "기본", "이쪽 길로 가면 장난감을 고칠 수 있는 재료를 얻으러 갈 수 있어 재료를 얻으러 갈래?"
        });

        talkData.Add(508, new string[] {
            "제제", "기본", "마을에서 빠져 나오니까 바로 나무가 많이 보이네?",
            "즐리", "기본", "그러네? 이마을은 숲 속 가운데에 있는거 같네 그러니 우리도 처음 보는 마을이였던것 같아.",
            "블럭", "기쁨", "그래도 처음 보는 마을이여서 오히려 새로운 경험이 생기겠는걸?",
            "큐브", "기본", "혹시 몰라서 다른 주민들에게 재료가 어디에 있는지 물어보고 왔어 가까이 재료가 있으면 우리가 알려줄게.",
            "마그넷", "기쁨", "이럴 땐 큐브가 정말 든든한 것 같아 제제가 인형들을 고쳐주기 위해 결심한 거니까 우리도 제제를 열심히 도와줄게!",
            "제제", "기쁨", "얘들아 내 생각을 따라와줘서 정말 고마워 자 이제 가보자!"
        });

        talkData.Add(509, new string[] {
            "제제", "기쁨", "드디어 빠져나왔네 저기에 재료가 있어!",
            "즐리", "기쁨", "그렇네! 큐브가 다른 인형들에게 들었던게 맞구나!",
            "즐리", "기본", "또 다른 재료도 가다보면 있다고 했으니 계속 가보자.",
            "제제", "기본", "그래! 계속 출발!"
        });

        talkData.Add(510, new string[] {
            "제제", "기쁨", "와! 여기에도 호수가 있구나! 엄청 크다~",
            "즐리", "기본", "그러게? 여기는 엄청 크다~",
            "블럭", "기쁨", "제제야 내가 엄청 재미있는 사실을 알려줄까?",
            "제제", "기본", "재미있는 사실이란게 뭐야?",
            "블럭", "기쁨", "바로 물 속에서도 숨을 쉴 수 있다는거지!",
            "제제", "놀람", "진짜?!  한번 들어가볼까?",
            "블럭", "기쁨", "분명 신기한 경험이 될거라고 생각해!",
            "블럭", "기쁨", "분명 신기한 경험이 될거라고 생각해!",
            "큐브", "기본", "물에 들어가기 싫다면 내가 다리를 만들어 줄게 저기 가운데에 재료가 있다고 들었어.",
            "제제", "기쁨", "그래? 그러면 다시 재료를 얻으러 가보자!"
        });

        talkData.Add(511, new string[] {
            "마그넷", "기본", "우리 재료는 다 모은거 같지?",
            "제제", "기쁨", "이정도면 다친 장난감들을 많이 고쳐줄 수 있을 것 같아!",
            "블럭", "기쁨", "그러면 이제 장난감 친구들 고쳐주러 가자!",
            "큐브", "기본", "그래 빨리 고쳐주고 우리도 장난감 왕을 만나러 가야지",
            "제제", "놀람", "아 맞다! 재료를 찾다보닌깐 우리가 장난감 왕을 만나러 간다는거 까먹고 있었어.",
            "즐리", "기쁨", "그래도 다 같이 힘을 합쳐서 재료 모으는거 재미있었지?",
            "제제", "기쁨", "너무 즐거웠어! 장난감 친구들 고쳐주고 빨리 장난감 왕을 만나러 가야겠다!"
        });

        // 인형 재료 습득
        talkData.Add(600, new string[] {
            "인형을 고칠 수 있는 재료를 얻었다."
        });

        // 1스테이지 UI 스크립트
        talkData.Add(0, new string[] {
            "키보드 w,a,s,d로 움직일 수 있고 마우스 오른쪽 클릭 후 움직이면 카메라를 움직일 수 있어."
        });

        talkData.Add(1, new string[] {
            "Shift키를 누르면 달릴 수 있고 Space 바를 누르면 점프를 할 수 있어 그리고 E키로 대화를 하거나 아이템을 얻을 수 있어"
        });

        talkData.Add(2, new string[] {
            "블록을 부수기 위해선 키보드 1번을 누른 뒤 부술 수 있는 블록에 마우스 왼쪽 클릭하면 부술 수 있어."
        });

        talkData.Add(3, new string[] {
            "자석 스킬은 키보드 2번을 누르고 스킬 사용 가능한 블록에 마우스 왼쪽 클릭으로는 당기고 마우스 오른쪽 클릭은 밀 수 있어."
        });

        talkData.Add(4, new string[] {
            "쌓기 스킬은 키보드 3번을 누른 뒤 원하는 장소에 마우스 왼쪽 클릭을 하면 스킬을 사용할 수 있어."
        });

        talkData.Add(5, new string[] {
            "보이지 않는 블럭도 있으니 잘 확인하여 넘어가도록 하자!"
        });

        talkData.Add(6, new string[] {
            "앞에 있는 발판에 블럭이 사라져서 길이 만들어질꺼야."
        });

        talkData.Add(7, new string[] {
            "앞에 있는 발판에 올라간다면 움직이는 블록이 있을 거야."
        });

        talkData.Add(8, new string[] {
            "회전 스킬은 4번을 누른 뒤 스킬사용이 가능한 블록에 마우스 왼쪽 클릭을 이용하여 사용할 수 있어."
        });

        talkData.Add(9, new string[] {
            "앞에 있는 텐트에서는 세이브를 하고 상자에서는 인형을 고치기 위한 재료를 구할 수 있어."
        });

        // 2스테이지 UI 스크립트
        talkData.Add(10, new string[] {
            "마을 분위기가 뭔가 제제만 싫어하는 느낌이었어 왜 그런거지?"
        });

        talkData.Add(11, new string[] {
            "여기를 지나가면 재료가 있다고 들었어."
        });

        talkData.Add(12, new string[] {
            "재료를 무사히 얻었어 또 다른 재료를 얻으러 가자!"
        });

        talkData.Add(13, new string[] {
            "여기는 포탈이 너무 많고 어디로 이어져있는지 나는 모르겠어 너는 알겠니?"
        });

        talkData.Add(14, new string[] {
            "무사히 빠져나왔어 나는 아직도 뭐가 뭔지 모르겠어."
        });

        talkData.Add(15, new string[] {
            "아까 블럭이 말한 것처럼 물속에 들어가보는건 어때?"
        });

        talkData.Add(16, new string[] {
            "나뭇잎 때문에 안전하게 착지한거 같아 다행이야."
        });

        talkData.Add(17, new string[] {
            "여기는 큐브의 도움을 받아야할 것 같아 빨리 출구를 찾아보자!"
        });

        talkData.Add(18, new string[] {
            "여기는 통과하는 길이 너의 선택으로 정해지는 곳이야"
        });

        talkData.Add(19, new string[] {
            "여기를 넘어가면 다시 장난감 마을에 도착해 망가진 장난감들을 고치러가자!"
        });

        talkData.Add(20, new string[] {
            "여기로 쭉 가면 장난감 성으로 가는 배가 있어 우린 그걸 탈 거야."
        });

        // 인형과 대화 스크립트

        // 찢어진 인형
        // 고치기 전
        talkData.Add(1000, new string[] {
            "소녀 인형", "고장", "흑흑흑 도와주세요.",
            "제제", "놀람", "인형이 울고 있었다니!",
            "제제", "슬픔", "그런데 너무 심하게 망가졌어 어쩌다가 이렇게 된거니?",
            "소녀 인형", "고장", "낮에 아이들이 저를 험하게 가지고 놀다가 찢어지닌깐 버리고 갔어요.",
            "제제", "슬픔", "지금까지 많이 힘들었겠다. 내가 고쳐줄게 이리와서 나에게 상처를 보여줘",
            "소녀 인형", "고장", "처음보는데 정말로 저를 고쳐주시는 거예요? ",
            "제제", "슬픔", "다친 모습을 보니 내가 너무 슬퍼서 그래 너를 고치게해줘.",
            "즐리", "슬픔", "제제는 우리가 망가져도 잘 고쳐줬어 걱정하지마 친구야.",
        });

        // 도중
        talkData.Add(1001, new string[] {
            "소녀 인형", "고장", "흑흑흑 아파."
        });

        // 고친 후
        talkData.Add(1002, new string[] {
            "제제", "기쁨", "휴~ 다 고쳤다 내가 고쳐준 곳은 어때?",
            "소녀 인형", "기본", "와! 진짜 튼튼하게 나를 고쳐줬구나! 정말 고마워!",
            "제제", "기쁨", "내가 하고싶어서 한건데 뭘 그런데 너의 이름은 뭐야? 지금까지 이름을 못 들었던거 같아!",
            "애너벨", "기본", "내 이름은 애너벨이야 나를 고쳐준 친구야 너를 위해서 장난감 왕국으로 가는 길을 열어줄께 나중에 기회가 된다면 다시 만나자!",
            "제제", "기본", "그래! 꼭 다시 만나자!"
        });

        // 몽몽이
        // 고치기 전
        talkData.Add(1003, new string[] {
            "제제", "슬픔", "친구야 괜찮니? 우리가 너를 도와주러 왔어",
            "쿠션 인형", "슬픔", "어린아이? 저리가! 더 이상 나를 괴롭히지마!",
            "제제", "슬픔", "너를 괴롭히려는게 아니야! 너를 치료해줄려고 온거야",
            "쿠션 인형", "고장", "나를 치료해줄려고? 처음 만난 사이인데 왜?",
            "제제", "슬픔", "다친모습이 괴로워 보이는데 그걸 나는 지나칠 수 없기 때문이야",
            "쿠션 인형", "고장", "의심해서 미안해… 그러면 치료 부탁해도 될까?",
            "제제", "기쁨", "당연하지! 그러면 친구야 너의 이름은 뭐야?",
            "몽몽이", "고장", "내 이름은 몽몽이야 잘 부탁해!",
        });

        // 도중
        talkData.Add(1004, new string[] {
            "몽몽이", "고장", "흑흑흑 아파."
        });

        // 고친 후
        talkData.Add(1005, new string[] {
            "제제", "기쁨", "몽몽아 치료 끝났어 어때?",
            "몽몽이", "기쁨", "정말 기분이 좋아! 다치기 전과 비슷한 것 같아!",
            "즐리", "기쁨", "당연하지! 제제가 얼마나 잘 고쳐주는데!",
            "몽몽이", "기본", "이름이 제제구나! 제제야 정말 고마워! 너를 도와줄 기회가 생긴다면 나도 무조건 도와줄게!",
            "즐리", "기쁨", "고마워! 그러면 다음에 보자!"
        });

        // 토끼
        // 고치기 전
        talkData.Add(1006, new string[] {
            "제제", "슬픔", "친구야 괜찮니? 우리가 너를 도와주러 왔어",
            "토끼", "슬픔", "어린아이? 저리가! 더 이상 나를 괴롭히지마!"
        });

        // 도중
        talkData.Add(1007, new string[] {
            "토끼", "고장", "흑흑흑 아파."
        });

        // 고친 후
        talkData.Add(1008, new string[] {
            "제제", "기쁨", "몽몽아 치료 끝났어 어때?",
            "토끼", "기쁨", "정말 기분이 좋아! 다치기 전과 비슷한 것 같아!"
        });

        // 자동차
        // 고치기 전
        talkData.Add(1009, new string[] {
            "제제", "슬픔", "친구야 괜찮니? 우리가 너를 도와주러 왔어",
            "자동차", "슬픔", "어린아이? 저리가! 더 이상 나를 괴롭히지마!"
        });

        // 도중
        talkData.Add(1010, new string[] {
            "자동차", "고장", "흑흑흑 아파."
        });

        // 고친 후
        talkData.Add(1011, new string[] {
            "자동차", "기쁨", "몽몽아 치료 끝났어 어때?",
            "자동차", "기쁨", "정말 기분이 좋아! 다치기 전과 비슷한 것 같아!"
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

    public string GetTalk2(int id)
    {
        return talkData[id][0];
    }
}
