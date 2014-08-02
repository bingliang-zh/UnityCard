using UnityEngine;
using System.Collections;

public class XYcontrol : MonoBehaviour {
    Animator animator;
    int blood;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        blood = 10;
	}
	
	// Update is called once per frame
	void Update () {
        if (guiButton.chunshenjunActive)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                animator.Play("protect");
                blood = blood - 2;
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                animator.Play("protect");
                blood = blood - 5;
            }
        }
        if (guiButton.boyaActive)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                animator.Play("protect");
                blood = blood - 3;
            }
        }
        if (blood <= 0)
        {
            guiButton.xiangyanActive = false;
            guiButton.XYdeadLabel = "项燕已经被你打死了！";
            Destroy(GameObject.Find("xiangyan"));
        }
        if (guiButton.xiangyanActive)
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
        if (GUI.Button(new Rect(160, Screen.height - 100, 80, 100), new GUIContent("项燕","『世代为将』第N回合可召唤N个项氏人物为将\n『或死或亡』死亡后有一定机率可以复活一次，”世族”的回合数重新开始计算")))
        {
            guiButton.xiangyanActive = true;
            guiButton.boyaActive = false;
            guiButton.chunshenjunActive = false;
            guiButton.chuwangActive = false;
            guiButton.quyuanActive = false;
            guiButton.zhengxiuActive = false;
        }
        GUI.Label(new Rect(Screen.width - 300, Screen.height - 100, 300, 100), GUI.tooltip);
    }
}
