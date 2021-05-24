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
        /*
        float Distance = Vector3.Distance(transform.position, Character.transform.position);
        Vector3 Direction = (Character.transform.position - transform.position).normalized;
        RaycastHit Hit;
        if (Physics.Raycast(transform.position, Direction, out Hit, Distance))
        {

            // 2.맞았으면 Renderer를 얻어온다.
            if(ObstacleRenderer != Hit.transform.GetComponentInChildren<Renderer>())
            {
                if (ObstacleRenderer != null)
                {
                    // 3. Metrial의 Aplha를 바꾼다.
                    Material Mat = ObstacleRenderer.material;
                    Color matColor = Mat.color;
                    matColor.a = 1f;
                    Mat.color = matColor;
                }

                ObstacleRenderer = Hit.transform.GetComponentInChildren<Renderer>();
                if (ObstacleRenderer != null)
                {
                    // 3. Metrial의 Aplha를 바꾼다.
                    Material Mat = ObstacleRenderer.material;
                    Color matColor = Mat.color;
                    matColor.a = 0.5f;
                    Mat.color = matColor;
                }
            }
        }
        */

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
            //}
            // => Ray가 더이상 맞지 않거나, 다른물체에 맞았을경우 Renderer 교체 처리
            // => Obstacle들의 Renderer의 렌더모드는 Transparent여야함.
            // => Custom Shader에서는 별도 처리가 필요할수 있음.
            // => Terrain도 마찬가지, Terrain은 불투명처리하려면 Custom Shader를 만들어야함.
        }

    }
    
    /*

    public struct St_ObstacleRendererInfo
    {
        public int InstanceId;
        public MeshRenderer Mesh_Renderer;
    }


    private Dictionary<int, St_ObstacleRendererInfo> Dic_SavedObstaclesRendererInfo = new Dictionary<int, St_ObstacleRendererInfo>();
    private List<St_ObstacleRendererInfo> Lst_TransparentedRenderer = new List<St_ObstacleRendererInfo>();

    private RaycastHit[] TransparentHits;
    private LayerMask TransparentRayLayer;

    void Start()
    {
        MyCha = Character.transform;
    }

    void Update()
    {
        Camera_TransparentProcess_Operation();
    }

    void Camera_TransparentProcess_Operation()
    {
        if (MyCha == null) return;



        // 반투명했던거 다시 월래 쉐이더로 복귀
        if (Lst_TransparentedRenderer.Count > 0)
        {
            for (int i = 0; i < Lst_TransparentedRenderer.Count; i++)
            {
                //Lst_TransparentedRenderer[i].Mesh_Renderer.material.color.a = 1f;
                Material Mat = Lst_TransparentedRenderer[i].Mesh_Renderer.material;
                Color matColor = Mat.color;
                matColor.a = 1f;
                Mat.color = matColor;
            }

            Lst_TransparentedRenderer.Clear();
        }



        Vector3 CharPos = MyCha.position + MyCha.TransformDirection(0, 1.5f, 0);
        float Distance = (transform.position - CharPos).magnitude;

        Vector3 DirToCam = (transform.position - CharPos).normalized;
        Vector3 DirToCharbehind = -MyCha.forward;


        //플레이어몸에서 몸뒤 체크해서 걸리는오브젝트 반투명
        HitRayTransparentObject(CharPos, DirToCharbehind, Distance);
        //플레이어 몸에어 카메라까지 체크해서 걸리는오브젝트 반투명
        HitRayTransparentObject(CharPos, DirToCam, Distance);




    }


    void HitRayTransparentObject(Vector3 start, Vector3 direction, float distance)
    {
        TransparentHits = Physics.RaycastAll(start, direction, distance, TransparentRayLayer);

        for (int i = 0; i < TransparentHits.Length; i++)
        {
            int instanceid = TransparentHits[i].collider.GetInstanceID();

            //레이에 걸린 장애물이 컬렉션에 없으면 저장하기
            if (!Dic_SavedObstaclesRendererInfo.ContainsKey(instanceid))
            {
                MeshRenderer obsRenderer = TransparentHits[i].collider.gameObject.GetComponent<MeshRenderer>();
                St_ObstacleRendererInfo rendererInfo = new St_ObstacleRendererInfo();
                rendererInfo.InstanceId = instanceid; // 고유 인스턴스아이디
                rendererInfo.Mesh_Renderer = obsRenderer; // 메시렌더러

                Dic_SavedObstaclesRendererInfo[instanceid] = rendererInfo;
            }

            // 쉐이더 반투명으로 변경
            //Dic_SavedObstaclesRendererInfo[instanceid].Mesh_Renderer.material.color.a = 0.5f;
            Material Mat = Dic_SavedObstaclesRendererInfo[instanceid].Mesh_Renderer.material;
            Color matColor = Mat.color;
            matColor.a = 0.5f;
            Mat.color = matColor;

            Lst_TransparentedRenderer.Add(Dic_SavedObstaclesRendererInfo[instanceid]);
        }
    }
    */
}