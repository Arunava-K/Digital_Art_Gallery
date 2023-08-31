using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS_Controller : MonoBehaviour
{
    public CharacterController characterController;

    private void Awake() 
    {
        if(gameObject.GetComponent<CharacterController>())
        {
            characterController = gameObject.GetComponent<CharacterController>();
            Debug.Log("Character Controller Found");
        }
        else 
        {
            characterController = gameObject.AddComponent<CharacterController>();
            Debug.Log("Character Controller Not Found.....Adding the component!");
        }
    }

    [Header("Movement Settings")]
    public float movementSpeed = 5f;
    public float rotationSpeed = 10f;
    public float jumpSpeed = 5f;
    public float gravity = 9.81f;
    private Vector3 moveDirection;
    private float verticalVelocity;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        // Check for grounded state
        bool isGrounded = characterController.isGrounded;

        // Calculate movement direction based on input
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 inputDirection = new Vector3(horizontalInput, 0f, verticalInput);
        Vector3 rotatedDirection = transform.TransformDirection(inputDirection);
        moveDirection = rotatedDirection * movementSpeed;

        // Apply gravity
        if (isGrounded)
        {
            verticalVelocity = -gravity * Time.deltaTime;

            // Jumping
            if (Input.GetButtonDown("Jump"))
            {
                verticalVelocity = jumpSpeed;
            }
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }

        moveDirection.y = verticalVelocity;

        // Move the character controller
        characterController.Move(moveDirection * Time.deltaTime);

        // Rotate the player based on mouse movement
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        Vector3 currentRotation = transform.localEulerAngles;
        transform.localRotation = Quaternion.Euler(currentRotation.x, currentRotation.y + mouseX, currentRotation.z);
    }
}
