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
        [SerializeField] float  moveDuration;
        Rigidbody elevatorRb;

        private void Start()
        {
            elevatorRb = GetComponent<Rigidbody>();
        }

        private void StartElevator()
        {
            elevatorRb.DOMove(endLocation.position, moveDuration);
            
        }
        public void Interact()
        {
            StartElevator();
        }
    }
}
