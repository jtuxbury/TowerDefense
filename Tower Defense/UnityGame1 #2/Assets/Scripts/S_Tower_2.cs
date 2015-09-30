using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class S_Tower_2 : MonoBehaviour
{
	public Transform bullet;
	public Transform[] firePoints;
	public List<Transform> targets = new List<Transform> ();
	public Quaternion newRotation;
	public float turnSpeed = 2f, reloadtime = 10f, pauseTime = .25f, movetime, fireTime;
	public Transform target;
	
	public float angle1,angle2,angle3;
	Quaternion turret1R,turret2R;
	public Transform turret1,turret2;
	
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
					
					Aim (target.position);
				//	turret.LookAt(target.position);
				
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
		if (targets.Exists (isTarget)) {
			targets.Remove (t.transform);
		}
		
	}

	void Aim (Vector3 target_pos)
	{
		Vector3 relativePos = new Vector3(0,0,0);
		turret1R = Quaternion.Euler(-90,0,90);
		relativePos.z = target.position.z - turret1.position.z;
		relativePos.x = target.position.x - turret1.position.x;
        Quaternion rotation = Quaternion.LookRotation(relativePos);
		rotation *= turret1R;
        turret1.rotation = rotation;
		
		Vector3 relativePos2 = new Vector3(0,0,0);
		turret2R = Quaternion.Euler(angle1,angle2,angle3);
		relativePos2 = target.position - turret2.position;
		Quaternion rotation2 = Quaternion.LookRotation(relativePos2);
		rotation2 *= turret2R;
		turret2.rotation = rotation2;
		
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
		if (target.gameObject.tag == "Enemy") {
			return true;
		} else {
			return false;
		}
	}
	
}
