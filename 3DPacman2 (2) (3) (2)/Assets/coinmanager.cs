using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinmanager : MonoBehaviour
{
    public static coinmanager instance; //어디서나 접근할 수 있도록 static(정적)으로 자기 자신을 저장할 변수를 만듭니다.
    public Text scoreTxt1;
	public Text scoreTxt2;
	public Text scoreTxt3;
	public Text scoreTxt4;
	public int m_score; //점수를 관리합니다.
	public int bonus;
	float timeSpan;
	float checkTime;
	public int flag;
	void Awake()
	{
		flag = 0;
		bonus = 1;
		m_score = 0;
		timeSpan = 0.0f;
		checkTime = 5.0f;
		instance = this;
	}
    public void AddScore(int num) //점수를 추가해주는 함수를 만들어 줍니다.
    {
		m_score += bonus*num; //점수를 더해줍니다.
        scoreTxt1.text = "Score : " + m_score;
		scoreTxt2.text = "Score : " + m_score;
		scoreTxt3.text = "Score : " + m_score; 
		scoreTxt4.text = "Score : " + m_score;
    }

    void Start()
    {

    }
	public void Bonus()
	{
		this.bonus = 2;
		timeSpan += Time.deltaTime;
		if (timeSpan < checkTime) {
		} else {
			bonus = 1;
			timeSpan = 0.0f;
			checkTime = 10.0f;
			flag = 0;
		}
	}
    void Update()
    {
		if (flag == 1)
			Bonus ();
    }
}