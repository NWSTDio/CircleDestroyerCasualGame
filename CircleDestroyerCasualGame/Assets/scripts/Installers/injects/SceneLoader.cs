using UnityEngine.SceneManagement;

namespace BallGame {
    public class SceneLoader {

        public void ChangeSceneTo(Scenes newScene) { // загрузка новой сцены
            SceneManager.LoadScene((int)newScene);
            }

        }

    public enum Scenes { // доступные сцены
        PlayScene = 0,
        DefeatScene = 1
        }
    }