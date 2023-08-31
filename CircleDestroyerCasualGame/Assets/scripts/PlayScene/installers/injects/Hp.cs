using System;
using Zenject;

namespace BallGame {
    public class Hp { // хп игрока

        public event Action HpChanged;
        public event Action GameDefeated;

        [Inject] private readonly GameData _gameData;

        public void DecreaseHp() {
            _gameData.Hp--;

            if (_gameData.Hp <= 0)
                GameDefeated?.Invoke();// проиграл
            else
                HpChanged?.Invoke();
            }

        public void IncreaseHp() {
            _gameData.Hp++;

            HpChanged?.Invoke();
            }

        }
    }