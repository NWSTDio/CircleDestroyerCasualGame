using UnityEngine;
using Zenject;

namespace BallGame {
    public class DefeatTrigger : MonoBehaviour {

        private Hp _hp;
        private SceneLoader _sceneLoader;

        [Inject]
        private void MonoConstructor(Hp hp, SceneLoader sceneLoader) {
            _hp = hp;
            _sceneLoader = sceneLoader;
            }

        private void OnEnable() {
            _hp.GameDefeated += OnGameDefeated;
            }

        private void OnDisable() {
            _hp.GameDefeated -= OnGameDefeated;
            }

        private void OnGameDefeated() {
            _sceneLoader.ChangeSceneTo(Scenes.DefeatScene);
            }

        }
    }