using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Privated Variables
    [SerializeField] private float speed = 20.0f;
    [SerializeField] private float turnSpeed = 20.0f;
    [SerializeField] private float horizontalInput;
    [SerializeField] private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // This is where we get player inputs
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the vehicle forward based in Vertical Input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // Rotate the vehicle forward based in Horizontal Input
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime *  horizontalInput);
    }
}
