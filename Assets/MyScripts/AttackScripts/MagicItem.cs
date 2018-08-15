using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MagicItem : MonoBehaviour {
    Button button;
    public string imageName;
	// Use this for initialization
	void Start () {
        button = GetComponent<Button>();
        button.onClick.AddListener(()=> {

            print(imageName + "被按下");
            Destroy(gameObject);
            BurnItem.instance.CreateItem(imageName);
        });
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
        {

        }
    }
}
