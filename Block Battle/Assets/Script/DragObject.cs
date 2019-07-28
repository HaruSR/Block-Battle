using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

///<summary>
///ドラッグでGameObjectを操作させるオブジェクト
///操作対象のGameObjectにこのスクリプトをアタッチ
///<summary>
public class DragObject : MonoBehaviour, IDragHandler
{
    public RectTransform m_rectTransform = null;
    
    private void Reset()
    {
        m_rectTransform = GetComponent<RectTransform>();
    }
    
    public void OnDrag( PointerEventData e )
    {
        m_rectTransform.position += new Vector3( e.delta.x, e.delta.y, 0f );
    }
}

