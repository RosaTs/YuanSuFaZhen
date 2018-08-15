using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowStateImage : MonoBehaviour {
    Image showImage;
    Sprite statePicture;        //要显示的图片
    Text text;                  //要显示的内容
    private void Awake()
    {
        
    }
    // Use this for initialization
    void Start () {
        MRSbutton._instance.A_OnButtonDown += ChangeMessage;
        showImage = GetComponent<Image>();
        text = gameObject.GetComponentInChildren<Text>();   //从自己子物体中找到Text组件
        if (text!=null)
        {
            //如果
            text.text = "Move";
        }
    }
	
    /// <summary>
    /// 每当按钮按下就切换图标 改变信息
    /// </summary>
    public void ChangeMessage()
    {
        switch (MRSbutton._instance.Type)
        {
            case ControlType.move:
                //statePicture = ResourcesLoad.instance.LoadAssts();
                
                if (text != null)
                {
                    text.text = "Move";
                }
                break;
            case ControlType.rotate:
                if (text != null)
                {
                    text.text = "Rotate";
                }
                
                break;
            case ControlType.scal:
                if (text != null)
                {
                    text.text = "Scal";
                }
                text.text = "Scal";
                break;
            default:
                break;
        }
    }
}
