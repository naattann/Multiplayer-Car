using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarApperance : MonoBehaviour
{
    public string playerName;
    public Color carColor;
    public Text nameText;
    public Renderer carRenderer;
    public int playerNumber;

    void Start()
    {
        if(playerNumber == 0)
        {
                playerName = PlayerPrefs.GetString("PlayerName");
                carColor = ColorCar.IntToColor(PlayerPrefs.GetInt("Red"),PlayerPrefs.GetInt("Green"),PlayerPrefs.GetInt("Blue"));
        }
        else
        {
            playerName = "Random" + playerNumber;
            carColor = new Color(Random.Range(0,255)/255,Random.Range(0,255)/255,Random.Range(0,255)/255);
        }


        nameText.text = playerName;
        carRenderer.material.color = carColor;
        nameText.color = carColor;
    }
}
