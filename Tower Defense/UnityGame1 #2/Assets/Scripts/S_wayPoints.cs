using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class S_wayPoints : MonoBehaviour
{
	public List<Transform> wayPointList = new List<Transform> ();
	int currentWaypoint;
	public GameObject obj = null;
	public int spawner;
	public float speed = 2f;
	// Use this for initialization
	void Start ()
	{
		
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector3 v = rigidbody.velocity;
		S_Spawner blah = obj.GetComponent<S_Spawner>();
		if (currentWaypoint < wayPointList.Count) {
			Vector3 t = wayPointList [currentWaypoint].position;
			
			Vector3 d = t - transform.position;
			if (d.magnitude < 1) {
				if(currentWaypoint == wayPointList.Count-1)
				{
					blah.die();
					GameObject.Destroy(transform.gameObject);
					
				}
				else
				currentWaypoint++;
			} else {
				v = d.normalized * speed;
				rigidbody.velocity = v;
			}
			
		}
		
		
	}
}
