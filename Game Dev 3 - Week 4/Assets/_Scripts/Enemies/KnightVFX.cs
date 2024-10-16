using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace GameDevWithMarco.Enemies
{
    public class KnightVFX : MonoBehaviour
    {
        public void ShakeScale()
        {
            GetComponent<Animator>().enabled = false;

            transform.DOShakeScale(0.5f, 0.5f);
        }
    }
}
