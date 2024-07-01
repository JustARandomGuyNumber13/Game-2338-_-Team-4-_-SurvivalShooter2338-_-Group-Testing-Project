using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject settingsMenu;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    public void ResumeGame() // called when resume button is clicked
    {
        SceneManager.UnloadSceneAsync("Pause");
    }

    public void OpenSettings() // called when settings button is clicked
    {
        settingsMenu.SetActive(true);
    }

    public void QuitGame() // called when quit button is clicked
    {
        Application.Quit();
    }

    private void OnDestroy() // called when unpaused
    {
        Time.timeScale = 1;
    }
    public void ReturnToTitle()////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    {
        if (GameObject.Find("BackgroundMusic") != null)
            DestroyImmediate(GameObject.Find("BackgroundMusic"));
        SceneManager.LoadScene(0);
    }
}
