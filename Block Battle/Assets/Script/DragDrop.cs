using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
 
public class DragDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler{
	Transform TargetGUI;
	public void OnBeginDrag(PointerEventData eventData)
	{
		TargetGUI = searchGUI(eventData.pointerPressRaycast.gameObject.transform);
	}
 
	public void OnDrag(PointerEventData eventData)
	{
		//eventData.lastPress.transform.position = eventData.position;
		if(TargetGUI != null)
		{
			TargetGUI.position = eventData.position;
		}
	}
 
	public void OnEndDrag(PointerEventData eventData)
	{
 
	}
 
	private Transform searchGUI(Transform P_transform){
		if(P_transform.gameObject.CompareTag("GUI")){
			return P_transform;
		}
		if(P_transform == P_transform.root){
			return null;
		}
		return searchGUI(P_transform.parent);
	}
 
}