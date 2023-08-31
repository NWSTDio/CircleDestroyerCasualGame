using System;
using UnityEngine;
using Rand = UnityEngine.Random;
using Zenject;

namespace BallGame {
    public class Score { // набранные очки

        public event Action ScoreChanged;

        [Inject] private readonly GameData _gameData;
        [Inject] private readonly Hp _hp;

        private const string BestScoreKey = "BestScore";
        private readonly int _maxCounter = 10;
        private int _countrer;

        public void AddScore() {
            _gameData.Score++;

            _countrer++;

            if (_countrer >= _maxCounter) {
                if (Rand.Range(0, 2) == 0)
                    _hp.IncreaseHp();

                _countrer = 0;
                }

            float boostCoefficeient = .01f;
            _gameData.Boost = _gameData.Score * boostCoefficeient;

            ScoreChanged?.Invoke();

            SaveScore();
            }

        private void SaveScore() {
            if (PlayerPrefs.GetInt(BestScoreKey) < _gameData.Score)
                PlayerPrefs.SetInt(BestScoreKey, _gameData.Score);
            }

        }
    }
