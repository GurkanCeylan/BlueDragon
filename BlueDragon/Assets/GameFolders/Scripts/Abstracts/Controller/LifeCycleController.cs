using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyProject1.Abstracts.Controller
{
    public abstract class LifeCycleController : MonoBehaviour
    {
        [SerializeField] float maxLifeTime = 5f;
        protected float _currentTime = 0;

        private void Update()
        {
            _currentTime += Time.deltaTime;

            if (_currentTime > maxLifeTime)
            {
                KillGameObject();
            }

        }

        public abstract void KillGameObject();
    }
}

