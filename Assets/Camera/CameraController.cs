using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
   public Transform player;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate() {
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
