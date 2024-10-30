using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using GameDevWithMarco.Interfaces;


namespace GameDevWithMarco.EnvironmentalProps
{
    public class Torch : MonoBehaviour, IInteractable
    {
        private bool isTheTorchOn = true;
        private Light torchLight;
        private float defaultIntensity;

        [SerializeField] float torchTurningTime;
        [SerializeField] Ease torchTurningEase;
        public AudioSource lightSound;

        private void Start()
        {
            torchLight = GetComponentInChildren<Light>();
            defaultIntensity = torchLight.intensity;
        }

        private void TurnTorchOnOff()
        {
            lightSound.Play(); //Ding
            if (isTheTorchOn) //Turns the light on
            {
                torchLight.DOIntensity(0, torchTurningTime).SetEase(torchTurningEase);
            }
            else //Turns the light off
            {
                torchLight.DOIntensity(defaultIntensity, torchTurningTime).SetEase(torchTurningEase);
            }

            isTheTorchOn = !isTheTorchOn;
        }

        public void Interact()
        {
            TurnTorchOnOff(); //Calls back the Interact function
        }
    }
}
