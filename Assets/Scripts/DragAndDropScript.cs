using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDropScript : MonoBehaviour,IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler {

	// Velkamajam objektam piestiprinata komponente
	private CanvasGroup kanvasGrupa;
	private RectTransform velkObjRectTransf;
	public Objekti objektuSkripts;

	void start () {
		kanvasGrupa = GetComponent<CanvasGroup> ();
		velkObjRectTransf = GetComponent<RectTransform> ();
	}

	public void OnPointerDown(PointerEventData notikums){
		Debug.Log ("Uzkliksinats uz velkama objekta!");
	}

	public void OnBeginDrag(PointerEventData notikums){
		Debug.Log ("Uzsakta vilksana!");
		//Opacity
		kanvasGrupa.alpha = 0.6f;
		//raycast rays
		kanvasGrupa.blocksRaycasts = false;
	}

	public void OnDrag(PointerEventData notikums){
		Debug.Log ("Notiek vilksana!");
		velkObjRectTransf.anchoredPosition += notikums.delta / objektuSkripts.kanva.scaleFactor;
	}

	public void OnEndDrag(PointerEventData notikums){
		Debug.Log ("Beikta vilksana!");
		//Opacity
		kanvasGrupa.alpha = 0.6f;
		//raycast rays
		kanvasGrupa.blocksRaycasts = false;
	}
}
