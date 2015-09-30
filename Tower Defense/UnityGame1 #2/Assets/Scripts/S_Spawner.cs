using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class S_Spawner : MonoBehaviour {
	
	// Use this for initialization
	public GameObject Enemy,Enemy2,Controller,guii;
	public float spawnTime = 5.0f;
	public float sTR = 5.0f,sTR2 = 7.0f;
	public int waveNum,l1,l2,spawnerNum;
	public bool spawn = false,canSpawn = true;
	public List<Transform> wayPointList = new List<Transform>();
	public List<Transform> wayPointList2 = new List<Transform>();
	List<int> enemList1 = new List<int>();
	List<int> enemList2 = new List<int>();
	public bool tester,tester2,tester3;
	
	// Update is called once per frame
	void Update () 
	{
		
		if(spawn)
		{
			sTR -= Time.deltaTime;
			sTR2 -= Time.deltaTime;
			if((sTR <= 0) && (l1 <= enemList1.Count))
			{
				
				if(enemList1[l1] == 1)
				{
				tester = true;
					
					GameObject clone = (GameObject) Instantiate(Enemy,gameObject.transform.position,Quaternion.identity);
					S_Enemy blah = clone.GetComponent<S_Enemy>();
					getWayPoints(clone);
					
					
				}
				if( enemList1[l1] == 2)
				{
					tester2 = true;
						GameObject clone = (GameObject) Instantiate(Enemy2,gameObject.transform.position,Quaternion.identity);
						getWayPoints(clone);
					
				}
				l1++;
				sTR = spawnTime;
			}
			if(enemList2.Count > 0)
			{
				if((sTR2 <= 0) && (l2 <= enemList2.Count))
				{
					if(enemList2[l2] == 1)
					{
						GameObject clone = (GameObject) Instantiate(Enemy,gameObject.transform.position,Quaternion.identity);
						getWayPoints(clone);
						l2++;
					}
					else if(enemList2[l2] == 2)
					{
						GameObject clone = (GameObject) Instantiate(Enemy2,gameObject.transform.position,Quaternion.identity);
						getWayPoints(clone);
						l2++;
					}
					else
					{
						l2++;
					}
				sTR2 = spawnTime;
				}
			}
			if((l1 >= enemList1.Count -1)&&(l2 >= enemList2.Count-1))
			{
				spawn = false;
			}

		}
	}
	
	public void SetWave(List<int> list1,List<int> list2,float f)
	{
		enemList1 = list1;
		enemList2 = list2;
		l1 = 0;
		l2 = 0;
		sTR = f;
		sTR2 = f +2;
		spawnTime = f;
		spawn = true;
		S_Waves other = Controller.GetComponent<S_Waves>();
		other.spawn =false;
	}
	void getWayPoints(GameObject c)
	{
		if(spawnerNum == 3)
		{
			S_wayPoints other = c.GetComponent<S_wayPoints>();
			if(Random.Range(1,2) == 1)
			{
			other.wayPointList = wayPointList;
			other.obj = gameObject;
			other.spawner = spawnerNum;
			}
			else
			{
			other.wayPointList = wayPointList2;
			other.obj = gameObject;
			other.spawner = spawnerNum;
			}
			
		}
		if(spawnerNum == 1)
		{
			S_wayPoints other = c.GetComponent<S_wayPoints>();
			other.wayPointList = wayPointList;
			other.obj = gameObject;
			other.spawner = spawnerNum;
		}
	}
	public void die()
	{
		S_GUI woo = guii.GetComponent<S_GUI>();
		woo.rLeft-= 1;
	}
}


			
		
		
		
	
