using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class OnclickFunction : MonoBehaviour {

	public Button tonBouton;
	public Animator animator;
	public string nomBool;
	public string nomBool2;
	public bool value;

	public bool isButtonLeft;

	// Use this for initialization
	void Start () {
		tonBouton.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		int state = animator.GetInteger ("State");

		if (!isButtonLeft) {
			if (state == -1) {
				allInFalse ();
				animator.SetBool (nomBool, true);
				animator.SetInteger ("State", 0);
			} else if (state == 0) {
				allInFalse ();
				animator.SetBool (nomBool2, true);
				animator.SetInteger ("State", 1);
			}
		} else if (isButtonLeft) {
			if (state == 1) {
				allInFalse ();
				animator.SetBool (nomBool, true);
				animator.SetInteger ("State", 0);
			} else if (state == 0) {
				allInFalse ();
				animator.SetBool (nomBool2, true);
				animator.SetInteger ("State", -1);
			}
		}

	}

	void allInFalse(){
		animator.SetBool ("MiddleToLeft", false);
		animator.SetBool ("MiddleToRight", false);
		animator.SetBool ("LeftToMiddle", false);
		animator.SetBool ("RightToMiddle", false);
	}

}
