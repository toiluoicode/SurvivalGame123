using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnermyMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float speed;
    public GameObject player;
    bool flip;
    public Transform target;
    [SerializeField] Rigidbody2D rb;
    void Start()
    {
       target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
     if (target != null)
        {

                Vector2 direction = (target.position - transform.position).normalized;
                rb.velocity = direction * speed;
                Flip();
        }
    }
     void Flip (){
      Vector3 scale = transform.localScale;
   
       if (player.transform.position.x > transform.position.x){
        scale.x = Mathf.Abs(scale.x) * (-1) * (flip ? 1: -1);
        /// ham abs để lấy giá trị tuyệt đối
       
       }
       else
       {
         scale.x = Mathf.Abs(scale.x) * (1)*(flip ? 1: -1);
        
       }
       transform.localScale=scale;
    }

    
  
}
