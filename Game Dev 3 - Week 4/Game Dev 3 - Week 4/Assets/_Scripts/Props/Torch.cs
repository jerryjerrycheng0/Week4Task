using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


namespace GameDevWithMarco.EnvironmentalProps
{
    public class Torch : MonoBehaviour
    {
        private bool isTheTorchOn = true;
        private Light torchLight;
        private float defaultIntensity;

        [SerializeField] float torchTurningTime;
        [SerializeField] Ease torchTurningEase;

        private void Start()
        {
            torchLight = GetComponentInChildren<Light>();
            defaultIntensity = torchLight.intensity;
        }

        public void TurnTorchOnOff()
        {
            if (isTheTorchOn)
            {
                torchLight.DOIntensity(0, torchTurningTime).SetEase(torchTurningEase);
            }
            else
            {
                torchLight.DOIntensity(defaultIntensity, torchTurningTime).SetEase(torchTurningEase);
            }

            isTheTorchOn = !isTheTorchOn;
        }
    }
}
