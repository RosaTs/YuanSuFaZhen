using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
/// <summary>
/// 用于生成元素
/// </summary>
public class BurnItem : MonoBehaviour {
    public static BurnItem instance;
    private Dictionary<string, GameObject> items = new Dictionary<string, GameObject>();
    private GameObject itemPosion;
    private Transform Content;
    public float selfHeight = 0f;
    private int i = 1;
    private int j = 1;
    private float x = 0;
    private void Awake()
    {
        instance = this;
       
    }

    // Use this for initialization
    void Start () {
        itemPosion = GameObject.Find("ItemPision");
       
    }
	
    /// <summary>
    /// 用来生成元素
    /// </summary>
    public void CreateItem(string itemName)
    {
        GameObject obj = Resources.Load<GameObject>("Perfabes/ItemImage/"+ itemName);
        GameObject obj1 = Instantiate(obj);
        obj1.transform.parent = itemPosion.transform;
        x -= 0.2f; 
        obj1.transform.localPosition = Vector3.zero+new Vector3(j++,0, x);
        obj1.transform.localRotation = Quaternion.Euler(Vector3.zero);
        selfHeight -= 64;
        Content.GetComponent<RectTransform>().sizeDelta = new Vector2(0, selfHeight);
    }

    /// <summary>
    /// 在画布上生成UI 根据名字生成不同元素
    /// </summary>
    public void CreateUIitem(string name)
    {
        GameObject obj = Resources.Load<GameObject>("Perfabes/UI/MagicItem");

        GameObject obj1 = Instantiate(obj);
        obj1.name = name;
        Content = GameObject.Find("Content").transform;
        obj1.transform.parent = Content;

        obj1.transform.localPosition = Vector3.zero;    //位置清零
        obj1.GetComponent<Image>().sprite = Resources.Load<Sprite>("Textures/ButtonUISp/"+ name);
        selfHeight = i*64;
        i++;
        Content.GetComponent<RectTransform>().sizeDelta = new Vector2(0, selfHeight);
        obj1.GetComponent<MagicItem>().imageName = name;
    }
    /// <summary>
    /// 
    /// </summary>
    public void DeletItem()
    {
       
    }
}
