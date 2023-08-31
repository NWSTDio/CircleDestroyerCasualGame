
namespace BallGame {
    public class GameData {

        private readonly int _maxHp = 20;

        public int Score;// набранные очки
        public int Hp;// жизни
        public float Boost;// ускорение передвижение кружков

        public GameData() {
            SetMaxHp();
            }

        public void SetMaxHp() {
            Hp = _maxHp;
            }
        public void ClearScore() {
            Score = 0;
            }

        }
    }