using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {

	// Update is called once per frame
	void Start()
	{
		GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / 20f;
	}
	
	void Update () 
	{
		if (transform.position.y < -3f)
		{
			Destroy(gameObject);
		}
	}
}
