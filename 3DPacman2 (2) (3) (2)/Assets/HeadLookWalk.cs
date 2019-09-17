using UnityEngine;
using System.Collections;

public class HeadLookWalk : MonoBehaviour
{
    public float velocity = 0.7f;
    public bool isWalking;
    private Camera camera;
    private CharacterController controller;
    private AudioSource footsteps;
    private GameObject head;
    private GameObject body;
    private bool walking;
	    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector3 moveDirection = Camera.main.transform.forward;
        moveDirection *= velocity * Time.deltaTime;
        moveDirection.y = 0.0f;
        controller.SimpleMove(Camera.main.transform.forward * velocity);

    }
	void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.tag == "Coin")
		{
			GetComponent<AudioSource> ().Play ();
		}
	}
}
