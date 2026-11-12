using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScene : MonoBehaviour
{
    public GameObject painelPause;
    public GameObject painelGameOver;

    bool pausado = false;
    bool JogoAcabou = false;


    void Start()
    {
        painelPause.SetActive(false);
        painelGameOver.SetActive(false);
    } 

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            if(pausado)
            {
                Continuar();
            }
            else
            {
                Pausar();
            }
        }
    }

    public void Pausar()
    {
        if (JogoAcabou == false)
        {
            pausado = true;
            painelPause.SetActive (true);
            Time.timeScale = 0f;
        }
    }

    public void Continuar()
    {
        pausado = false;
        painelPause.SetActive(false);
        Time.timeScale = 1f;
    }

    public void MostrarGameOver()
    {
        JogoAcabou = true;
        painelGameOver.SetActive (true);
        Time.timeScale = 0f;
    }

    public void Reiniciar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    
    }

    public void VoltarMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }
   
    
}
