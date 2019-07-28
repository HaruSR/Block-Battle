using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public GameObject Title_Screen;
    public GameObject Game_Screen;

    void Awake() {
        Debug.Log("a");
        GameObject buttonA = GameObject.Find("Tile_User_Name/Button");
        buttonA.SetActive(false);
        this.gameObject.GetComponent<Button>().transform.position = new Vector3(this.gameObject.GetComponent<Button>().transform.position.x + 30,this.gameObject.GetComponent<Button>().transform.position.y,0);

    }

    public void SwitchScreen() {
        Game_Screen.SetActive(true);
        Title_Screen.SetActive(false);
    }
}
