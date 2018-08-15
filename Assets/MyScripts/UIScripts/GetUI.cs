using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//测试Json 是否成功
public class GetUI : MonoBehaviour {
    Player player = null;
    Image ig;
    Text text;
    TextAsset asset;
    // Use this for initialization
    void Start () {
        asset = Resources.Load<TextAsset>("JsonTxt/Player");
        player = JsonUtility.FromJson<Player>(asset.text);
        StartCoroutine("AyLoad");
    }
	

	// Update is called once per frame
	void Update () {
		
	}
}
