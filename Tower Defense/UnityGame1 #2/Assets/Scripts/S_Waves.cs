using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class S_Waves : MonoBehaviour {

	public bool spawn,s1=true;
	public GameObject spawner1,spawner2,spawner3,spawner4;
	public int waveNum =1;
	public List<int> s1r1l1 = new List<int>();
	public List<int> s1r1l2 = new List<int>();
	public List<int> s1r2l1 = new List<int>();
	public List<int> s1r2l2 = new List<int>();
	public List<int> s1r3l1 = new List<int>();
	public List<int> s1r3l2 = new List<int>();
	public List<int> s1r4l1 = new List<int>();
	public List<int> s1r4l2 = new List<int>();
	
	public List<int> s2r1l1 = new List<int>();
	public List<int> s2r1l2 = new List<int>();
	public List<int> s2r2l1 = new List<int>();
	public List<int> s2r2l2 = new List<int>();
	public List<int> s2r3l1 = new List<int>();
	public List<int> s2r3l2 = new List<int>();
	public List<int> s2r4l1 = new List<int>();
	public List<int> s2r4l2 = new List<int>();
	
	public List<int> s3r1l1 = new List<int>();
	public List<int> s3r1l2 = new List<int>();
	public List<int> s3r2l1 = new List<int>();
	public List<int> s3r2l2 = new List<int>();
	public List<int> s3r3l1 = new List<int>();
	public List<int> s3r3l2 = new List<int>();
	public List<int> s3r4l1 = new List<int>();
	public List<int> s3r4l2 = new List<int>();
	
	public List<int> s4r1l1 = new List<int>();
	public List<int> s4r1l2 = new List<int>();
	public List<int> s4r2l1 = new List<int>();
	public List<int> s4r2l2 = new List<int>();
	public List<int> s4r3l1 = new List<int>();
	public List<int> s4r3l2 = new List<int>();
	public List<int> s4r4l1 = new List<int>();
	public List<int> s4r4l2 = new List<int>();
	// Update is called once per frame
	void Update () 
	{
		S_Spawner s1 = spawner1.GetComponent<S_Spawner>();
		S_Spawner s2 = spawner2.GetComponent<S_Spawner>();	
		S_Spawner s3 = spawner3.GetComponent<S_Spawner>();
		S_Spawner s4 = spawner4.GetComponent<S_Spawner>();
		
		if(spawn == true)
		{
			if(waveNum == 1)
			{
				//	spawn = false;
					s1.SetWave(s1r1l1,s1r1l2,5.0f);
					s2.SetWave(s2r1l1,s2r1l2,5.0f);
					s3.SetWave(s3r1l1,s3r1l2,5.0f);
					s4.SetWave(s4r1l1,s4r1l2,5.0f);

			}
			if(waveNum == 2)
			{
					s1.SetWave(s1r2l1,s1r2l2,4.0f);
					s2.SetWave(s2r2l1,s2r2l2,5.0f);
					s3.SetWave(s3r2l1,s3r2l2,5.0f);
					s4.SetWave(s4r2l1,s4r2l2,5.0f);
			}
			if(waveNum == 3)
			{
					s1.SetWave(s1r3l1,s1r3l2,2.0f);
					s2.SetWave(s2r3l1,s2r3l2,3.0f);
					s3.SetWave(s3r3l1,s3r3l2,4.0f);
					s4.SetWave(s4r3l1,s4r3l2,4.0f);
			}
			if(waveNum == 4)
			{
					s1.SetWave(s1r4l1,s1r4l2,2.0f);
					s2.SetWave(s2r4l1,s2r4l2,2.0f);
					s3.SetWave(s3r4l1,s3r4l2,3.0f);
					s4.SetWave(s4r4l1,s4r4l2,3.0f);
			}
			if(waveNum == 6)
			{
				Application.LoadLevel("Win");	
			}
		//	spawn = false;
			waveNum ++;
		//	spawn = false;
		}
		
	}
}
