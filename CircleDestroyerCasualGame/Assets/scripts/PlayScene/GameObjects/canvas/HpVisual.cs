using TMPro;
using UnityEngine;
using Zenject;

namespace BallGame {
    public class HpVisual : MonoBehaviour {

        [Inject] private readonly Hp _hp;
        [Inject] private readonly GameData _gameData;

        private TextMeshProUGUI _hpText;

        private void Awake() {
            _hpText = GetComponent<TextMeshProUGUI>();

            UpdateVisual();
            }

        private void OnEnable() {
            _hp.HpChanged += UpdateVisual;
            }

        private void OnDisable() {
            _hp.HpChanged -= UpdateVisual;
            }

        private void UpdateVisual() {
            _hpText.text = _gameData.Hp.ToString();
            }

        }
    }