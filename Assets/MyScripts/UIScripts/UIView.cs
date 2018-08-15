using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// mvc 中视图显示层
/// </summary>
public class UIView : MonoBehaviour {
    Player player;      //玩家类
    Image headPicture;  //头像
    Text text;          //名字显示
    TextAsset asset;    //json文件 转text 
    
    void Awake()
    {

    } 

    // Use this for initialization
    void Start () {
        asset = Resources.Load<TextAsset>("JsonTxt/Player");    //通过路径获取json文件
        player = JsonUtility.FromJson<Player>(asset.text);      
        StartCoroutine("AsyLoad");
    }

    IEnumerator AsyLoad()
    {
        headPicture = GameObject.Find("HeadPicture").GetComponent<Image>();       //开启协程获取组件
        text = GameObject.Find("PlayeName").GetComponent<Text>();
        headPicture.sprite = Resources.Load<Sprite>("Textures/HeadPictures/" + player.headportraitID);
        print(player.name);
        text.text = player.name;
        yield return null;
    }

}
