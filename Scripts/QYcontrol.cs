using UnityEngine;
using System.Collections;

public class QYcontrol : MonoBehaviour {
    Animator animator;
	public Texture2D card_textrue;

	static public bool flag = true;
	static int init_blood = 100;
	static public int attack = 30;
	static public int defence = 5;
	int blood;
	
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		blood = init_blood;
	}
	
	// Update is called once per frame
	void Update () {
		if (blood <= 0) {
			flag=false;
			guiButton.quyuanActive = false;
			animator.Play("death");
		}
		else
		{
	        if (guiButton.quyuanActive)
	        {
	            if (Input.GetKeyDown(KeyCode.A))
	            {
	                animator.Play("attack");
	            }
	            if (Input.GetKeyDown(KeyCode.S))
	            {
	                animator.Play("skill");
	            }
	            if (Input.GetKeyDown(KeyCode.D) || Input.GetMouseButtonDown(1))
	            {
	                animator.Play("protect");
	            }
	        }
			if (XYcontrol.flag==false&&BYcontrol.flag==false)
			{
				if (guiButton.chunshenjunActive)
				{
					if (Input.GetKeyDown(KeyCode.A))
					{
						animator.Play("protect");
						blood -= CSJcontrol.attack-defence;
					}
					if (Input.GetKeyDown(KeyCode.S))
					{
						animator.Play("protect");
						blood -= (int)((CSJcontrol.attack-defence)*1.2);
					}
				}
				if (guiButton.zhengxiuActive)
				{
					if (Input.GetKeyDown(KeyCode.A))
					{
						animator.Play("protect");
						blood -= ZXcontrol.attack-defence;
					}
				}
				if (guiButton.chuwangActive)
				{
					if (Input.GetKeyDown(KeyCode.A))
					{
						animator.Play("protect");
						blood -= CWcontrol.attack-defence;
					}
				}
			}
		}
	}
    void OnGUI()
    {
		float factor = (float)blood / (float)init_blood;
		GUI.color = new Color(1 - factor, factor, 0);
		if (GUI.Button(new Rect(0, Screen.height - 100, 80, 100), new GUIContent(card_textrue,
		   "屈原：100/30/5\n『离骚』自动选择一名队友回复血量10")))
        {
			if (blood <= 0)
			{
				guiButton.activeLabel = "该角色已经死亡";
			}
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
