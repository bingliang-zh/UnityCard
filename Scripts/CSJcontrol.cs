using UnityEngine;
using System.Collections;

public class CSJcontrol : MonoBehaviour
{
    Animator animator;
    static int init_blood = 15;
    int blood;
	public Texture2D card_textrue;
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        blood = init_blood;
    }

    // Update is called once per frame
    void Update()
    {
        if (guiButton.xiangyanActive)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                animator.Play("protect");
                blood = blood - 8;
            }
        }
        if (guiButton.quyuanActive)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                animator.Play("protect");
                blood = blood - 5;
            }
        }
        if (guiButton.zhengxiuActive)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                animator.Play("protect");
                blood = blood - 3;
            }
        }
        if (guiButton.boyaActive)
        {
            if (Input.GetKeyDown(KeyCode.D) || Input.GetMouseButtonDown(1))
            {
                animator.Play("recover");
                blood = blood + 2;
            }
        }
        if (blood <= 0)
        {
            guiButton.chunshenjunActive = false;
            animator.Play("death");
        }
        if (guiButton.chunshenjunActive)
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
        float factor = (float)blood / (float)init_blood;
        GUI.color = new Color(1-factor, factor, 0);
		if (GUI.Button(new Rect(80, Screen.height - 100, 80, 100), new GUIContent(card_textrue, "『移花接木』场上任意人物死亡时，可以选择获取他的一个技能")))
        {
            if (blood <= 0)
            {
                guiButton.activeLabel = "该角色已经死亡";
            }
            guiButton.chunshenjunActive = true;
            guiButton.boyaActive = false;
            guiButton.chuwangActive = false;
            guiButton.quyuanActive = false;
            guiButton.xiangyanActive = false;
            guiButton.zhengxiuActive = false;
        }
        GUI.Label(new Rect(Screen.width - 300, Screen.height - 100, 300, 100), GUI.tooltip);
    }
}
