using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDevWithMarco.EnvironmentalProps
{
    public class Chest : MonoBehaviour
    {
        Animator anim;
        // Start is called before the first frame update
        void Start()
        {
            anim = GetComponent<Animator>();
        }

        public void OpenTheChest()
        {            
            anim.SetTrigger("Open");
        }
    }
}
