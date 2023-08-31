using Zenject;

namespace BallGame {
    public class PlaySceneInstaller : MonoInstaller { // инициализация классов-одиночек

        public override void InstallBindings() {
            Container.Bind<Score>().FromNew().AsSingle().NonLazy();
            Container.Bind<Hp>().FromNew().AsSingle().NonLazy();
            Container.Bind<PauseHandler>().FromNew().AsSingle().NonLazy();
            }

        }
    }