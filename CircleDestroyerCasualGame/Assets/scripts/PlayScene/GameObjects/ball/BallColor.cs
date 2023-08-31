using UnityEngine;
using Random = UnityEngine.Random;

namespace BallGame {
    [RequireComponent(typeof(Renderer))]
    public class BallColor : MonoBehaviour { // рандомная установка цвета круга

        private Renderer _ballRenderer;

        private void Awake() {
            _ballRenderer = GetComponent<Renderer>();
            }

        private void OnEnable() {
            SetNewRandomColor();
            }

        private void SetNewRandomColor() {
            Color newColor = Random.ColorHSV();

            _ballRenderer.material.color = newColor;
            }

        }
    }