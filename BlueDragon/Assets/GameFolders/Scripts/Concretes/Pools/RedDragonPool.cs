using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Abstracts.Pools;
using UdemyProject1.Controllers;
using UnityEngine;

namespace UdemyProject1.Concretes.Pools
{
    public class RedDragonPool : GenericPool<RedDragonController>
    {
        public static RedDragonPool Instance { get; private set;}

        public override void ResetAllObjects()
        {
            foreach (RedDragonController child in GetComponentsInChildren<RedDragonController>())
            {
                if (!child.gameObject.activeSelf) continue;     //obje daha havuzdaysa oluþmamýþsa devam et
                child.KillGameObject();
            }
        }

        protected override void SingletonObject()
        {
            if(Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }

}
