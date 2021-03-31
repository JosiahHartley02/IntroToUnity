using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehavior : MonoBehaviour
{
    public float Speed = 2.0f;
    public float YMin = -5;
    public float YMax = 4;
    // Start is called before the first frame update
    void Start()
    {
        float yPos = Random.Range(YMin,YMax);
        transform.position = new Vector3(transform.position.x, yPos, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        float random = Random.Range(YMin, YMax);
        transform.position -= new Vector3(Speed, 0, 0) * Time.deltaTime;
        transform.position += Vector3.Lerp((new Vector3(transform.position.x, random, transform.position.z) * Time.deltaTime), (new Vector3(transform.position.x, random, transform.position.z) * Time.deltaTime),(Mathf.Cos(Time.time) / 2 + 0.5f) * Time.deltaTime);
    }
}
