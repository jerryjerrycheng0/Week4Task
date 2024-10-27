using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameDevWithMarco.Player;
using GameDevWithMarco.Interfaces;

namespace GameDevWithMarco.EnvironmentalProps
{
    public class Chest : MonoBehaviour, IInteractable, ICollectableItems
    {
        Animator anim;
        public int moneyValue;
        [SerializeField] AudioSource collectSound;
        PlayerMoney playerMoney;


        // Start is called before the first frame update
        void Start()
        {
            anim = GetComponent<Animator>();
            playerMoney = FindObjectOfType<PlayerMoney>();
        }

        public void OpenTheChest()
        {            
            anim.SetTrigger("Open");
        }

        public void Collect()
        {
            // Add the value to the player's money
            playerMoney.AddMoney(moneyValue);
            collectSound.Play();
        }

        public void Interact()
        {
            OpenTheChest();
            Collect();
        }
        

    }
}
