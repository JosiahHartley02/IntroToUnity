using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlapBehavior : MonoBehaviour
{
    public float FlapForce = 1;
    public float MaxFallSpeed = 1;
    private Rigidbody _rigidbody;
    public GameObject child;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
            Destroy(gameObject);

        child.transform.parent = transform; 
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Flap"))
        {
            _rigidbody.AddForce(new Vector3(0, FlapForce, 0), ForceMode.Impulse);
            transform.Rotate(new Vector3(30,0,0), 30 * Time.deltaTime);
        }

        if (_rigidbody.velocity.y < -MaxFallSpeed)
        {
            _rigidbody.velocity = new Vector3(0, -MaxFallSpeed, 0);
            transform.Rotate(new Vector3(0, 30, 0), 30 * Time.deltaTime);
        }
        else if (_rigidbody.velocity.y > MaxFallSpeed)
        {
            _rigidbody.velocity = new Vector3(0, MaxFallSpeed, 0);
            transform.Rotate(new Vector3(0, 30, 0), 30 * Time.deltaTime);
        }

        if (transform.position.x > 0)
        {
            transform.position += new Vector3(-1, 0, 0) * Time.deltaTime;
            transform.Rotate(new Vector3(0, 0, 30), 30 * Time.deltaTime);
        }
        else if (transform.position.x < 0)
        {
            transform.position += new Vector3(1, 0, 0) * Time.deltaTime;
            transform.Rotate(new Vector3(0, 0, 30), 30 * Time.deltaTime);
        }
    }
}
