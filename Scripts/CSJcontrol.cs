using UnityEngine;
using System.Collections;

public class CSJcontrol : MonoBehaviour{
    Animator animator;
	public Texture2D card_textrue;

	static public bool flag = true;
	static int init_blood = 100;
	static public int attack = 40;
	static public int defence = 10;
	int blood;
	
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		blood = init_blood;
	}

    // Update is called once per frame
    void Update()
    {
		if (blood <= 0) {
			flag=false;
			guiButton.chunshenjunActive = false;
			animator.Play("death");
		}
		else
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
    }
    void OnGUI()
    {
        float factor = (float)blood / (float)init_blood;
        GUI.color = new Color(1-factor, factor, 0);
		if (GUI.Button(new Rect(320, Screen.height - 100, 80, 100), new GUIContent(card_textrue, 
		 "春申君：100/40/10")))
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
