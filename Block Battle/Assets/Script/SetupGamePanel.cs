using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupGamePanel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        iTween.ScaleFrom(gameObject,iTween.Hash("x",0,"y",0,"time",1));
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
