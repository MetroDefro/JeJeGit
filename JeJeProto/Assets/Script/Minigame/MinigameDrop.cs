using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MinigameDrop : MonoBehaviour
{
    private GameObject Parts;

    private GameObject target;

    public Camera camera;

    private GameObject ins;
    private Transform Par;
    void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MinigameManager.instance.bNum == GameObject.FindGameObjectsWithTag("MinigameTrigger").Length)
        {
            camera.transform.position = new Vector3(30, 30, 0);
                
            MinigameManager.instance.isMini2 = true;
            return;
        }
            
        if (Input.GetMouseButtonUp(0))
        {
            target = GetClickedObject();

            if (target == null)
            {
                return;
            }
            //선택된게 맞는장소면
            else if (target.GetComponent<Collider>().CompareTag("Place"))
            {
                if (target.GetComponent<MinigamePlace>().In == true)
                    return;
                
                Parts = MinigameManager.instance.Parts;
                if(Parts.GetComponent<MinigameParts>().num == 2) 
                    SoundManager.instance.MinigameButtonSound();
                else if(Parts.GetComponent<MinigameParts>().num == 0)
                    SoundManager.instance.MinigameCottonSound();
                else if (Parts.GetComponent<MinigameParts>().num == 1)
                    SoundManager.instance.MinigameClothSound();

                Vector3 pos = new Vector3(target.transform.position.x, target.transform.position.y + 1, target.transform.position.z);
                ins = Instantiate(Parts, pos, target.transform.rotation);
                Par = GameObject.Find("Parent").transform;
                ins.transform.parent = Par;
                target.GetComponent<MinigamePlace>().In = true;
                if (target.GetComponent<MinigamePlace>().PN == Parts.GetComponent<MinigameParts>().num)
                    target.GetComponent<MinigamePlace>().End = true;
            }
        }
    }

    private GameObject GetClickedObject()
    {
        RaycastHit hit;
        GameObject target = null;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition); //마우스 포인트 근처 좌표를 만든다. 
        int MC = 1 << LayerMask.NameToLayer("MiniGameClick");
        if (Physics.Raycast(ray.origin, ray.direction * 10, out hit, float.MaxValue, MC))   //마우스 근처에 오브젝트가 있는지 확인
        {
            //있으면 오브젝트를 저장한다.
            target = hit.collider.gameObject;
        }
        return target;
    }
}
