using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 资源加载工具类 负责从Assts里加载资源到缓存中
/// </summary>
public class ResourcesLoad : MonoBehaviour {
    public static ResourcesLoad instance;
    private Transform canvas;

    private void Awake()
    {
        instance = this;
        canvas = GameObject.Find("Canvas").transform;
    }
    private Dictionary<string, GameObject> dic = new Dictionary<string, GameObject>();
    /// <summary>
    /// 加载GameObject类型
    /// </summary>
    /// <param name="asstsNa">资源名</param>
    /// <returns></returns>
    public GameObject LoadAssts(string asstsNa)
    {
        if (dic.ContainsKey(asstsNa))
        {
            return dic[asstsNa];
        }
        else
        {
            GameObject obj = Instantiate(Resources.Load<GameObject>("Perfabes/" + asstsNa));
            obj.name = asstsNa;
            obj.transform.parent = canvas;
            obj.transform.localPosition = Vector3.zero;
            obj.transform.localScale = new Vector3(1, 1, 1);
            dic.Add(asstsNa, obj);  //将资源方法到字典集合中管理
                                    //返回
            return obj;
        }
    }

    /// <summary>
    /// 释放资源
    /// </summary>
    /// <param name="asstsNa">所释放资源的名字</param>
    public void DelAssts(string asstsNa)
    {
        if (dic.ContainsKey(asstsNa))
        {
            Destroy(dic[asstsNa]);
            dic.Remove(asstsNa);        //从字典中移除
            Resources.UnloadUnusedAssets(); //将没有被引用的资源释放掉
        }
    }
}
