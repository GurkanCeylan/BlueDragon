using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Combat;
using UnityEngine;

namespace UdemyProject1.Abstracts.Pools
{
    public abstract class GenericPool<T> : MonoBehaviour where T : Component     //gelen tip component olmak zorunda
    {
        [SerializeField] T[] prefabs;
        [SerializeField] int countLoop = 5;

        Queue<T> _poolPrefabs = new Queue<T>();

        private void Awake()
        {
            SingletonObject();
        }

        private void OnEnable()
        {
            GameManager.Instance.OnSceneChanged += ResetAllObjects;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnSceneChanged -= ResetAllObjects;
        }

        private void Start()
        {
            GrowPoolPrefabs();
        }

        protected abstract void SingletonObject();

        public T Get()  //enemy getiriyor
        {
            if (_poolPrefabs.Count == 0)        //enemy yoksa olu�tuyor
            {
                GrowPoolPrefabs();
            }

            return _poolPrefabs.Dequeue();      //havuzdan �ekiyor
        }

        public abstract void ResetAllObjects();

        private void GrowPoolPrefabs()  //enemy olu�tuyor 
        {
            for (int i = 0; i < countLoop; i++)
            {
                T newPrefab = Instantiate(prefabs[Random.Range(0, prefabs.Length)]);
                newPrefab.transform.parent = this.transform;
                newPrefab.gameObject.SetActive(false);      //havuza at�yor
                _poolPrefabs.Enqueue(newPrefab);            //tutuyor
            }
        }

        public void Set(T poolObject)   //enemynin i�i bitince yoketmeden havuza at�yor
        {
            poolObject.gameObject.SetActive(false);
            _poolPrefabs.Enqueue(poolObject);
        }
    }
}

