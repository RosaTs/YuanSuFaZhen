using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
/// <summary>
/// 控制UI的生成与销毁
/// </summary>
public class UIController : MonoBehaviour {
    private static readonly UIController instance;

    public Player player;

    TextAsset asset;

    
    Transform uiLayer0;     //UI层级0
    Transform uiLayer1;     //UI层级1
    Transform uiLayer2;     //UI层级2

    public Stack<UIBase> panels;
    public static UIController Instance
    {
        get
        {
            return instance;
        }
    }
    
    // Use this for initialization
    void Start () {
        asset = Resources.Load<TextAsset>("JsonTxt/Player");
        player = JsonUtility.FromJson<Player>(asset.text);
        ResourcesLoad.instance.LoadAssts("UI/MainButton");
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            DisUIPanel();
        }
	}
    
    /// <summary>
    /// 生成ui
    /// </summary>
    void CreatUIPanel()
    {
      
    }

    void DisUIPanel()
    {
        ResourcesLoad.instance.DelAssts("UI/MainButton");
    }

}
