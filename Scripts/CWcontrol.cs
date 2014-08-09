using UnityEngine;
using System.Collections;

public class CWcontrol : MonoBehaviour {
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
			guiButton.chuwangActive = false;
			animator.Play("death");
		}
		else
		{
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
			if (CSJcontrol.flag==false&&ZXcontrol.flag==false)
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
		if (GUI.Button(new Rect(480, Screen.height - 100, 80, 100), new GUIContent(card_textrue,
		 "楚怀王：100/30/5\n『衰楚』发动此技能，只能使用一次，场上（双方）所有楚势力人物血量减少20。")))
        {
			if (blood <= 0)
			{
				guiButton.activeLabel = "该角色已经死亡";
			}
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
