using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace GameDevWithMarco.Player

{
    public class PlayerMoney : MonoBehaviour
    {

        public int totalMoney = 0; //Counts the current money the player has

        public TMP_Text howMuch;


        public void AddMoney(int amount)
        {
            totalMoney += amount;
            AssignUI();
            Debug.Log("Money Collected: " + amount + " Total Money: " + totalMoney);
        }

        public void AssignUI()
        {
            howMuch.text = "$" + totalMoney; //Keep in track of the money in a UI
        }
    }
}
