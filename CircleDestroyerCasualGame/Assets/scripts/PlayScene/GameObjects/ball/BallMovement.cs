using UnityEngine;
using Zenject;

namespace BallGame {
    [RequireComponent(typeof(Rigidbody2D))]
    public class BallMovement : MonoBehaviour { // движение круга

        [Inject] private readonly GameData _gameData;

        private readonly float _speed = 3f;

        private void Update() {
            transform.position += (_speed + _gameData.Boost) * Time.deltaTime * Vector3.down;
            }

        }
    }