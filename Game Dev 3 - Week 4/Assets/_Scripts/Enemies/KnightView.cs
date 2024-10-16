using GameDevWithMarco.ObserverPattern;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDevWithMarco.Enemies
{
    public class KnightView : MonoBehaviour
    {
        [SerializeField] GameEvent playerSpottedEvent;

        public bool hasPlayerBeenSpotted = false;
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player" && !hasPlayerBeenSpotted)
            {
                Debug.Log("Player Spotted!");

                playerSpottedEvent.Raise();

                hasPlayerBeenSpotted = true;
            }
        }
    }
}
