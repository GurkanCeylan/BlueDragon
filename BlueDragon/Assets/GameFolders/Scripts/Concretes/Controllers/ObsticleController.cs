using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Pools;
using UnityEngine;

namespace UdemyProject1.Controllers
{
    public class ObsticleController : EnemyController
    {
        public override void SetEnemyPool()
        {
            ObsticlePool.Instance.Set(this);

        }
    }
}

