using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 所有按钮的父类
/// </summary>
public abstract class ButtonBase : MonoBehaviour {

    Button button;

	// Use this for initialization
	void Start () {
       
    }
    private void OnEnable()
    {
        print("OnEnable");
        button = GetComponent<Button>();
        button.onClick.AddListener(OnButtonDown);
    }

    /// <summary>
    /// 实现按下方法
    /// </summary>
    public abstract void OnButtonDown();
}
