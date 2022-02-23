using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DrebjuKustinasana : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler {

	private RectTransform transformacijasLogs;
	public Canvas kanva;

	void Start () {
		transformacijasLogs = GetComponent<RectTransform>();
	}

	public void OnPointerDown(PointerEventData notikums){
		Debug.Log ("Kreisais Klikśķis uz objektu");
	}

	public void OnBeginDrag(PointerEventData notikums){
		Debug.Log ("uzskatsa objekta vilkśana");
	}

	public void OnDrag(PointerEventData notikums){
		transformacijasLogs.anchoredPosition += notikums.delta / kanva.scaleFactor;
	}

	public void OnEndDrag(PointerEventData notikums){
		Debug.Log (" objekta vilkśana partraukta");
	}
}
