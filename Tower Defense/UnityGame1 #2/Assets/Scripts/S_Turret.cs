using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class S_Turret : MonoBehaviour
{
	public Transform turret, bullet;
	public Transform[] firePoints;
	public List<Transform> targets = new List<Transform> ();
	public Quaternion newRotation;
	public float turnSpeed = 5f, reloadtime = 1f, pauseTime = .25f, movetime, fireTime;
	public Transform target;
	
	
	// Use this for initialization
	void Start ()
	{	
		
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (targets.Count >= 1) {
		
		
			if (!targets [0]) {
				targets.RemoveAt (0);
			} else {
				target = targets [0]; 
		
			
				if (Time.time >= movetime) {
					
					//Aim (target.position);
					turret.LookAt(target.position);
				
				}
				if (Time.time >= fireTime) {
					Fire ();
				}
			
			}
		
		
		}
	
	}

	void OnTriggerEnter (Collider t)
	{
		if (t.gameObject.tag == "Enemy") {
			targets.Add (t.gameObject.transform);
		
			fireTime = Time.time + reloadtime * .5f;
		}
	}

	void OnTriggerExit (Collider t)
	{
		if (targets.Exists (isTarget)) 
		{
			targets.Remove (t.transform);
		}
		
	}

	void Aim (Vector3 target_pos)
	{
		Vector3 aimPoint = new Vector3 (target_pos.x, target_pos.y, target_pos.z);
		newRotation = Quaternion.LookRotation (aimPoint);
		
	}

	void Fire ()
	{
		fireTime = Time.time + reloadtime;
		movetime = Time.time + pauseTime;
		foreach (Transform aimPos in firePoints) {
			Instantiate (bullet, aimPos.position, aimPos.rotation);
		}
	}

	private bool isTarget (Transform target)
	{
		if (target.gameObject.tag == "Enemy")
		{
			return true;
		} else 
		{
			return false;
		}
	}
	
}
