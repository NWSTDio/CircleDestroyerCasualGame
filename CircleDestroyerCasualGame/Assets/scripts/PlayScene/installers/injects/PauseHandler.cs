using System;
using UnityEngine;

namespace BallGame {
    public class PauseHandler { // слушатель паузы

        public event Action<bool> GamePaused;

        private bool _isPaused = false;

        public void TryPauseGame() {
            _isPaused ^= true;

            Time.timeScale = _isPaused ? 0 : 1;

            GamePaused?.Invoke(_isPaused);
            }

        }
    }