using UnityEngine;
using System.Collections;

public class guiButton : MonoBehaviour {
    public static bool boyaActive;
    public static bool chunshenjunActive;
    public static bool chuwangActive;
    public static bool quyuanActive;
    public static bool xiangyanActive;
    public static bool zhengxiuActive;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        if(GUI.Button(new Rect(100, 50, 50, 30), "伯牙"))
        {
            boyaActive = true;
            chunshenjunActive = false;
            chuwangActive = false;
            quyuanActive = false;
            xiangyanActive = false;
            zhengxiuActive = false;
        }
        if(GUI.Button(new Rect(100, 100, 50, 30), "春申君"))
        {
            chunshenjunActive = true;
            boyaActive = false;
            chuwangActive = false;
            quyuanActive = false;
            xiangyanActive = false;
            zhengxiuActive = false;
        }
        if (GUI.Button(new Rect(100, 150, 50, 30), "项燕"))
        {
            xiangyanActive = true;
            boyaActive = false;
            chunshenjunActive = false;
            chuwangActive = false;
            quyuanActive = false;
            zhengxiuActive = false;
        }
        if (GUI.Button(new Rect(150, 50, 50, 30), "楚王"))
        {
            boyaActive = false;
            chunshenjunActive = false;
            chuwangActive = true;
            quyuanActive = false;
            xiangyanActive = false;
            zhengxiuActive = false;
        }
        if (GUI.Button(new Rect(150, 100, 50, 30), "屈原"))
        {
            boyaActive = false;
            chunshenjunActive = false;
            chuwangActive = false;
            quyuanActive = true;
            xiangyanActive = false;
            zhengxiuActive = false;
        }
        if (GUI.Button(new Rect(150, 150, 50, 30), "郑袖"))
        {
            boyaActive = false;
            chunshenjunActive = false;
            chuwangActive = false;
            quyuanActive = false;
            xiangyanActive = false;
            zhengxiuActive = true;
        }
    }
}
