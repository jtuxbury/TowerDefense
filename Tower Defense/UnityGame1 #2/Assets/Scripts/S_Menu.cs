using UnityEngine;
using System.Collections;

public class S_Menu : MonoBehaviour
{
	public bool quit = false;
	void OnMouseEnter ()
	{
		renderer.material.color = Color.red;	
	}

	void OnMouseExit ()
	{
		renderer.material.color = Color.white;
	}
	void OnMouseDown()
	{
		if (quit)
		{
			Application.Quit();
		}else
		{
			Application.LoadLevel(1);	
		}
	}
	
}
