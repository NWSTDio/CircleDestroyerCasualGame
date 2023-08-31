using System.Collections;
using UnityEngine;

namespace BallGame {
    public class Spawner : MonoBehaviour { // спавнер шаров

        [SerializeField] private Pool pool;// пул шаров
        [SerializeField] private float xPosition;// позиция спавна шара по оси X

        private readonly float nextBallTime = .75f;// задержка появления мячика

        private void Start() {
            StartCoroutine(SpawnBalls());
            }

        private IEnumerator SpawnBalls() { // спавн шара
            var wfs = new WaitForSeconds(nextBallTime);

            while (true) {
                yield return wfs;// ждем указанное время

                Ball ball = pool.GetElement();// получим шар
                ball.Show(GetPosition());// покажем его в указанных координатах
                }
            }

        private Vector3 GetPosition() { // получим координаты спавна шара
            float xRandomPosition = Random.Range(-xPosition, xPosition);

            return new Vector3(xRandomPosition, transform.position.y, transform.position.z);
            }

        }
    }
