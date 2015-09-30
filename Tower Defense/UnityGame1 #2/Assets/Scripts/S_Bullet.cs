using UnityEngine;
using System.Collections;

public class S_Bullet : MonoBehaviour {
	public float Speed = 10,Range = 10, Distance;
	
	public int type;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward * Time.deltaTime * Speed);
		Distance += Time.deltaTime * Speed;
		if(Distance > Range)
			Destroy(gameObject);
		
	}
	
	
	
}
