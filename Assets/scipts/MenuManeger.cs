using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManeger : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("fase1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
