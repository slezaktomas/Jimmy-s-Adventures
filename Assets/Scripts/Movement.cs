using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    AudioSource jumpsound;
    Rigidbody2D rb;
    public float Speed;
    public float jumpForce = 0.0f; 
    public LayerMask groundLayer; 
    public PhysicsMaterial2D bounceMaterial, commonMaterial;
    public Image image;
    public Sprite newSprite;
    public Sprite originalSprite;
    private bool spriteNew;
    public Animator animator;
    public static int jumps = 0;
    BoxCollider2D bc;



    //Start je volán pøed první aktualizací snímku
    void Start() 
    {
        jumpsound = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
        bc = GetComponent<BoxCollider2D>();
    }

    //Update se volá jednou za snímek
    void FixedUpdate() 
    {
        Move(); 
        Jump();  
        Flip();
        CheckIfGrounded();
    }

    void Move() // Metoda pro pohyb
    {
        float x = Input.GetAxisRaw("Horizontal"); 
        if (jumpForce == 0.0f && CheckIfGrounded()) // Pokud se síla skoku rovná nula a zároveò je postava na zemi, tak se nastaví rychlost pohybu a dá se s postavou pohybovat
        {
            Speed = 5f;
            var move = x * Speed;
            animator.SetFloat("speed", Mathf.Abs(move));
            rb.velocity = new Vector2(move, rb.velocity.y); 
        }




    }
    void Jump() // Metoda pro skok
    {

        animator.SetBool("isCrouching", false);
        float x = Input.GetAxisRaw("Horizontal");

        if (Input.GetKey(KeyCode.Space) && CheckIfGrounded()) // Pokud držíme mezerník a zároveò je postava na zemi, tak se pøièítá síla skoku, nastaví se jiná animace a nastaví se jiný materiál
        {
            jumpForce += 1f;
            animator.SetBool("isCrouching", true);
            rb.velocity = new Vector2(0.0f, rb.velocity.y);
            rb.sharedMaterial = bounceMaterial;
        }

        if (Input.GetKeyUp(KeyCode.Space)) // Pokud pustíme mezerník, tak se pøiète poèet skokù
        {
            jumps += 1;


            if (CheckIfGrounded()) // Pokud je postava na zemi, tak lze s postavou skákat. Také se resetuje skok a nastaví se jiná animace
            {

                rb.velocity = new Vector2(x * 8, jumpForce);
                Invoke("ResetJump", 0.2f);
                animator.SetBool("isJumping", false);

            }


        }
        if (jumpForce >= 11.5f && CheckIfGrounded()) // Pokud je síla skoku vìtší nebo rovno 11,5 a zároveò je postava na zemi, tak postava automaticky vyskoèí, skok se resetuje a nastaví se jiná animace
        {
            rb.velocity = new Vector2(x * 8, jumpForce);
            Invoke("ResetJump", 0.2f);
            animator.SetBool("isJumping", true);
        }
        if (rb.velocity.y <= -1){
            rb.sharedMaterial = commonMaterial;
        }


 
        if (CheckIfGrounded() == true) // Pokud je postava an zemi, tak se nastaví jiná animace
        {
            animator.SetBool("isJumping", false);
        }
        else // Pokud není postava na zemi, tak se nastaví jiná animace
        {
            animator.SetBool("isJumping", true);
        }
        if (Input.GetKeyUp(KeyCode.Space)) // Pokud pustíme mezerník, tak se spustí zvuk
        {
            jumpsound.Play();
        }

    }

    void ResetJump() // Metoda pro reset skoku
    {
        
        jumpForce = 0.0f;
    }

    private bool CheckIfGrounded()  // Metoda pro zkontrolování, jetsli je postava na zemi
    {
        float extraHeightText = 0.02f;
        RaycastHit2D raycastHit = Physics2D.BoxCast(bc.bounds.center, bc.bounds.size,0f,Vector2.down, extraHeightText, groundLayer); 
        return raycastHit.collider;
    }
    void Flip() // Metoda pro otoèení postavy (doleva èi doprava)
    {
        float x = Input.GetAxisRaw("Horizontal");
        if (x > 0) // Pokud jdeme doprava, tak se obrázek postavy otoèí doprava
        {
            gameObject.transform.localScale = new Vector2(0.3f, 0.3f);
        }
        if (x < 0) // Pokud jdeme doleva, tak se obrázek postavy otoèí doleva
        {
            gameObject.transform.localScale = new Vector2(-0.3f, 0.3f);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) // Metoda pro trigger
    {
        if (other.CompareTag("Finish")) // Pokud vejdeme s postavou do box collideru s tagem finish tak se naète scéna ukonèovací obrazovky
        {
            Timer.finished = true;
            SceneManager.LoadScene(3);

        }
    }

}