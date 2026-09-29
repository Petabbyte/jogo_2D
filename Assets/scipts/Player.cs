using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;

    private bool isGrounded = false;
    
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();  
    }

    
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); // vai reconhecer o movimento horizontal

        rb.linearVelocity = new Vector2(moveHorizontal * speed, rb.linearVelocity.y); // vai aplicar a velocidade horizontal 

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) // com o "isgrounded" na condição do if agora o player so vai pular quando a tecla space tiver precionada e quando o pleyer estiver no chao
        {
            rb.AddForce(new Vector2(0f ,5f), ForceMode2D.Impulse); 
        }
    }

    void OnCollisionEnter2D( Collision2D collision) 
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true; //vai reconhecer quando o jogador estiver encostando no chao
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false; //vai reconhecer quando o jogador deixar de encostar no chao
        }
    }
}
