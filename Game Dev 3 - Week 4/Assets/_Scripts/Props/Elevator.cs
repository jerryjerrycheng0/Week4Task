using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using GameDevWithMarco.Interfaces;

namespace GameDevWithMarco.EnvironmentalProps
{
    public class Elevator : MonoBehaviour, IInteractable
    {
        [SerializeField] Transform endLocation;
        [SerializeField] Transform startLocation;
        [SerializeField] float  moveDuration;
        Rigidbody elevatorRb;
        public bool hasArrived = false;


        private void Start()
        {
            elevatorRb = GetComponent<Rigidbody>();
        }

        private void StartElevator()
        {

                elevatorRb.DOMove(endLocation.position, moveDuration);
                hasArrived = true;
            if (hasArrived)
            {
                elevatorRb.DOMove(startLocation.position, moveDuration);
                hasArrived = false;
            }
            
        }
        public void Interact()
        {
            StartElevator();
        }
    }
}
