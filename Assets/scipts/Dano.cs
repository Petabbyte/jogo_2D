using UnityEngine;
using UnityEngine.SceneManagement;

public class Dano : MonoBehaviour
{
    
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Dano"))
        {
            SceneManager.LoadScene(1);
        }
    }

}
