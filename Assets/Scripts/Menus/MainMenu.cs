using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public UtilitiesMainMenu utils;
    public void PlayButton()
    {
        Application.LoadLevel("GAME");
    }
    public void BackToMainMenu()
    {
        Application.LoadLevel("MAINMENU");
    }
}
