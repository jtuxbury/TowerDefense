using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class S_GUI : MonoBehaviour {

	public GameObject tile,waveControl,s1,muney,s2,s3,s4;
	public GUIText score,health;
	public bool roundEnd;
	public int menu = 1, rLeft = 10;
	GameObject[] gos;
	void Update()
	{
		S_Money blah = muney.GetComponent<S_Money>();
		score.text =  "Seeds:" + blah.money;
		health.text = "Radishes Left:" + rLeft;
		if(rLeft <= 0)
		{
			Application.LoadLevel("Lose");
		}
	}
	// Update is called once per frame
//	void Update () {
//	S_Placement other = tile.GetComponent<S_Placement>();
//		if(other.towernum == 1)
//		{
//		button1.renderer.material.color = Color.yellow;
//		button2.renderer.material.color = Color.gray;
//		}
//		if(other.towernum == 2)
//		{
//		button1.renderer.material.color = Color.gray;
//		button2.renderer.material.color = Color.yellow;
//		}
//		
//		
//	}
	void OnGUI()
	{
		S_Placement other = tile.GetComponent<S_Placement>();
		gos = GameObject.FindGameObjectsWithTag("Enemy");
		S_Spawner sp1 = s1.GetComponent<S_Spawner>();
		S_Spawner sp2 = s2.GetComponent<S_Spawner>();
		S_Spawner sp3 = s3.GetComponent<S_Spawner>();
		S_Spawner sp4 = s4.GetComponent<S_Spawner>();
		if((gos.Length == 0)&&(!sp1.spawn)&&(!sp2.spawn)&&(!sp3.spawn)&&(!sp4.spawn))
		{
			roundEnd = true;	
		}
		else
		{
			roundEnd = false;
		}
		if(roundEnd)
		{
				if(GUI.Button(new Rect(Screen.width-100,10,100,45), "Start Wave"))
					{
						S_Waves other2 = waveControl.GetComponent<S_Waves>();
						other2.spawn = true;
					}
		}
		if(menu == 1)
		{
			if(GUI.Button(new Rect(10,100,100,45), "Build Towers"))
			{
				other.buildMode = true;
				menu = 2;
			}

		}
		if(menu == 2)
		{
			GUI.Box(new Rect(10,100,100,200), "Towers");
			if(GUI.Button(new Rect(10,150,100,45),"Basic Tower"))
			{
				other.towernum = 1;
			}
			if(GUI.Button(new Rect(10,200,100,45),"Slow Tower \n No Damage"))
			{
				other.towernum = 2;	
			}
			if(GUI.Button(new Rect(10,250,100,45),"Close"))
			{
				other.buildMode = false;
				menu = 1;
			}
		}
	}
}
