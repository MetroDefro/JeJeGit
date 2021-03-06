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
            "제제", "기본", "지금까지 여행을 저장했어!"
        });
        // 로드시
        talkData.Add(901, new string[] {
            "즐리", "기본", "제제야 다시 출발해볼까?",
            "즐리", "기본", "제제야 다시 출발해볼까?"
        });

        // 부품 획득
        talkData.Add(902, new string[] {
            "제제", "기쁨", "장난감 수리 재료를 얻었어!",
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

        // 3스테이지
        talkData.Add(512, new string[] {
            "제제", "기쁨", "드디어 장난감 성으로 향하는거지!",
            "즐리", "기쁨", "맞아 우리는 배를 타고 장난감 성으로 갈꺼야",
            "큐브", "기쁨", "내가 세운 계획과 다른 시간에 도착하겠지만 그래도 장난감 성으로 향하네",
            "블럭", "기쁨", "그래도 가끔 이렇게 생각대로 안되는게 나는 더 재미있는거 같아!",
            "마그넷", "기쁨", "맞아 가끔 이러면 좋지",
            "마그넷", "슬픔", "하지만 자주 이러면 나 장난감 왕국에 안 오게될꺼야…",
            "제제", "기본", "이런 일은 나랑 같이 와서 그런걸까?",
            "즐리", "기본", "그건 우리도 처음 겪는 일이라 모르겠어 일단 장난감 왕에게 가보면 어떻게 된건지 알 수 있을거야",
            "블럭", "기본", "그러면 도착하기 전까지 모르닌깐 시간도 보낼겸 우리를 만나기전 제제 이야기를 듣고싶어!",
            "제제", "기본", "그러면 내가 계속 병원에 있는 이유를 알려줘야겠네",
            "제제", "기본", "나는 엄마 아빠가 나에게 말하기로는 태어날 때부터 불치병을 가지고 태어나 몸이 약하다고 자주 말씀하셨는데 나는 불치병이 뭔지는 모르겠지만 엄마 아빠가",
            "제제", "슬픔", "하지만 어느날 갑자기 병원에 지내게 되었어 엄마 아빠가 의사 선생님하고 이야기를 하는건 들었지만 무슨 소리인지는 모르겠지만 병원에서 계속 지내야한다는 이야기한건 기억이나",
            "제제", "기쁨", "하지만 엄마와 아빠는 내가 심심할까봐 즐리부터해서 큐브, 마그넷, 블럭까지 가지고 오셔서 너희를 만나게 되었어!",
            "제제", "기쁨", "그래서 나는 지금에서는 너희와 이렇게 대화를 하고 놀 수 있어서 너무 좋아!",
            "즐리", "기쁨", "처음에 몸이 아프다고 말했을 땐 마음이 걸렸지만 우리를 만나서 좋았다고하니 다행이야 우리도 제제를 만나서 지금까지 너무 좋았어!",
            "즐리", "기쁨", "이렇게 옛날 이야기를 들으니 제제가 처음 우리를 만났을 때가 생각나는거 같아",
            "즐리", "기본", "우리 중 내가 가장 먼저 제제와 만나게 되었는데 처음 만났을 땐 제제가 슬픈 표정이 어두웠지만 점점 좋아졌었던 기억이 있어",
            "큐브", "놀람", "정말?!",
            "큐브", "슬픔", "나랑 블럭이랑 마그넷은 즐리보다 나중에 만나서 몰랐지만 제제가 많이 힘들었구나…",
            "마그넷", "슬픔", "그런 일이 있었다니 제제가 많이 힘들었겠구나…",
            "즐리", "기쁨", "그래도 지금은 우리들이 제제를 행복하게 만들어주면 되는거지!",
            "제제", "기쁨", "맞아! 이제부터 더욱 행복해지면 되는거야!",
            "제제", "기본", "그런데 우리가 만나러가는 장난감 왕은 어떤 장난감이야?",
            "블럭", "기쁨", "이건 내가 먼저 설명해주지!",
            "블럭", "기본", "장난감 왕은 어떤 아이가 직접 만들었던 장난감이야 그렇기 때문에 처음에는 엄청나게 아이들을 좋아하던 장난감 중 한명이였다고해",
            "블럭", "기본", "하지만 어느날 장난감 왕은 점점 자신을 만들어준 아이가 자신을 안 찾고 점점 잊혀지자 아이를 좋아하던 마음은 아이를 싫어하는 마음으로 변해갔다고 전해지고있어",
            "마그넷", "기본", "또 다른 이야기로는 장난감 왕이 왕이 되었을 땐 어린아이를 그래도 좋아했기 때문에 어린아이들이 자유롭게 장난감 왕국에 들어오고 나갈 수 있었지만",
            "마그넷", "슬픔", "어느순간부터는 장난감의 초대가 있어야지 어린아이들이 장난감 왕국에 들어올 수 있었지만 들어온 어린아이들은 장난감 왕의 허락이 있어야지 장난감 왕국에 나갈 수 있다고 전해지고있어",
            "큐브", "기본", "그리고 장난감 왕은 어린아이가 다른 장난감을 막 다루다가 고장나면 버리는 아이를 굉장히 싫어해서 그런 아이는 장난감 왕국에 못나가고 오히려 장난감으로 만들어 버리는 마법을 사용한다는 소문도 있어",
            "즐리", "기본", "하지만 누구보다 장난감에게 상냥한 아이라면 장난감 왕은 그 아이를 도와준다는 이야기도 있어",
            "즐리", "기본", "우리는 제제를 처음으로 초대했기 때문에 어떻게 될지 모르겠어…",
            "제제", "기본", "그러면 결국 만나야지 알 수 있다는거네?",
            "즐리", "기본", "그렇지 결국 만나봐야 알겠지만 장난감 왕을 지키는 장난감 병정들에게 잡히면 장난감 왕을 만나기 전에 성에서 쫓겨나게 될꺼야 장난감 병정에게 안잡히고 장난감 왕을 만나러 가자",
            "제제", "기쁨", "알겠어! 다 같이 힘내보자!",
            "즐리", "기쁨", "마침 장난감 성이 보이기 시작했어! 배에서 내릴 준비하자!"
        });

        // 4 스테이지
        talkData.Add(513, new string[] {
            "즐리", "기쁨", "드디어 성문 앞까지 도착했어!",
            "제제", "기쁨", "이제 장난감 왕을 만나러 가는구나!",
            "블럭", "놀람", "어? 성안에 들어가니 우리의 능력을 사용하지 못해!",
            "큐브", "놀람", "뭐라고? 우리의 능력을 사용 못한다면 제제의 혼자 미로를 빠져나와야 한다는 건데",
            "마그넷", "기본", "제제야 혼자서 병정들을 피해서 장난감 왕에게 갈 수 있겠니?",
            "제제", "기본", "무조건 해야지 이번엔 내가 너희를 장난감 왕에게 데려다줄께!",  
            "즐리", "기본", "그렇다면 이제 가볼까?",
            "제제", "기쁨", "그래! 장난감 왕을 만나러 출발!"
        });

        // 엔딩
        // 고쳐준 장난감이 1개 이하인 경우
        talkData.Add(514, new string[] {
            "제제", "기쁨", "안녕하세요!",
            "장난감 왕", "기본", "흠… 어떻게든 여기까지 왔구나",
            "장난감 왕", "슬픔", "짐은 너희가 여기에 바로 못 오도록 장난감 마을에 일부러 떨어뜨린 것이다!",
            "제제", "놀람", "네?! 우리가 여기를 못 오게 일부러 장난감 마을로 떨어뜨린거라니",
            "장난감 왕", "슬픔", "너 같은 어린 아이를 많이 봐 왔더니 진절머리가 나더군",
            "제제", "놀람", "나 같은 아이…?",
            "장난감 왕", "기본", "어허! 짐은 장난감 나라에서 일어나는 모든걸 보는데 모르는 척을 하는군",
            "장난감 왕", "기본", "너는 눈앞에 다친 장난감을 보고도 그냥 지나치고 나에게 오더군",
            "제제", "놀람", "그건…",
            "장난감 왕", "슬픔", "흥! 변명도 듣기 싫다!",
            "장난감 왕", "고장", "너에겐 벌을 내리겠다!",
            "제제", "놀람", "으악! 내 몸이!!!!",
            "장난감 왕", "기쁨", "하하하! 너는 이제 영원히 여기에서 살아야할 것이다!"
        });

        // 고쳐준 장난감이 4개 이하인 경우
        talkData.Add(515, new string[] {
            "제제", "기쁨", "안녕하세요!",
            "장난감 왕", "기본", "흠… 어떻게든 여기까지 왔구나",
            "장난감 왕", "슬픔", "짐은 너희가 여기에 바로 못 오도록 장난감 마을에 일부러 떨어뜨린 것이다.",
            "제제", "놀람", "네?! 우리가 여기를 못 오게 일부러 장난감 마을로 떨어뜨린거라니",
            "장난감 왕", "기본", "흠… 그래도 지금까지 봐왔던 아이들과는 조금 다르긴 하더군",
            "제제", "놀람", "네? 제가 지금까지 여기 왔었던 아이들과 뭐가 달랐다는거죠?",
            "장난감 왕", "기본", "장난감 마을에서 망가진 장난감 모두를 고치진 못 했어도 최선을 다해 고친 모습을 보았다.",
            "장난감 왕", "기쁨", "하하하 최선을 다하는 모습이 생각보다 보기 좋았다.",
            "제제", "기본", "좋게 봐주셔서 감사합니다.",
            "장난감 왕", "기쁨", "매일 누군가 다쳤다는 이야기만 듣다가 누군가 고쳐줬다는 이야기를 듣게 되었으니 그에 걸 맞는 상을 줘야겠군",
            "제제", "놀람", "상이라구요?",
            "장난감 왕", "고장", "그래 이곳은 평범한 아이가 오는 장소가 아니지 다시 너의 세계로 보내주마 잘 가거라",
            "제제", "놀람", "이렇게 갑자기 돌아간다고요?",
            "장난감 왕", "기본", "그래 너같은 아이는 이곳이 어울리지 않는 아이란다 돌아가거라"
        });

        // 모든 장난감을 고쳐준 경우
        talkData.Add(516, new string[] {
            "제제", "기쁨", "안녕하세요!",
            "장난감 왕", "기본", "흠… 어떻게든 여기까지 왔구나",
            "장난감 왕", "기본", "짐은 너희가 여기에 바로 못 오도록 장난감 마을에 일부러 떨어뜨린 것이다.",
            "제제", "놀람", "네?! 우리가 여기를 못 오게 일부러 장난감 마을로 떨어뜨린거라니",
            "장난감 왕", "기본", "그건 짐이 사과하지 내가 어린아이에게 의심이 많아서 그렇다네...",
            "장난감 왕", "기본", "하지만 짐이 지금까지 너를 보아하니 너는 장난감들을 모두 고쳐주며 온거 같더군",
            "제제", "기쁨", "망가진 장난감을 보면 제 마음이 안 좋았거든요",
            "장난감 왕", "기쁨", "하하 너는 정말 이곳에 오면 안되는 아이였군 다시 돌려보내야겠어",
            "제제", "놀람", "다시 돌려보낸다뇨?",
            "장난감 왕", "고장", "너가 지내던 장소로 다시 돌려보낸다는 것이지 또 더 나의 선물을 주도록하지",
            "제제", "놀람", "네?! 이렇게 갑자기요?? 제대로된 인사도 못하고 돌아간다니!",
            "장난감 왕", "기쁨", "하하하 잘 가거라"

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

        talkData.Add(21, new string[] {
            "여기서 우리는 못 도와줘 저 병정을 피해서 왕에게 가자!"
        });

        talkData.Add(22, new string[] {
            "이 성 끝에 장난감 왕이 있어!"
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
            "쿠션인형", "고장", "이 마을에서 나가!",
            "제제", "놀람", "아까도 이 마을에서 나가라고 하는데 왜 내가 나가야 해?",
            "쿠션인형", "고장", "너희 또래 인간들은 우릴 너무 험하게 다루고 망가지면 버리잖아! 우린 그런 너희가 싫어! 빨리 마을에서 나가!",
            "제제", "슬픔", "알았어 마을에서 최대한 빨리 나가줄게 대신 널 고쳐주고 가도 될까?",
            "쿠션인형", "고장", "고쳐준다고? 더 괴롭히는게 아니고?",
            "제제", "기본", "응 나는 다친 널 그냥은 못 나가겠어 널 고치게 해줄래?",
            "쿠션인형", "슬픔", "한번 날 고쳐봐 하지만 날 더 망가뜨리면 널 가만두지 않을 거야"


        });

        // 도중
        talkData.Add(1004, new string[] {
            "쿠션인형", "슬픔", "흑흑흑 아파."
        });

        // 고친 후
        talkData.Add(1005, new string[] {
            "쿠션인형", "기쁨", "정말 날 고쳐줬잖아!",
            "쿠션인형", "기본", "왜 날 고쳐준 거야?",
            "제제", "기쁨", "아까 말했잖아 널 고쳐주고 싶었다고",
            "쿠션인형", "기본", "네가 날 이렇게 고쳐주면 아까 너한테 했던 행동들 모두 사과할게 미안해…",
            "제제", "기쁨", "헤헤 괜찮아 많이 힘들어서 그랬던 거니깐",
            "쿠션인형", "기본", "그래도 너무 모질게 대한 건 내 잘못이 맞으니까 사과해야지",
            "제제", "기쁨", "그렇다면 대신 너의 이름을 알려줄래? 다음에 만나면 친구로 만나자!",
            "몽몽이", "기쁨", "정말? 친구로 만나면 정말 좋을 것 같아 내 이름은 몽몽이라고해 너의 이름은?",
            "제제", "기쁨", "내 이름은 제제야 몽몽아 다음에 만날 땐 서로 반갑게 만나자! 나는 이만 갈께!",
            "몽몽이", "기쁨", "날 도와줘서 고마웠어 제제야 다음에는 꼭 재미있게 같이 놀자!",
            "제제", "기쁨", "그래! 꼭 재미있게 같이 놀자! 나는 이만 가볼께!",
            "몽몽이", "기쁨", "잘가 제제야! 나는 널 응원할게!"
        });

        // 토끼
        // 고치기 전
        talkData.Add(1006, new string[] {
            "토끼인형", "슬픔", "어쩌다가 내가 이렇게 된거지...?",
            "제제", "놀람", "친구야 괜찮니…?",
            "토끼인형", "고장", "으악 저리가! 나를 더 망가뜨리지 말아줘!",
            "제제", "놀람", "아니야 나는 널 도와주기 위해 온 거야",
            "토끼인형", "슬픔", "정말…? 정말 믿어도 되는 거지??",
            "즐리", "슬픔", "그건 우리가 보증할게 제제는 정말 널 도와주길 원해",
            "토끼인형", "슬픔", "그렇다면 날 도와주겠니?",
            "토끼인형", "고장", "어린 친구들이 망가졌다고 그냥 버려서 여기로 오게 되었거든",
            "제제", "기본", "그럼 내가 널 고쳐줄게!"
        });

        // 도중
        talkData.Add(1007, new string[] {
            "토끼인형", "슬픔", "흑흑흑 아파."
        });

        // 고친 후
        talkData.Add(1008, new string[] {
            "토끼인형", "기쁨", "제제야 날 고쳐줘서 고마워!",
            "제제", "기쁨", "잘 고쳐져서 다행이야! 혹시 이름을 물어봐도 될까?",
            "토끼인형", "기쁨", "당연하지 날 도와준 고마운 친구인데 내 이름은 르시야!",
            "제제", "기쁨", "르시라고 하구나! 짧은 인연이지만 널 도와줘서 나는 정말 행복했어!",
            "르시", "기본", "나야말로 제제를 만나서 너무 다행이라고 생각해 이렇게 다쳤었던 날 고쳐줬잖아",
            "르시", "기본", "처음에 너무 경계해서 미안...",
            "제제", "기쁨", "많이 다쳤으니 그건 어쩔 수 없지 그래도 이젠 내가 할 일도 다 했고 이제는 가볼게 잘 있어!",
            "르시", "기쁨", "잘 가 제제야! 널 응원할게!"
        });

        // 자동차
        // 고치기 전
        talkData.Add(1009, new string[] {
            "자동차 장난감", "슬픔", "거기 지나가는 어린아이야 나좀 도와줄래?",
            "제제", "놀람", "어라? 나한테 직접 도움을 요청하는 장난감이 있다니",
            "자동차 장난감", "슬픔", "모든 장난감들이 다쳤다고 모든 어린아이를 싫어하는건 아니야",
            "제제", "슬픔", "그렇구나 하지만 어쩌다가 이렇게 다친거야?",
            "자동차 장난감", "고장", "아이들이 자동차 대결한다고 자동차 장난감끼리 부딪치게 했거든",
            "자동차 장난감", "고장", "그때 당시에는 너무 아프고 부숴졌다는 이유로 날 버린 어린아이들이 원망스러웠지",
            "제제", "놀람", "그렇게 험하게 가지고 놀고 부숴졌다고 버리기까지 정말 너무해!",
            "자동차 장난감", "슬픔", "그래도 시간이 지나니 원망스러운 마음은 사라졌지만 그래도 다친 몸은 그대로라 아프고 힘들어",
            "제제", "기본", "그러면 내가 고쳐줄게!",
            "자동차 장난감", "슬픔", "날 고쳐준다고? 정말 고마워..."
        });

        // 도중
        talkData.Add(1010, new string[] {
            "자동차 장난감", "슬픔", "흑흑흑 아파."
        });

        // 고친 후
        talkData.Add(1011, new string[] {
            "자동차 장난감", "기쁨", "정말 날 고쳐줬잖아!",
            "제제", "기쁨", "휴 힘들었지만 고쳐져서 다행이야!",
            "자동차 장난감", "기본", "날 고쳐준 사람의 이름도 모르고 있었네 혹시 이름을 물어봐도 될까?",
            "제제", "기본", "내 이름은 제제야 너의 이름은 뭐야?",
            "레키", "기본", "나는 레키라고 해 제제야 날 고쳐줘서 정말 고마워",
            "제제", "기쁨", "고맙긴 내가 고쳐주고 싶었어.",
            "제제", "기쁨", "나는 이제 가볼게 레키야 나중에 다시 만나면 그땐 즐겁게 같이 놀자!",
            "레키", "기쁨", "그래 제제야 나중에 꼭 만나서 같이 놀자!",
            "레키", "기쁨", "잘 가 제제야! 나는 널 응원할게!"
        });

        // 로봇
        // 고치기 전
        talkData.Add(1012, new string[] {
            "로봇 장난감", "고장", "거기 멈춰! 너희 이 마을에 어떻게 들어온거지?",
            "제제", "놀람", "여기에 어떻게 들어왔냐니?",
            "즐리", "기본", "우리는 장난감 왕을 만나러 왔지만 무언가 잘못되어서 이 마을에 오게 되었어.",
            "로봇 장난감", "고장", "가끔 장난감들은 봤지만 어린아이가 이 마을에 온건 처음 본다.",
            "제제", "슬픔", "그런데 많이 다친거 같은데 내가 도와줄까?",
            "로봇 장난감", "슬픔", "날 도와주겠다고? 내가 만났던 아이들하고 많이 다른 아이군",
            "로봇 장난감", "슬픔", "그래 마지막으로 믿어 보겠어 날 고쳐줘",
            "제제", "기본", "그래 그러면 내가 그쪽으로 가서 고쳐줄게"
        });

        // 도중
        talkData.Add(1013, new string[] {
            "로봇 장난감", "슬픔", "흑흑흑 아파."
        });

        // 고친 후
        talkData.Add(1014, new string[] {
            "로봇 장난감", "기쁨", "한 두번 고쳐본 솜씨가 아닌걸?",
            "제제", "기쁨", "장난감을 많이 고쳐봤어.",
            "로봇 장난감", "기본", "이 은혜는 잊지 않을게 혹시 너의 이름을 물어봐도 될까?",
            "제제", "기본", "내 이름은 제제라고 해 너는 이름이 뭐야?",
            "타모르", "기본", "내 이름은 타모르라고 한다",
            "제제", "기본", "타모르라고 하는구나 아까 들었던 말 중에 궁금한게 있었는데",
            "제제", "놀람", "아까 이마을에 어린아이가 온건 처음 본다고 했는데 정말 내가 처음 이 마을에 사람으로 들어온거니?",
            "타모르", "기본", "그렇다. 이 마을은 주민 대부분은 어린아이들한테 다치고 버려진 장난감들이 모여 만들어진 마을이다.",
            "타모르", "기본", "그러니 어린아이가 올 수 없는 위치에 마을을 만들어서 숨겨진 마을이 된거지",
            "제제", "슬픔", "이 마을이 슬퍼 보였던 이유가 있었구나 왠지 내가 미안해지네",
            "타모르", "기쁨", "아니다. 너 같이 착한아이도 있다는 걸 알게 되어서 좋았다.",
            "제제", "기쁨", "그렇다면 다행이네 이제 나는 가볼 게 잘 있어 타모르",
            "타모르", "기쁨", "그래 나는 제제 널 응원하겠다."
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
