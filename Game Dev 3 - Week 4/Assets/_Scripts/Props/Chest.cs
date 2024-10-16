using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameDevWithMarco.Interfaces;

namespace GameDevWithMarco.EnvironmentalProps
{
    public class Chest : MonoBehaviour, IInteractable
    {
        Animator anim;
        // Start is called before the first frame update
        void Start()
        {
            anim = GetComponent<Animator>();
        }

        private void OpenTheChest()
        {            
            anim.SetTrigger("Open");
        }

        public void Interact()
        {
            OpenTheChest();
        }
    }
}
