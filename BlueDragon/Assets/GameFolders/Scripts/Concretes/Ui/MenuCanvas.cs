using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyProject1.Ui
{
    public class MenuCanvas : MonoBehaviour
    {
        public void ExitButtonClick()
        {
            GameManager.Instance.ExitGame();
        }

        public void StartButtonClick()
        {
            GameManager.Instance.StartGame();
        }

    }

}
