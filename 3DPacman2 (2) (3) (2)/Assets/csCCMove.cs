
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csCCMove : MonoBehaviour
{
    /*
		캐릭터 컨트롤러의 기능을 사용하려면 전용 함수를 이용하여 구현해야 한다. 
	 */
    public float movSpeed = 5.0f;
    public float rotSpeed = 120.0f;

    CharacterController controller; // 캐릭터 컨트롤러 변수 선언
    Vector3 moveDirection;

    float jumpSpeed = 10.0f;
    float gravity = 20.0f;


    // Use this for initialization
    void Start()
    {
        controller = GetComponent<CharacterController>();   // 게임 오브젝트에서 캐릭터 컨트롤러 컴포넌트를 가져와 변수에 담는다.(캡슐)
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.isGrounded)  // 캐릭터 컨트롤러가 지면에 붙어있을때만 동작 수행 
        {
            float amtRot = rotSpeed * Time.deltaTime;
            float ver = Input.GetAxis("Vertical");
            float ang = Input.GetAxis("Horizontal");

            transform.Rotate(Vector3.up * ang * amtRot);    // 회전

            moveDirection = new Vector3(0, 0, ver * movSpeed);  // 앞,뒤로만 이동하므로 Z축의 값을 보정한 값으로 만든다.
            moveDirection = transform.TransformDirection(moveDirection);    // 현재 위치 벡타값을 월드 좌표계 기준의 위치 벡터값으로 구한다.

            if (Input.GetButton("Jump"))    // 캐릭터 컨트롤러가 지면에 붙어있을 때만 스페이스바의 입력을 감지해 점프할수 있게 한다.
                moveDirection.y = jumpSpeed;    // 점프할수 있게 이동방향을 Y축으로만 설정
        }

        moveDirection.y -= gravity * Time.deltaTime;
        /*
			캐릭터 컨트롤러를 포함한 게임 오브젝트를 이동시키려면 Move함수를 사용하고 트랜스폼의 위치값을 직접 변경하지 않는다.
			Move 함수는 캐릭터 컨트롤러의 이동방향과 거리를 결정하고 캐릭터 컨트롤러에게 이동방향과 거리를 알려주는데, 이동방향과 거리가 올바르면 이동한다.
			즉, 장애물이 없므면 이동하고, Slope Limit을 초과하지 않으면 이동하며, Slope Limit을 초과하면 이동하지 않는다.
 
			transform.TransformDirection(Vector3)
			TransformDirection 함수는 인자 Vector3를 월드 좌표계 기준으로 변환한 벡터를 반환한다.
			로컬 좌표계 기준으로 정의된 방향 벡터 -> 월드 좌표계 기준으로 정의된 방향 벡터
		 */
        controller.Move(moveDirection * Time.deltaTime);
    }
}