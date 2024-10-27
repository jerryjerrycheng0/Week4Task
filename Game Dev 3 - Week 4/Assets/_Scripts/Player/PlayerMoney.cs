using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace GameDevWithMarco.Player

{
    public class PlayerMoney : MonoBehaviour
    {
        public static PlayerMoney Instance;

        public int totalMoney = 0;

        public TMP_Text howMuch;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public void AddMoney(int amount)
        {
            totalMoney += amount;
            AssignUI();
            Debug.Log("Money Collected: " + amount + " Total Money: " + totalMoney);
        }

        public void AssignUI()
        {
            howMuch.text = "$" + totalMoney;
        }
    }
}
