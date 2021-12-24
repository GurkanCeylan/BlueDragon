using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Controllers;
using UnityEngine;


namespace UdemyProject1.Combat
{
    public class LaunchProjectile : MonoBehaviour
    {
        [SerializeField] ProjectileController projectilePrefab;
        [SerializeField] Transform projectileTransform;
        [SerializeField] GameObject projectileParent;
        [SerializeField] float delayProjectile = 1f;

        float _currentDelayTime;
        bool _canLaunch = false;

        private void Update()
        {
            _currentDelayTime += Time.deltaTime;

            if( _currentDelayTime > delayProjectile)
            {
                _canLaunch = true;
                _currentDelayTime = 0;
            }
        }

        public void LaunchAction()
        {
            if (_canLaunch)
            {
                ProjectileController newProjectile = Instantiate
                    (projectilePrefab, projectileTransform.position, projectileTransform.rotation);

                newProjectile.transform.parent = projectileParent.transform;

                _canLaunch = false;
            }
        }

    }

}
