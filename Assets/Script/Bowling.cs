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
    }

    private void Shootball()
    {
        rb.AddForce(Vector3.forward * forcePower, ForceMode.Impulse);  //พวกที่เป็น x z y คือพวก forward up down
    }
}
