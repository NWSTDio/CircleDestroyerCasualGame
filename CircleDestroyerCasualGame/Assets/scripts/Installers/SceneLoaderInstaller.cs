using Zenject;

namespace BallGame.Scripts.Installers {
    public class SceneLoaderInstaller : MonoInstaller { // DDoL object

        public override void InstallBindings() {
            Container.Bind<SceneLoader>().FromNew().AsSingle().NonLazy();
            Container.Bind<GameData>().FromNew().AsSingle().NonLazy();
            }

        }
    }