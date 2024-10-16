using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDevWithMarco.Player
{
    public class PlayerAnimation : MonoBehaviour
    {
        Animator anim;
        Rigidbody rb;

        // Start is called before the first frame update
        void Start()
        {
            anim = GetComponent<Animator>();
            rb = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            anim.SetFloat("Speed", rb.velocity.magnitude);
        }
    }
}
