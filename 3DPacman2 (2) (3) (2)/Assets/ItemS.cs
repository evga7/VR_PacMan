using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemS : MonoBehaviour {

	void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.tag == "Player")
		{
			AIghost.instance.set_flag ();
			Destroy(gameObject);
		}
	}
}
