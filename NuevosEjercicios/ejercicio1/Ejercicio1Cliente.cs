public class Ejercicio1Cliente : IConsumer
{
// Refactoriza para implementar el patron de diseño mas adecuado
    public void runClient()
    {

        GameUtils utils = new GameUtils.GetInstance();

        utils.calcDamage();
        utils.calcDistance();
        utils.calcDefence();

    }
}