using UnityEngine;
using System.Collections;

public class S_Placement : MonoBehaviour {
    public bool buildMode = false;
	Transform folder;
	public Material hoverMat;
	public LayerMask placeMask;
	public Material mat;
	GameObject lastHit;
	public GameObject turret,turret2, Money;
	public int m = 2,towernum=1;
	
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		S_Money other = Money.GetComponent<S_Money>();
		m = other.money;
		
		if(buildMode)
		{
			
			
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if(Physics.Raycast(ray, out hit,(float)1000, placeMask))
			{
				if(lastHit)
				{
					lastHit.renderer.material = mat;
				}
				lastHit = hit.collider.gameObject;
				mat = lastHit.renderer.material;
				lastHit.renderer.material = hoverMat;
			}else 
			{
				if(lastHit)
				{
					lastHit.renderer.material = mat;
					lastHit = null;
				}
			}
			if(Input.GetMouseButtonDown(0) && lastHit && m > 0)
			{
				if(lastHit.tag == "Empty")
				{
					if(towernum ==1)
					{
					GameObject t = (GameObject)Instantiate(turret,lastHit.transform.position,Quaternion.Euler(-90,0,0));
					lastHit.tag = "Full";
					m-=2;
					other.money = m;
					}
					if(towernum ==2)
					{
					GameObject t = (GameObject)Instantiate(turret2,lastHit.transform.position,Quaternion.Euler(-90,0,0));
					lastHit.tag = "Full";
					m-=4;
					other.money = m;
					}
				}
			}
		}
		if(Input.GetKeyDown(KeyCode.B))
		{
			buildMode = !buildMode;
		}
		if(Input.GetKeyDown(KeyCode.Alpha1))
		{
			towernum = 1;
		}
		if(Input.GetKeyDown(KeyCode.Alpha2))
		{
			towernum = 2;
		}
	
	}
}
