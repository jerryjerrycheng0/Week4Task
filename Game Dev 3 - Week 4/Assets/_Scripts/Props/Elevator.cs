using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace GameDevWithMarco.EnvironmentalProps
{
    public class Elevator : MonoBehaviour
    {
        [SerializeField] Transform endLocation;
        [SerializeField] float  moveDuration;
        Rigidbody elevatorRb;

        private void Start()
        {
            elevatorRb = GetComponent<Rigidbody>();
        }

        public void StartElevator()
        {
            elevatorRb.DOMove(endLocation.position, moveDuration);
            
        }
    }
}
