using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehavior : MonoBehaviour
{
    public float Speed = 1.0f;
    Vector3 velocity = new Vector3( 0, 0, 0 );
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Old Player Moevement Behavior
        int forward = Int(Input.GetKeyDown("w")) - Int(Input.GetKeyDown("s"));
        int side = Int(Input.GetKeyDown("d")) - Int(Input.GetKeyDown("a"));
        velocity += ((transform.forward * forward) + (new Vector3(transform.forward.z, transform.forward.y, transform.forward.x) * side)) * Time.deltaTime;
        int jump = Int(Input.GetKeyDown("space"));
        velocity.y += jump;
        transform.position += velocity;
    }

    int Int(bool Bool)
    {
        if (Bool == true)
            return 1;
        return 0;
    }
}
