using UnityEngine;
using System.Collections;

public class guiButton : MonoBehaviour {
    public static bool boyaActive;
    public static bool chunshenjunActive;
    public static bool chuwangActive;
    public static bool quyuanActive;
    public static bool xiangyanActive;
    public static bool zhengxiuActive;
    public static string activeLabel;
	// Use this for initialization
	void Start () {
        activeLabel = "Active: NULL\n\nPlease Choose a Character Card.";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        GUI.Box(new Rect(Screen.width-110,0,110,130),"");
        if(boyaActive)
        {
            activeLabel = "Acitve: 伯牙\n\nControl:\na=attack d\\右键=protect";
        }
        if (chunshenjunActive)
        {
            activeLabel = "Acitve: 春申君\n\nControl:\na=attack s=super-attack d\\右键=protect";
        }
        if (chuwangActive)
        {
            activeLabel = "Acitve: 楚怀王\n\nControl:\na=attack d\\右键=protect";
        }
        if (quyuanActive)
        {
            activeLabel = "Acitve: 屈原\n\nControl:\na=attack s=super-attack d\\右键=protect";
        }
        if (xiangyanActive)
        {
            activeLabel = "Acitve: 项燕\n\nControl:\na=attack d\\右键=protect";
        }
        if (zhengxiuActive)
        {
            activeLabel = "Acitve: 郑袖\n\nControl:\na=attack d\\右键=protect";
        }
        GUI.Label(new Rect(Screen.width-100,10,90,110),activeLabel);
    }
}
