using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace BallGame {
    public class DefeatSceneUI : MonoBehaviour { // сцена поражения

        [SerializeField] private TextMeshProUGUI _totalScoreText, _bestScoreText;// текстовые метки набранных очков
        [SerializeField] private Button _restartGameButton;// кнопка рестарта игры

        [Inject] private readonly SceneLoader _sceneLoader;// загрузчик сцен
        [Inject] private readonly GameData _gameData;// данные игры

        private const string BestScoreKey = "BestScore";// поле хранения данных лучьшего результата

        private void Awake() {
            UpdateVisual();

            _restartGameButton.onClick.AddListener(() => {
                _gameData.ClearScore();// сбросим набранные очки
                _gameData.SetMaxHp();// установим макс. колл-во жизней

                _sceneLoader.ChangeSceneTo(Scenes.PlayScene);// загрузим игровую сцену
            });
            }

        private void UpdateVisual() {
            _totalScoreText.text = _gameData.Score.ToString();
            _bestScoreText.text = PlayerPrefs.GetInt(BestScoreKey).ToString();
            }

        }
    }