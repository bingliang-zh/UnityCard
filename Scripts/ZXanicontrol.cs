using UnityEngine;
using System.Collections;

public class ZXanicontrol : MonoBehaviour {
    Animator animator;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (guiButton.zhengxiuActive)
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
        if (GUI.Button(new Rect(400, Screen.height - 100, 80, 100), new GUIContent("郑袖","『误主』该人物处于前场时，对方主将每发动一次攻击或技能，作用对象可能随机地成为对方的一个副将\n『争宠』可使场上双方所有女性角色包括龙阳君、荆轲、邹忌等漂亮角色扣血")))
        {
            guiButton.boyaActive = false;
            guiButton.chunshenjunActive = false;
            guiButton.chuwangActive = false;
            guiButton.quyuanActive = false;
            guiButton.xiangyanActive = false;
            guiButton.zhengxiuActive = true;
        }
        GUI.Label(new Rect(Screen.width - 300, Screen.height - 100, 300, 100), GUI.tooltip);
    }
}
