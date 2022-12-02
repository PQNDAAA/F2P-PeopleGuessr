using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void PlayButton()
    {
        Application.LoadLevel("GAME");
    }
    public void BackToMainMenu()
    {
        Application.LoadLevel("MAINMENU");
    }
}
