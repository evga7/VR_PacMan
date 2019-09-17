using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item2 : MonoBehaviour {
	void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.tag == "Player")
		{
			coinmanager.instance.flag = 1;
			Destroy(gameObject);
		}
	}
}
