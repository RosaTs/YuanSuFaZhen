using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CarmaRay : MonoBehaviour {

    private Vector3 det;        //相对差


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0)||Input.touchCount>0)
        {

#if UNITY_ANDROID || UNITY_IPHONE
            //如果是安卓
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;
            if (true)
            {

            }
            if (Physics.Raycast(ray, out hit))
            {
                StartCoroutine("OnTouchDown1", hit.collider.transform);
            }
#else
            //如果是pc
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                print(hit.collider.name);

                det = hit.collider.transform.position - Input.mousePosition;
                StartCoroutine("OnMouseDown1", hit.collider.transform);
            }
#endif
        }
    }
    
    IEnumerator OnMouseDown1(Transform obj)
    {

        Vector3 ScreenSpace = Camera.main.WorldToScreenPoint(transform.position);


        Vector3 offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, ScreenSpace.z));

        Debug.Log("down");

        //当鼠标左键按下时  
        while (Input.GetMouseButton(0))
        {
            //得到现在鼠标的2维坐标系位置  
            Vector3 curScreenSpace = new Vector3(Input.mousePosition.x, Input.mousePosition.y, ScreenSpace.z);
            //将当前鼠标的2维位置转化成三维的位置，再加上鼠标的移动量  
            Vector3 CurPosition = Camera.main.ScreenToWorldPoint(curScreenSpace);// + offset
            //CurPosition就是物体应该的移动向量赋给transform的position属性        
            obj.position = new Vector3(CurPosition.x,obj.position.y, CurPosition.z+2) ;
            //这个很主要  

            yield return new WaitForFixedUpdate();
        }


    }

    IEnumerator OnTouchDown1(Transform obj)
    {
       
        Vector3 ScreenSpace = Camera.main.WorldToScreenPoint(transform.position);


        Vector3 offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.touches[0].position.x, Input.touches[0].position.y, ScreenSpace.z));

        Debug.Log("down");

        //当鼠标左键按下时  
        while (Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            //得到现在鼠标的2维坐标系位置  
            Vector3 curScreenSpace = new Vector3(Input.touches[0].position.x, Input.touches[0].position.y, ScreenSpace.z);
            //将当前鼠标的2维位置转化成三维的位置，再加上鼠标的移动量  
            Vector3 CurPosition = Camera.main.ScreenToWorldPoint(curScreenSpace);// + offset
            //CurPosition就是物体应该的移动向量赋给transform的position属性        
            obj.position = new Vector3(CurPosition.x, obj.position.y, CurPosition.z);
            //这个很主要  
            print("aaa");
            yield return new WaitForFixedUpdate();
        }


    }
}
