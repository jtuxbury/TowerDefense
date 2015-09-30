using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class S_Text : MonoBehaviour {
	public bool button = false;
	// Use this for initialization
	void Start () {
	
	}
	void OnGUI(){
		if(button)
		{
			if(GUI.Button(new Rect(Screen.width-100,Screen.height-45,100,45), "Start Game"))
			{
		Application.LoadLevel(2);
			}
	
		}
	}
	// Update is called once per frame
	void Update () {
		if(gameObject.transform.position.y <= 27f){
	gameObject.transform.position += new Vector3(0f,.05f,0f);
		}else{
			button = true;
		}
	}
	
}
