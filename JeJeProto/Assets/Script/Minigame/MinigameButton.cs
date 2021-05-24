using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MinigameButton : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    public GameObject Parts;
    public GameObject PartsUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        MinigameManager.instance.Parts = Parts;
        PartsUI.SetActive(true);
    }
    public void OnDrag(PointerEventData eventData)
    {
        // 마우스 위치에 해당 파츠 이미지 따라다니게끔 (UI)
        PartsUI.transform.position = eventData.position;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        // 마우스 위치 해당 파츠 이미지 사라짐
        PartsUI.SetActive(false);
    }


}
