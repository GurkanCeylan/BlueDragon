using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Abstracts.Controller;
using UdemyProject1.Pools;
using UnityEngine;

namespace UdemyProject1.Controllers
{
    public abstract class EnemyController : LifeCycleController
    {
        public override void KillGameObject()
        {
            _currentTime = 0;
            SetEnemyPool();
        }

        public abstract void SetEnemyPool();
    }

}
