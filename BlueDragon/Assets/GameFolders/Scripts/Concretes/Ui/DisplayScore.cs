using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace UdemyProject1.Ui
{
    public class DisplayScore : MonoBehaviour
    {
        TextMeshProUGUI _scoreText;

        private void Awake()
        {
            _scoreText = GetComponent<TextMeshProUGUI>();
        }

        private void Start()
        {
            GameManager.Instance.OnScoreChanged += HandleOnScoreChanged;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnScoreChanged -= HandleOnScoreChanged;
        }

        private void HandleOnScoreChanged(int score = 0)
        {
            _scoreText.text = $"Score: {score}";
        }
    }
}

