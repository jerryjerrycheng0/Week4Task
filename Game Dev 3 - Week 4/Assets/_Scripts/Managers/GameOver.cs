using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using GameDevWithMarco.Player;

namespace GameDevWithMarco.Managers
{
    public class GameOver : MonoBehaviour
    {
        [SerializeField] GameObject[] objectsToActivateOnDeath;
        [SerializeField] GameObject[] objectsToDeactivateOnDeath;
        [SerializeField] TMP_Text endMoney;
        PlayerMoney playerMoney;


        public void Start()
        {
            playerMoney = FindObjectOfType<PlayerMoney>();


            foreach (var items in objectsToActivateOnDeath)
            {
                items.gameObject.SetActive(false);
                //Disables the assigned game objects to ensure the UI only appears when the player is spotted
            }

        }

        //Activates the Game Over UI
        public void StartGameOver()
        {

            foreach (var items in objectsToActivateOnDeath)
            {
                items.gameObject.SetActive(true);
            }
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            endMoney.text = "You have collected $" + playerMoney.totalMoney + "!";
        }
    }
}
