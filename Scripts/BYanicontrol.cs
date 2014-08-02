using UnityEngine;
using System.Collections;

public class BYanicontrol : MonoBehaviour {
    Animator animator;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (guiButton.boyaActive)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                animator.Play("attack");
            }
            if (Input.GetKeyDown(KeyCode.D) || Input.GetMouseButtonDown(1))
            {
                animator.Play("protect");
            }
        }
    }
    void OnGUI()
    {
        GUI.Box(new Rect(0, Screen.height - 100, Screen.width, 100), "");
        if (GUI.Button(new Rect(0, Screen.height - 100, 80, 100), new GUIContent("伯牙", "『知音』每回合可选择场上任一人物进行判定，若为”知音”，双方同时回血\n『绝弦』若上一回合判定为”知音”的人物在这一回合死亡，”知音”技能消失")))
        {
            guiButton.boyaActive = true;
            guiButton.chunshenjunActive = false;
            guiButton.chuwangActive = false;
            guiButton.quyuanActive = false;
            guiButton.xiangyanActive = false;
            guiButton.zhengxiuActive = false;
        }
        GUI.Label(new Rect(Screen.width-300, Screen.height - 100, 300, 100), GUI.tooltip);
    }

}
