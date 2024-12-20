using GameDevWithMarco.ObserverPattern;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDevWithMarco.Enemies
{
    public class KnightView : MonoBehaviour
    {
        [SerializeField] GameEvent playerSpottedEvent;
        [SerializeField] AudioSource discoveredSound;
        [SerializeField] AudioSource playerScream;

        public bool hasPlayerBeenSpotted = false;
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player" && !hasPlayerBeenSpotted)
            {
                Debug.Log("Player Spotted!");

                playerSpottedEvent.Raise();

                hasPlayerBeenSpotted = true;

                discoveredSound.Play();

                playerScream.Play();
            }
        }
    }
}
