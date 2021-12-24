using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyProject1.Concretes.Ui
{
    public class GameOverPanel : MonoBehaviour
    {
        public void YesButtonClick()
        {
            GameManager.Instance.StartGame();
        }

        public void NoButtonClick()
        {
            GameManager.Instance.ReturnMenu();
        }
    }
}

