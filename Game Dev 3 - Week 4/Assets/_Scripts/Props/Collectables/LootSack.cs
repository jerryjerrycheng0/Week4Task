using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameDevWithMarco.Player;
using GameDevWithMarco.Interfaces;

namespace GameDevWithMarco.EnvironmentalProps
{
    public class LootSack : MonoBehaviour, ICollectableItems
    {
        public int moneyValue; // Amount of money to give
        public bool isBig;
        public AudioSource collectSound; // Sound to play when collected
        MeshRenderer meshRenderer;
        Collider sackCollider;
        PlayerMoney playerMoney;

        public void Start()
        {
            meshRenderer = GetComponent<MeshRenderer>();
            sackCollider = GetComponent<Collider>();
            playerMoney = FindObjectOfType<PlayerMoney>();

            if (!isBig)
            {
                moneyValue = Random.Range(1, 10);
            }
            else
            {
                moneyValue = 50;
            }
        }
        public void Collect()
        {
            playerMoney.AddMoney(moneyValue);
            collectSound.Play();
            meshRenderer.enabled = false;
            sackCollider.enabled = false;

        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                Collect();
            }
        }
    }
}
