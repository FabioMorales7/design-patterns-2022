// TODO implementa el patron de diseño State
public class StateClient : IConsumer
{

    // TODO agregar estados extra EAT, JUMP, agrega nuevas combinaciones de condiciones nuevas entre estados, ejemplo de SLEEP no puede pasar a JUMP, 
    public const string WALK = "Walk";
    public const string ATTACK = "Attack";
    public const string SLEEP = "Sleep";
    public const string SWIM = "Swim";
    public const string EAT = "Eat";
    public const string JUMP = "Jump";

    private string state = WALK;

    public void runClient()
    {

        Console.WriteLine("Ejecución StateClient.");

        doAction(ATTACK);
        doAction(SLEEP);
        doAction(ATTACK);
        doAction(SWIM);
        doAction(WALK);
        doAction(EAT);
        doAction(JUMP);



        int opcion; 

        Console.WriteLine("1. Walk");
        Console.WriteLine("2. Attack");
        Console.WriteLine("3. Sleep");
        Console.WriteLine("4. Swim");
        Console.WriteLine("5. Eat");
        Console.WriteLine("6. Jump");
        Console.WriteLine("7. Jump");
        Console.WriteLine("SELECCIONE UN ESTADO: ");
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                doAction(WALK);
                break;
            case 2:
                doAction(ATTACK);
                break;
            case 3:
                doAction(SLEEP);
                break;
            case 4:
                doAction(SWIM);
                break;
            case 5:
                doAction(EAT);
                break;
            case 6:
                doAction(JUMP);
                break;
            case 7:
                Console.WriteLine("Adios");
                break;
            default:
                Console.WriteLine("Seleccione un numero entre 1-7");
                break;
        }

    }

    private void doAction(string action)
    {

        switch (action)
        {
            case WALK:
                Console.WriteLine($"Cambio de estado de {state} -> {action}");
                state = action;
                break;
            case ATTACK:
                if (state == SLEEP || state == SWIM)
                {
                    Console.WriteLine($"No puedes cambiar estado de {state} a {action}");
                }
                else
                {
                    Console.WriteLine($"Cambio de estado de {state} -> {action}");
                    state = action;
                }
                break;
            case SLEEP:
                if (state == ATTACK )
                {
                    Console.WriteLine($"No puedes cambiar estado de {state} a {action}");
                }
                else if(state==)
                else
                {
                    Console.WriteLine($"Cambio de estado de {state} -> {action}");
                    state = action;
                }
                break;
            case SWIM:
                if (state == SLEEP || state == ATTACK)
                {
                    Console.WriteLine($"No puedes cambiar estado de {state} a {action}");
                }
                else
                {
                    Console.WriteLine($"Cambio de estado de {state} -> {action}");
                    state = action;
                }
                break;
            case EAT:
                if (state == SLEEP || state == SWIM)
                {
                    Console.WriteLine($"No puedes cambiar estado de {state} a {action}");
                }
                else
                {
                    Console.WriteLine($"Cambio de estado de {state} -> {action}");
                    state = action;
                }
                break;
        }

    }

}
