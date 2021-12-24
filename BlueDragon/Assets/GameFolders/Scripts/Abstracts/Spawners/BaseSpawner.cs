using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyProject1.Abstracts.Spawners
{
    public abstract class BaseSpawner : MonoBehaviour
    {
        [Range(2f, 5f)]
        [SerializeField] float maxSpawnTime = 3f;
        [Range(0.3f, 1.5f)]
        [SerializeField] float minSpawnTime = 1f;
        

        float _currentSpawnTime;
        float _timeBoundary;

        private void Start()
        {
            ResetTime();
        }

        private void Update()
        {
            _currentSpawnTime += Time.deltaTime;

            if (_currentSpawnTime > _timeBoundary)
            {
                Spawn();
                ResetTime();
            }
        }

        protected abstract void Spawn();

        private void ResetTime()
        {
            _currentSpawnTime = 0f;
            _timeBoundary = Random.Range(minSpawnTime, maxSpawnTime);
        }


    }

}
