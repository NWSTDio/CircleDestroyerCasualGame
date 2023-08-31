using UnityEngine;
using Zenject;

namespace BallGame {
    public class Despawner : MonoBehaviour { // уничтожитель шаров

        [Inject] private readonly Hp _hp;

        private void OnTriggerEnter2D(Collider2D collider) {
            if (collider.TryGetComponent(out Ball _))
                _hp.DecreaseHp();// уберем жизни у игрока
            }

        }
    }