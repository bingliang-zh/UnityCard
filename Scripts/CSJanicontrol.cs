using UnityEngine;
using System.Collections;

public class CSJanicontrol : MonoBehaviour
{
    Animator animator;
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
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
        if (GUI.Button(new Rect(80, Screen.height - 100, 80, 100), new GUIContent("春申君", "『移花接木』场上任意人物死亡时，可以选择获取他的一个技能")))
        {
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
