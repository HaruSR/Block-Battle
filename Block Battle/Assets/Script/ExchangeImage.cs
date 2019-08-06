using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExchangeImage : MonoBehaviour
{
    float changeTime;
        public Sprite Image1;
        public Sprite Image2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        changeTime += Time.deltaTime;

        if(changeTime < 0.5){
            gameObject.GetComponent<Image>().sprite = Image1;
            return;
        }
        else if(changeTime >= 0.5 && changeTime < 1){
            gameObject.GetComponent<Image>().sprite = Image2;
           return;
        }
            changeTime = 0;
            return;

    }
}
