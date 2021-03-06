using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller;
	public Animator animator;

	public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;
    //bool dash = false;

    //bool dashAxis = false;

    // Update is called once per frame
    void Update () {

		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

		if (Input.GetKeyDown(KeyCode.Space))
		{
			jump = true;
		}
        else if (Input.GetKeyDown(KeyCode.E))
        {
            Cursor.visible = true;
            SceneManager.LoadScene(1);
        }
        //if (Input.GetKeyDown(KeyCode.C))
        //{
        //    dash = true;
        //}

        //if (Input.GetAxisRaw("Dash") == 1 || Input.GetAxisRaw("Dash") == -1) //RT in Unity 2017 = -1, RT in Unity 2019 = 1
        //{
        //    if (dashAxis == false)
        //    {
        //        dashAxis = true;
        //        dash = true;
        //    }
        //}
        //else
        //{
        //    dashAxis = false;
        //}


    }

    public void OnFall()
	{
		animator.SetBool("IsJumping", true);
	}

	public void OnLanding()
	{
		animator.SetBool("IsJumping", false);
	}

	void FixedUpdate ()
	{
        // Move our character
        //controller.Move(horizontalMove * Time.fixedDeltaTime, jump, dash);
        controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
        jump = false;
        //dash = false;
    }
}
