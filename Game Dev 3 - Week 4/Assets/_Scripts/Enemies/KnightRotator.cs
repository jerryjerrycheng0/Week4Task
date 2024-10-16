using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDevWithMarco
{
    public class KnightRotator : MonoBehaviour
    {
        [SerializeField] float Speed;
        void Update()
        {
            transform.Rotate(Vector3.up, Speed * Time.deltaTime);
        }
    }
}
