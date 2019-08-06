using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExchangeImage : MonoBehaviour
{
    public Vector3 scale;
    public float Speed = 1f;
    float changeTime = 0;
    public Sprite Image1;
    public Sprite Image2;
    private Vector2 currrentSize;
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Image>().sprite = Image1;
        currrentSize = gameObject.transform.localScale; 
       
    }

    // Update is called once per frame
    void Update()
    {
        changeTime += Time.deltaTime;
        gameObject.transform.position =new Vector2(gameObject.transform.position.x - (Time.deltaTime * Speed),gameObject.transform.position.y);
        if(gameObject.transform.position.x < -200f)gameObject.transform.position = new Vector2(150f,gameObject.transform.position.y);
        if(changeTime < 0.5){
            gameObject.GetComponent<Image>().sprite = Image1;
            gameObject.transform.localScale = currrentSize;
            return;
        }
        else if(changeTime >= 0.5 && changeTime < 1){
            gameObject.GetComponent<Image>().sprite = Image2;
            gameObject.transform.localScale =  new Vector3(scale.x, scale.y, scale.z);
           return;
        }
            changeTime = 0;
            return;

    }
}
