using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float moveSpeed = 5;
    public float turnSpeed = 10;
    private float horizontalInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        Debug.Log(horizontalInput);
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = Vector3.forward * moveSpeed + new Vector3(horizontalInput * turnSpeed,rb.linearVelocity.y,0) ;
    }
}
