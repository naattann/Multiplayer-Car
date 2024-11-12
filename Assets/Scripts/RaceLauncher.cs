using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class RaceLauncher : MonoBehaviour
{
    public TMP_InputField playerName;
   
    void Start()
    {
        if(PlayerPrefs.HasKey("PlayerName"))
        {
            playerName.text = PlayerPrefs.GetString("PlayerName");
        }
    }
    public void SetName(string name)
    {
        PlayerPrefs.SetString("PlayerName",name);
    }
    public void StartTrial()
    {
        SceneManager.LoadScene(0);
    }
}
