using UnityEngine;
using System.Collections;

public class S_Money : MonoBehaviour {
	public int money = 2;
	public GUIText score;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		score.text = "" + money;
	
	}
}
