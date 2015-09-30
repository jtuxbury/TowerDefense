using UnityEngine;
using System.Collections;

public class S_Cam : MonoBehaviour {

	public Transform Cam;
	public float w,a,s,d;
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.W))
		{
			w = -.1f;
		}
		if(Input.GetKeyUp(KeyCode.W))
		{
			w = 0f;	
		}
		if(Input.GetKeyDown(KeyCode.S))
		{
			s = .1f;
		}
		if(Input.GetKeyUp(KeyCode.S))
		{
			s = 0f;	
		}
		if(Input.GetKeyDown(KeyCode.A))
		{
			a = -.1f;
		}
		if(Input.GetKeyUp(KeyCode.A))
		{
			a = 0f;	
		}
		if(Input.GetKeyDown(KeyCode.D))
		{
			d = .1f;
		}
		if(Input.GetKeyUp(KeyCode.D))
		{
			d = 0f;	
		}
		
		
		if(Cam.position.x < -9)
		{
			w = 0;	
		}
		if(Cam.position.x > 6)
		{
			s = 0;	
		}
		if(Cam.position.z < -33)
		{
			a = 0;	
		}
		if(Cam.position.z > -17)
		{
			d = 0;	
		}
		
		Cam.position += new Vector3(w + s,0.0f,a+d);
		
	}
}
