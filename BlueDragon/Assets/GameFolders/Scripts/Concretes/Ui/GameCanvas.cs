using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Combat;
using UnityEngine;

namespace UdemyProject1.Ui
{
    public class GameCanvas : MonoBehaviour
    {
        [SerializeField] GameObject gameOverPanel;

        private void Awake()
        {
            gameOverPanel = transform.GetChild(1).gameObject;
           
        }

        private void Start()
        {
            Dead dead = FindObjectOfType<Dead>();
            dead.OnDead += HandleOnDead;
        }

        private void HandleOnDead()
        {
            gameOverPanel.SetActive(true);
        }
    }

}
