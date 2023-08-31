using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace BallGame {
    [RequireComponent(typeof(Button))]
    public class PauseButtonUI : MonoBehaviour { // кнопка паузы в игре

        [SerializeField] private TextMeshProUGUI _pauseButtonText;

        [Inject] private readonly PauseHandler _pause;

        private void Awake() {
            GetComponent<Button>().onClick.AddListener(() => {
                _pause.TryPauseGame();// переключим паузу
            });
            }

        private void OnEnable() {
            _pause.GamePaused += OnGamePaused;
            }

        private void OnDisable() {
            _pause.GamePaused -= OnGamePaused;
            }

        private void OnGamePaused(bool isPaused) {
            _pauseButtonText.text = isPaused ? "Resume" : "Pause";
            }

        }
    }