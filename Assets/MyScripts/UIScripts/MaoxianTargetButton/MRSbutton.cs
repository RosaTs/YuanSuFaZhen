using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public enum ControlType
{
    move,           //移动
    rotate,         //旋转
    scal            //缩放
}
public class MRSbutton : MonoBehaviour {
    private ControlType type = ControlType.move;        //默认为move
    Button moveButton;
    Button rotateButton;
    Button scalButton;
    public static MRSbutton _instance;
    public event Action A_OnButtonDown;                 //按钮被按下的状态
    public ControlType Type                             //Type为只读属性不可在外面更改
    {
        get
        {
            return type;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    // Use this for initialization
    void Start () {
        //注册按钮按下事件
        moveButton = GameObject.Find("movebutton").GetComponent<Button>();
        rotateButton=GameObject.Find("rotatebutton").GetComponent<Button>();
        scalButton = GameObject.Find("scalbutton").GetComponent<Button>();
        moveButton.onClick.AddListener(MoveButtonDown);
        rotateButton.onClick.AddListener(RotateButtonDown);
        scalButton.onClick.AddListener(scalButtonDown);
    }
	

    void MoveButtonDown()
    {
        type = ControlType.move;
        A_OnButtonDown.Invoke();        
    }
    void RotateButtonDown()
    {
        type = ControlType.rotate;
        A_OnButtonDown.Invoke();
    }

    void scalButtonDown()
    {
        type = ControlType.scal;
        A_OnButtonDown.Invoke();
    }
}
