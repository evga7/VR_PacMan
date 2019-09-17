using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class AIghost : MonoBehaviour {
	public static AIghost instance;
    public GameObject target;
	public int flag;
    private NavMeshAgent agent;
	float timeSpan;
	float checkTime;
    // Use this for initialization
	void Awake()
	{
		instance = this;
		flag = 0;
		timeSpan = 0.0f;
		checkTime = 5.0f;
	}
    void Start () {
        agent = GetComponent<NavMeshAgent>();
        if (target==null)
        {
            target = GameObject.FindGameObjectWithTag("Player");
        }
	}

	// Update is called once per frame
	void Update () {
		if (flag == 0)
			run ();
		else 
		{
			stop ();
		}
			
	}

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(3);
        }
    }
	public void set_flag()
	{
		this.flag = 1;
	}
	public void run()
	{
		this.agent.destination = target.transform.position;
	}
	public void stop()
	{
		timeSpan += Time.deltaTime;
		if (timeSpan < checkTime) {
			Debug.Log (timeSpan);
			this.agent.Stop ();
		} else {
			flag = 0;
			timeSpan = 0.0f;
			checkTime = 5.0f;
			this.agent.Resume ();
		}
	}
}
	