using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	public GameObject camera1;
	public GameObject camera2;
	public int camx=2;
	// Use this for initialization
	void cam_sx()
	{
		if(camx==1)
			cam_s1();
		else if(camx==2)
			cam_s2();
	}
	
	void cam_s1()
	{
		camera1.active=true;
		camera2.active=false;
		camx=2;
	}
	void cam_s2()
	{
		camera1.active=false;
		camera2.active=true;
		camx=1;
	}
	void OnGUI()
	{
		if(GUI.Button(new Rect(0,20,100,20),"Camera Switch"))
			cam_sx();
		
	}
}
