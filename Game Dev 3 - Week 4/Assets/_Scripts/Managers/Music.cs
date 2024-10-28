using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameDevWithMarco.ObserverPattern;
using GameDevWithMarco.Enemies;

namespace GameDevWithMarco
{
    public class Music : MonoBehaviour
    {
        [SerializeField] GameEvent playerSpottedEvent;
        public AudioSource musiccc;
        public int startingPitch = 1;

        // Update is called once per frame
        void Start()
        {
            musiccc = GetComponent<AudioSource>();
            musiccc.pitch = startingPitch;
        }

        public void GameOver()
        {
                playerSpottedEvent.Raise();
                musiccc.pitch--;
                if (musiccc.pitch <= 0.3f)
                {
                    musiccc.pitch = 0.3f;
                }
        }
    }
}
