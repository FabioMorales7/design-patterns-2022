// Refactoriza para implementar el patron de diseño mas adecuado
public class GameUtils{
        private GameUtils() { }

        private static GameUtils _instance;

        public static GameUtils GetInstance()
        {
            if (_instance == null)
            {
                _instance = new GameUtils();
            }
            return _instance;
        }

    public int calcDamage(){
        return 1;
    }

    public int calcDefence(){
        return 1;
    }

    public int calcDistance(){
        return 1;
    }

}