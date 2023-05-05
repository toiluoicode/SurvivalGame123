using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnermy : MonoBehaviour
{
    public Transform PointCreateEnermy;
    public GameObject zoombie;
    public float timeCreate;
    public bool  timeCreateTrue;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer=timeCreate;
    }

    // Update is called once per frame
    void Update()
    {
        timer -=Time.deltaTime;
        if (timer < 0 ){
            Instantiate(zoombie,PointCreateEnermy.position,transform.rotation);
            timer=timeCreate;
        }
    }
}
