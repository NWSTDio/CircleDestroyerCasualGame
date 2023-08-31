using TMPro;
using UnityEngine;
using Zenject;

namespace BallGame {
    public class ScoreVisual : MonoBehaviour {

        [Inject] private readonly Score _score;
        [Inject] private readonly GameData _gameData;

        private TextMeshProUGUI _scoreText;

        private void Awake() {
            _scoreText = GetComponent<TextMeshProUGUI>();

            UpdateVisual();
            }

        private void OnEnable() {
            _score.ScoreChanged += UpdateVisual;
            }

        private void OnDisable() {
            _score.ScoreChanged -= UpdateVisual;
            }

        private void UpdateVisual() {
            _scoreText.text = _gameData.Score.ToString();
            }

        }
    }