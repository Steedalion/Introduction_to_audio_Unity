using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timeout : MonoBehaviour
{
	public float timer = 10f;
	public GameObject[] enableObjs;
	public Rigidbody[] bodies;
    // Start is called before the first frame update
    void Start()
    {
	    Invoke("EnableAll", timer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
	void EnableAll()
	{
		if (enableObjs == null)
		{
			return;
		}
		foreach (GameObject item in enableObjs)
		{
			item.SetActive(true);
		}
	}
	
	void MoveAll()
	{
		if (bodies == null)
		{
			return;
		}
		foreach (Rigidbody item in bodies)
		{
			item.velocity = new Vector3(0,1,4);
		}
	}
}
