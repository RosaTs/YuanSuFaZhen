using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainButton :MonoBehaviour {

    private Button Library;
    private Button StorageRoom;
    private Button Adventure;   //冒险按钮
    private Button Bag;
    private Button SocialContact;
    private Button Shop;
    private Button Setting;
    private Button School;
    
    void OnEnable()
    {
        Library = GameObject.Find("书房").GetComponent<Button>();
        Library.onClick.AddListener(OnLibraryDown);
        Library.GetComponentInChildren<Text>().text = "书房";

        StorageRoom = GameObject.Find("库房").GetComponent<Button>();
        StorageRoom.onClick.AddListener(OnStorageRoomDown);
        StorageRoom.GetComponentInChildren<Text>().text = "库房";

        Adventure = GameObject.Find("冒险").GetComponent<Button>();
        Adventure.onClick.AddListener(OnAdventureDown);
        Adventure.GetComponentInChildren<Text>().text = "冒险";

        Bag = GameObject.Find("背包").GetComponent<Button>();
        Bag.onClick.AddListener(OnBagDown);
        Bag.GetComponentInChildren<Text>().text = "背包";

        SocialContact = GameObject.Find("社交").GetComponent<Button>();
        SocialContact.onClick.AddListener(OnSocialContact);
        SocialContact.GetComponentInChildren<Text>().text = "社交";

        Shop = GameObject.Find("商城").GetComponent<Button>();
        Shop.onClick.AddListener(OnShopDown);
        Shop.GetComponentInChildren<Text>().text = "商城";

        Setting = GameObject.Find("设置").GetComponent<Button>();
        Setting.onClick.AddListener(OnSettingDown);
        Setting.GetComponentInChildren<Text>().text = "设置";

        School = GameObject.Find("学院").GetComponent<Button>();
        School.onClick.AddListener(OnSchoolDown);
        School.GetComponentInChildren<Text>().text = "学院";
    }


    void OnLibraryDown()
    {
        print("书房");
    }

    void OnStorageRoomDown()
    {
        print("库房");
    }

    void OnAdventureDown()
    {
        print("冒险");
    }

    void OnBagDown()
    {
        print("背包");
    }

    void OnSocialContact()
    {
        print("社交");
    }

    void OnShopDown()
    {
        print("商城");
    }

    void OnSettingDown()
    {
        print("设置");
    }

    void OnSchoolDown()
    {
        print("学员");
    }
}
