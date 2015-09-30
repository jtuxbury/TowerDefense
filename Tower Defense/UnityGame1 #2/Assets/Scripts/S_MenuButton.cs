using UnityEngine;
using System.Collections;

public class S_MenuButton : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
        
	}
	void OnMouseEnter()
	{
		renderer.material.color = Color.green;
		audio.Play();
	}
	void OnMouseExit ()
	{
		renderer.material.color = Color.white;
	}
	void OnMouseUp ()
	{
		 Application.LoadLevel("Story");
	}
	
	
}
