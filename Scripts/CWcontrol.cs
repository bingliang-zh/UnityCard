using UnityEngine;
using System.Collections;

public class CWcontrol : MonoBehaviour {
    Animator animator;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (guiButton.chuwangActive)
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
        if (GUI.Button(new Rect(240, Screen.height - 100, 80, 100), new GUIContent("楚怀王","『衰楚』召唤该人物时，场上（双方）所有楚势力人物守备力减少\n『客死』僵尸技，血量为0后每回合需进行一次判定，判定为真时才真正死亡；血量为0时成为僵尸，攻击力加倍")))
        {
            guiButton.boyaActive = false;
            guiButton.chunshenjunActive = false;
            guiButton.chuwangActive = true;
            guiButton.quyuanActive = false;
            guiButton.xiangyanActive = false;
            guiButton.zhengxiuActive = false;
        }
        GUI.Label(new Rect(Screen.width - 300, Screen.height - 100, 300, 100), GUI.tooltip);
    }
}
