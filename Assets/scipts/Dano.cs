using UnityEngine;
using UnityEngine.SceneManagement;

public class Dano : MonoBehaviour
{
    public MenuScene menu;
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Dano"))
        {
            menu.MostrarGameOver();
        }
    }

}
