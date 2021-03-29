using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipePairBehavior : MonoBehaviour
{
    public float Speed = 1;
    public float DistanceBetweenPipes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-Speed, 0, 0) * Time.deltaTime;
    }
}
