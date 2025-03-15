using UnityEngine;
using UnityEngine.Rendering;

public class Rotate : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 angularV, torque;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.angularVelocity = angularV;
        }
        else if (Input.GetMouseButtonDown(1)) 
        { 
            rb.AddTorque(torque);
        }
        else if (Input.GetKeyDown(KeyCode.Space) )
            { rb.angularVelocity = Vector3.zero; }

    }
}
