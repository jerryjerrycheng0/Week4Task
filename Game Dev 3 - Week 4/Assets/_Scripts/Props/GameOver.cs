using GameDevWithMarco.Enemies;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameDevWithMarco.ObserverPattern
{
    public class GameOver : MonoBehaviour
    {
        public GameObject[] objectsToActivateOnDeath;

        [SerializeField]KnightView knightView;
        // Start is called before the first frame update
        void Start()
        {
            knightView = FindAnyObjectByType<KnightView>();
            foreach (var items in objectsToActivateOnDeath)
            {
                items.gameObject.SetActive(false);
            }

        }

        // Update is called once per frame
        void Update()
        {
            if (knightView.hasPlayerBeenSpotted == true)
            {
                foreach (var items in objectsToActivateOnDeath)
                {
                    items.gameObject.SetActive(true);
                    Debug.Log("GO ON");
                }
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }
    }
}
