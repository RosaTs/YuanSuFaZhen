using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBounds : MonoBehaviour {
	
	public GameObject someRenderer;
	public GameObject myBoxCollider;
	// Use this for initialization
	void Start () {
		
	}	
	// Update is called once per frame
	void Update () {

		float R1 = myBoxCollider.transform.localScale.x*2.8f;
		float R2 = someRenderer.transform.localScale.x*2.8f;//取半径，系数是碰撞快半径大小

		Vector3 Q1 = myBoxCollider.transform.position;
		Vector3 Q2 = someRenderer.transform.position;//位置信息
		float P= (Q1-Q2).magnitude;//中心距

			if ((P < Mathf.Abs (R1 - R2)) || (P == Mathf.Abs (R1 - R2))) {
	
			if(R1>R2)
				{Debug.Log ("圆在六芒星里面");}

				if(R2>R1)
				{Debug.Log ("六芒星在圆里面");}

			} else {
				Debug.Log ("不包含");
			}

	}
}
