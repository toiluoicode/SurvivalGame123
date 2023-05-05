using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCircleZoom : MonoBehaviour
{
    public Transform PlayerTransform;
    public GameObject EnemyPerhap;
    [SerializeField]
    float radius ;
    [SerializeField]
    int numEnemy;
    // Start is called before the first frame update
    void Start()
    {
        RandomZoom();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void RandomZoom()
    {
        float angleStep =360/numEnemy;
        Vector2 origin = PlayerTransform.position;
        for (int i= 0 ; i < numEnemy; i++)
        {
            float angle = i * angleStep;
            float x = origin.x + Mathf.Sin(angle * Mathf.Deg2Rad) * radius;
            float y = origin.y + Mathf.Cos(angle * Mathf.Deg2Rad) * radius;
            Vector3 position = new Vector3(x, y, 0f);
            GameObject enemy = Instantiate(EnemyPerhap, position, Quaternion.identity);
        }
    }
}
