using GameDevWithMarco.Enemies;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameDevWithMarco
{
    public class GameOver : MonoBehaviour
    {
        public GameObject[] objectsToActivateOnDeath;

        KnightView knightView;
        // Start is called before the first frame update
        void Start()
        {
            knightView = FindObjectOfType<KnightView>();
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
                }
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }
    }
}
