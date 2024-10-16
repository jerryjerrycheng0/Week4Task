using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDevWithMarco.Player
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float movementSpeed;
        private Rigidbody rb;
        private Vector3 movemenInput;
        private Camera cam;
        [SerializeField] float rotationSpeed;
        // Start is called before the first frame update
        void Start()
        {
            FillInitialVariables();
        }
               
        // Update is called once per frame
        void Update()
        {
            MovementInput();
            RotateTowardMovementDirection();
        }

        private void FixedUpdate()
        {
            //To actually move the rigidbosy
            rb.AddForce(movemenInput);

        }
        private void FillInitialVariables()
        {
            rb = GetComponent<Rigidbody>();
            cam = Camera.main;
        }
        private void MovementInput()
        {
            //To getthe imput values of the player
            float horizontalInput = Input.GetAxisRaw("Horizontal");
            float verticalInput = Input.GetAxisRaw("Vertical");
            //To get where the camera is looking
            Vector3 cameraForward = Vector3.Scale(cam.transform.forward, new Vector3(1, 0, 1)).normalized;
            Vector3 movement = (verticalInput * cameraForward + horizontalInput * cam.transform.right).normalized;
            //To store the correct input values
            movemenInput = movement * movementSpeed;
        }

        private void RotateTowardMovementDirection()
        {
            //Rotates the player in the direction they are moving
            if (movemenInput != Vector3.zero)
            {
                transform.forward = Vector3.Slerp(transform.forward, movemenInput.normalized, Time.deltaTime * rotationSpeed);
            }
        }

        
    }
}
