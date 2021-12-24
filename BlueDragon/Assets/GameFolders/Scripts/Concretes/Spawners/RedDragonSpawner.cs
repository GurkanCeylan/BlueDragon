using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Abstracts.Spawners;
using UdemyProject1.Concretes.Pools;
using UdemyProject1.Controllers;
using UnityEngine;

namespace UdemyProject1.Spawners
{
    public class RedDragonSpawner : BaseSpawner
    {

        protected override void Spawn()
        {
            EnemyController newEnemy = RedDragonPool.Instance.Get();
            newEnemy.transform.position = transform.position;
            newEnemy.gameObject.SetActive(true);
        }

    }
}

