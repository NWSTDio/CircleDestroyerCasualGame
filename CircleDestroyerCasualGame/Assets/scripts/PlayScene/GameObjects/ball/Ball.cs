using UnityEngine;
using Zenject;

namespace BallGame {
    [RequireComponent(typeof(BallMovement), typeof(BallColor))]
    public class Ball : MonoBehaviour { // круг

        [Inject] private readonly Score _score;// очки

        private void Start() {
            ReturnToPool();
            }

        private void OnMouseDown() {
            if (Time.timeScale == 0) // если игра на паузе
                return;

            _score.AddScore();// ув. очки

            ReturnToPool();// отключим обьект
            }

        private void OnTriggerExit2D(Collider2D collider) {
            if (collider.TryGetComponent(out Despawner _)) // если деспавнер
                ReturnToPool();// отключим обьект
            }

        public void Show(Vector3 position) { // показать обьект
            gameObject.SetActive(true);

            transform.position = position;
            }


        private void ReturnToPool() { // отключить обьект
            gameObject.SetActive(false);
            }

        }
    }