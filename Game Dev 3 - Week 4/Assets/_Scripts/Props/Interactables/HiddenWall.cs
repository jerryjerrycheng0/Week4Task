using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using GameDevWithMarco.Interfaces;

namespace GameDevWithMarco.EnvironmentalProps
{
    public class HiddenWall : MonoBehaviour, IInteractable
    {

        [SerializeField] Transform openWall;
        [SerializeField] float moveDuration;
        Rigidbody wallRb;

        // Start is called before the first frame update
        void Start()
        {
            wallRb = GetComponent<Rigidbody>();
        }

        private void MoveWall()
        {
            wallRb.DOMove(openWall.position, moveDuration);
        }

        public void Interact()
        {
            MoveWall(); //Opens the wall when interacted
        }
    }
}
