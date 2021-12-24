using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Concretes.Pools;
using UnityEngine;

namespace UdemyProject1.Controllers
{
    public class RedDragonController : EnemyController
    {
        public override void SetEnemyPool()
        {
            RedDragonPool.Instance.Set(this);   
        }
    }
}

