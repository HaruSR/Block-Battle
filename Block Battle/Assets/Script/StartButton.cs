using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public GameObject Title_Screen;
    public GameObject Game_Screen;

    void Awake() {
    }

    public void SwitchScreen() {
        Game_Screen.SetActive(true);
        Title_Screen.SetActive(false);
    }
}
