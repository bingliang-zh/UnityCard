using UnityEngine;
using System.Collections;

public class guiButton : MonoBehaviour {
    public static bool boyaActive;
    public static bool chunshenjunActive;
    public static bool chuwangActive;
    public static bool quyuanActive;
    public static bool xiangyanActive;
    public static bool zhengxiuActive;
    string activeLabel;
    public static string XYdeadLabel;
    public static string CSJdeadLabel;
	// Use this for initialization
	void Start () {
        activeLabel = "Active: NULL\n\nPlease Choose a Character Card.";
        XYdeadLabel = "";
        CSJdeadLabel = "";
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
        GUI.Label(new Rect(160, Screen.height - 100, 80, 100), XYdeadLabel);
        GUI.Label(new Rect(80, Screen.height - 100, 80, 100), CSJdeadLabel);
    }
}
