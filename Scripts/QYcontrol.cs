using UnityEngine;
using System.Collections;

public class QYcontrol : MonoBehaviour {
    Animator animator;
	public Texture2D card_textrue;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (guiButton.quyuanActive)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                animator.Play("attack");
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                animator.Play("super-attack");
            }
            if (Input.GetKeyDown(KeyCode.D) || Input.GetMouseButtonDown(1))
            {
                animator.Play("protect");
            }
        }
	}
    void OnGUI()
    {
		if (GUI.Button(new Rect(320, Screen.height - 100, 80, 100), new GUIContent(card_textrue,"『离骚』类似于高渐离的”击筑”技能\n『投江』该角色阵亡后，可以获得n张手牌，n取决于xxx(以后再说)")))
        {
            guiButton.boyaActive = false;
            guiButton.chunshenjunActive = false;
            guiButton.chuwangActive = false;
            guiButton.quyuanActive = true;
            guiButton.xiangyanActive = false;
            guiButton.zhengxiuActive = false;
        }
        GUI.Label(new Rect(Screen.width - 300, Screen.height - 100, 300, 100), GUI.tooltip);
    }
}
