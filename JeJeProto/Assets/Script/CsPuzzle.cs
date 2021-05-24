using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsPuzzle : MonoBehaviour
{
    //Puzzle 클래스: 퍼즐 애리어에 넣기
    //변수: 힌트, 소속 Block GameObject
    public bool hint;
    public Transform puzzleObject;
    private Transform[] blocks;
    private Vector3[] blockVectors;
    private bool[] isActive;

    public Sprite hintSprite;

    void Awake()
    {
        blocks = puzzleObject.gameObject.GetComponentsInChildren<Transform>();
        blockVectors = new Vector3[blocks.Length];
        isActive = new bool[blocks.Length];
    }
    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SavePuzzle(int j)
    {      
        for (int i = 0; i < blocks.Length; i++)
        {
            blockVectors[i] = blocks[i].transform.position;
            // 그리고 블록 활성화된상태인지 비활성화된 상태인지도 조사해서
            // 저장하고 불러와
            isActive[i] = blocks[i].gameObject.activeSelf;
        }
        PlayerPrefsX.SetVector3Array("Blocks" + j, blockVectors);
        PlayerPrefsX.SetBoolArray("Active" + j, isActive);
    }

    public void LoadPuzzle(int j)
    {
        blockVectors = PlayerPrefsX.GetVector3Array("Blocks" + j);
        isActive = PlayerPrefsX.GetBoolArray("Active" + j);
        for (int i = 0; i < blocks.Length; i++)
        {
            blocks[i].transform.position = blockVectors[i];
            blocks[i].gameObject.SetActive(isActive[i]);
        }
    }
}
