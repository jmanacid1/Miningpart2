using UnityEngine;
using System.Collections;
public class script : MonoBehaviour {
	public GameObject cube;
	public bool spawned = false; 
	// Use this for initialization
	void Start () {
	
	}
	void spawnCube () {
		Instantiate(cube,new Vector3(0,0,0),Quaternion.identity);  
	} 
	// Update is called once per frame
	void Update () {
		if (Time.time >3 && spawned == false){
			spawned = true;
			spawnCube();
		}
	
	}
}
