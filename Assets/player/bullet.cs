using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]
    private float speed;
    [SerializeField]
    private GameObject kunight;
    Enermy[] enermies;
    bool usedToControll;
    player player;
    Enermy zoombieTarget;
    // Start is called before the first frame update
    private void Awake() {
       Destroy(gameObject,3);
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        // khơi tạo danh sách
        enermies = GameObject.FindObjectsOfType<Enermy>();
        if (enermies.Length > 0 )
        {
            float distanceToClosetEnermy = Mathf.Infinity;
            Enermy ClosetEnermy = null;
            foreach(Enermy currentEnermy in enermies)
            {
                    float distanceCurrrent = Vector2.Distance(currentEnermy.transform.position,transform.position);
                    if (distanceToClosetEnermy > distanceCurrrent && currentEnermy.Istarget != true )
                    {
                       
                        distanceToClosetEnermy = distanceCurrrent;
                        ClosetEnermy = currentEnermy;

                         
                    }       
               
            }
            if (ClosetEnermy != null)
            {
               if (ClosetEnermy.gameObject != null)
               {
                    
                        Vector2 direction =(ClosetEnermy.transform.position - transform.position).normalized;
                        
                        transform.Translate(direction*speed*Time.deltaTime);
                     
                        
               }
            }
            else{ 
                    ClosetEnermy = null;
                    rb.velocity=transform.right*speed;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        Enermy enermy =other.GetComponent<Enermy>();
        if (enermy != null)
        {
            Debug.Log("bullet");
            enermy.Istarget=true;
            enermy.Takedamge(10);
           
            
            
        }
        //Instantiate(gameObject,transform.position,transform.rotation);
        Destroy(gameObject);
        
        
    }
    
}
