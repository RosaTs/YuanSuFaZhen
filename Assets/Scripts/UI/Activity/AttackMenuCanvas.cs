using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackMenuCanvas : MonoBehaviour {
    public static AttackMenuCanvas Instance;

    public AttackMenuCanvas()
    {
        Instance = this;    //
    }


    /// <summary>
    /// 这个Canvas
    /// </summary>
    /// <returns></returns>
    public Transform attackMenuCanvas()
    {
        return transform;
    }


    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
