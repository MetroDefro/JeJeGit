using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraObstract : MonoBehaviour
{
    //public GameObject Character;
    //private Transform MyCha;
    
    //1.카메라부터 캐릭터까지 Raycast를 쏜다.
    // TPSCamera Component
    public GameObject Character;
    public Renderer ObstacleRenderer;
    public List<Renderer> RendererList = new List<Renderer>();
    void Update()
    {

        // 리스트에 저장된거 전부 되돌려
        for (int i = 0; i < RendererList.Count; i++)
        {
            if (RendererList[i] != null)
            {
                // 3. Metrial의 Aplha를 바꾼다.
                Material Mat = RendererList[i].material;
                Color matColor = Mat.color;
                matColor.a = 1f;
                Mat.color = matColor;
            }
        }
        // 리스트 내용물 삭제해
        RendererList.Clear();

        float Distance = Vector3.Distance(transform.position, Character.transform.position);
        Vector3 Direction = (Character.transform.position - transform.position).normalized;
        RaycastHit[] Hit;
        Hit = Physics.RaycastAll(transform.position, Direction, Distance);
        // 2.맞았으면 Renderer를 얻어온다.
        for(int i = 0; i < Hit.Length; i++)
        {
            // 이 것들 모두 리스트에 저장해.
            RendererList.Add(Hit[i].transform.GetComponentInChildren<Renderer>());
            
            // 다시 0.5로바꾸자

            ObstacleRenderer = Hit[i].transform.GetComponentInChildren<Renderer>();
                if (ObstacleRenderer != null)
                {
                    // 3. Metrial의 Aplha를 바꾼다.
                    Material Mat = ObstacleRenderer.material;
                    Color matColor = Mat.color;
                    matColor.a = 0.1f;
                    Mat.color = matColor;
                }

        }

    }
   
}