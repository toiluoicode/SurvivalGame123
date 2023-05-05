using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    private float horizontal;
    private Animator animator;
    private float vertical;
    [SerializeField]private float speed = 4.0f;
    public bool isFacingRight = true;
    private float  health = 10f;
    void Start()
    {
            animator = GetComponent<Animator>();

    }
    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        
        Vector2 position = transform.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;
        transform.position = position;
        HandleRunAnimation();
        Flip();
        GameOver();
    }
    void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            transform.Rotate(0.0f,-180f,0.0f);
        }
    }
    void HandleRunAnimation ()
    {
        if (Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            animator.SetBool("IsRuning",true);
        }
        else
        {
            animator.SetBool("IsRuning",false);
        }

    }
    void GameOver (){
        if (health < 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    
}
