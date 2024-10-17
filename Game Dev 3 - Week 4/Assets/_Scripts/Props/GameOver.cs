using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDevWithMarco.ObserverPattern
{
    public class GameOver : MonoBehaviour
    {
        [SerializeField] GameObject[] objectsToActivateOnDeath;

        public void Start()
        {
            foreach (var items in objectsToActivateOnDeath)
            {
                items.gameObject.SetActive(false);
                // Disables the assigned game objects to ensure the UI only appears when the player is spotted
            }

        }

        // Activates the Game Over UI
        public void StartGameOver()
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
