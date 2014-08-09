using UnityEngine;
using System.Collections;

public class ZXcontrol : MonoBehaviour {
	Animator animator;
	public Texture2D card_textrue;
	
	static public bool flag = true;
	static int init_blood = 100;
	static public int attack = 20;
	static public int defence = 1;
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
			guiButton.zhengxiuActive = false;
			animator.Play("death");
		}
		else
		{
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
			if (CSJcontrol.flag==false)
			{
				if (guiButton.xiangyanActive)
				{
					if (Input.GetKeyDown(KeyCode.A))
					{
						animator.Play("protect");
						blood -= XYcontrol.attack-defence;
					}
				}
				if (guiButton.boyaActive)
				{
					if (Input.GetKeyDown(KeyCode.A))
					{
						animator.Play("protect");
						blood -= BYcontrol.attack-defence;
					}
				}
				if (guiButton.quyuanActive)
				{
					if (Input.GetKeyDown(KeyCode.A))
					{
						animator.Play("protect");
						blood -= QYcontrol.attack-defence;
					}
				}
			}
		}
	}
    void OnGUI()
    {
		float factor = (float)blood / (float)init_blood;
		GUI.color = new Color(1-factor, factor, 0);
		if (GUI.Button(new Rect(400, Screen.height - 100, 80, 100), new GUIContent(card_textrue,
		 "郑袖：100/20/1\n『误主』对方主将每发动一次攻击或技能，可能随机地（10%）失效")))
		{
			if (blood <= 0)
			{
				guiButton.activeLabel = "该角色已经死亡";
			}
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
