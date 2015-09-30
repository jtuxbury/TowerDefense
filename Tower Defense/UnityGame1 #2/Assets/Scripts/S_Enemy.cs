using UnityEngine;
using System.Collections;

public class S_Enemy : MonoBehaviour {

	public int health = 3,mvalue;
	public int spawnedFrom;
	public GameObject Munney;
	
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () {
		S_Money other = Munney.GetComponent<S_Money>();
		if(health <= 0)
		{
			other.money += mvalue;
			Destroy(gameObject);
		}
	
	}
	void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.tag == "Bullet")
		{
			S_Bullet other = c.GetComponent<S_Bullet>();
			S_wayPoints other2 = gameObject.GetComponent<S_wayPoints>();
			if(other.type == 1)
			{
			health -=1;
			Destroy(c.gameObject);
			}
			if(other.type == 2)
			{
		
				Destroy(c.gameObject);
				if(other2.speed > .25f)
				{
				other2.speed -=.25f;
				}
			}
			
		}
	}
	
	
}
