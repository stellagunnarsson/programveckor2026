using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuController : MonoBehaviour
{
    public void OnStartClick()
    {
        SceneManager.LoadScene("StartScen");
    }

    public void OnExitClick()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }

    public void OnControlsClick()
    {
        SceneManager.LoadScene("Controls");
    }

    public void OnCreditsClick()
    {
        SceneManager.LoadScene("Credits");
    }


}
