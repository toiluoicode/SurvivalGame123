using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enermy : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool Istarget=false;
    [SerializeField] public GameObject redPartcles;
    public float health = 20;
    public void Takedamge (float damge)
    {
         Debug.Log("Health 1: "+health);
        Debug.Log("Vao Day:");
        health -= damge;
        Debug.Log("Health 2" +health);
        if (health <= 0)
        {
            //Instantiate(redPartcles,transform.position,transform.rotation);
            Destroy(gameObject);
            Debug.Log("da huy zoombie");
        }
        else{
            Istarget=false;
        }
        
           
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
