using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDevWithMarco.CameraSpace
{
    public class SmoothCameraFollow : MonoBehaviour
    {
        [SerializeField] Transform target;
        [SerializeField] Vector3 offset;
        [SerializeField] float smoothSpeed = 0.125f;

        private Vector3 originalPosition;
        // Start is called before the first frame update
        void Start()
        {
            //To get the direction
            originalPosition = transform.position - target.position;
        }

        // Update is called once per frame
        void LateUpdate()
        {
            //To actually move the camera
            Vector3 desiredPosition = target.position + originalPosition;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
    }
}
