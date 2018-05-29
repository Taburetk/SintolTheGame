using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Animations;

public class ShopLogic : MonoBehaviour, IPointerDownHandler, IPointerClickHandler, IPointerUpHandler{
	Animator a;
	[SerializeField] Text text;
	
	void Start() {
		a = gameObject.GetComponent<Animator>();
	}

	public void OnPointerDown (PointerEventData ped) {
		a.SetBool("isPressed", true);
	}
	public void OnPointerClick(PointerEventData ped) {
		Debug.Log("You have pressed on this button");
	}

	public void OnPointerUp(PointerEventData ped) {
		a.SetBool("isPressed", false);
	}
}
