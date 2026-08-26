using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Bowling : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    private int forcePower;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.isPressed)
            Shootball();

        if (Keyboard.current.rightArrowKey.isPressed 
            || Keyboard.current.dKey.isPressed)
            MoveRight();

        if (Keyboard.current.leftArrowKey.isPressed
            || Keyboard.current.aKey.isPressed)
            MoveLeft();
    }

    public void Shootball()
    {
        rb.AddForce(Vector3.forward * forcePower, ForceMode.Impulse);  //พวกที่เป็น x z y คือพวก forward up down
    }

    private void MoveRight()
    {
        transform.position += new Vector3(0.5f, 0f, 0f) * Time.deltaTime;
    }

    private void MoveLeft()
    {
        transform.position += new Vector3(-0.5f, 0f, 0f) * Time.deltaTime;
    }
}
