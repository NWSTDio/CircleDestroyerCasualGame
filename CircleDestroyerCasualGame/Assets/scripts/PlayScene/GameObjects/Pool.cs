using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace BallGame {
    public class Pool : MonoBehaviour { // пул обьектов

        [SerializeField] private Ball _ballPrefab;// префаб шара
        [SerializeField] private Transform _ballsContainer;// контейнер шаров

        [Inject] private readonly DiContainer _diContainer;

        private readonly int minCapacity = 20, maxCapacity = 500;// ограничение количества шаров на сцене
        private List<Ball> _pool;// пул шаров

        private void Start() {
            CreatePool();
            }

        public Ball GetElement() { // получим элемент из пула
            if (TryGetElement(out var element))
                return element;

            if (_pool.Count < maxCapacity)
                return CreateElement();

            throw new Exception("Pool is over!");
            }

        private void CreatePool() { // создать пул шаров
            _pool = new List<Ball>(minCapacity);

            for (int i = 0; i < minCapacity; i++)
                CreateElement();// добавим шар
            }

        private Ball CreateElement() { // создать новый шар
            Ball newObject = _diContainer.InstantiatePrefab(_ballPrefab, _ballsContainer).GetComponent<Ball>();

            _pool.Add(newObject);

            return newObject;
            }

        private bool TryGetElement(out Ball element) { // попытка получить шар из доступных
            foreach (var item in _pool) {
                if (item.gameObject.activeInHierarchy == false) { // если шар отключен
                    element = item;

                    return true;
                    }
                }

            element = null;

            return false;
            }

        }
    }
