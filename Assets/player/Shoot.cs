using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform ShootingPoint;
    public GameObject KunitPrefab;
    public  bool IsShooting;
    public float timeShooting = 0.05f;
    float timer;
    Enermy[] enermies;
    void Start()
    {
        timer=timeShooting;
    }

    // Update is called once per frame
    void Update()
    {
        enermies = GameObject.FindObjectsOfType<Enermy>();
        if (enermies.Length > 0)
        {
            timer -= Time.deltaTime;
            if (timer < 0 )
            {
                Instantiate(KunitPrefab,ShootingPoint.position,transform.rotation);
                timer=timeShooting;
            }
        }
    }
    
}
