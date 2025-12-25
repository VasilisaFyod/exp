
Simulation sm = new Simulation();
sm.Run();
public class Simulation
{
    private double T0, Tenv, k, tmax, dt;
    private void SimualtionSolution()
    {
        Console.WriteLine("|   i   |    T    |");
            for (double i = 0; i < tmax; i += dt) {
            double T = NewtonCoolingModel.CalculateTemperature(T0, Tenv, k, i);
            if (Math.Abs(T - Tenv) < 0.1){

                return;
            }
            Console.WriteLine($"|  {i,2}  |   {T,7:F2}   ");
        }
    }
    public void Run()
    {
        Input();
        SimualtionSolution();//cvv
    }

    private void Input()
    {
        Console.Write("Введите T0: ");
        T0 = ValidateDouble();

        Console.Write("Введите Tenv: ");
        Tenv = ValidateDouble();

        Console.Write("Введите k: ");
        k = ValidateDoubleAndZero();

        Console.Write("Введите шаг t: ");
        dt = ValidateDoubleAndZero();

        Console.Write("Введите tmax: ");
        tmax = ValidateDoubleAndZero();
    }

    private double ValidateDouble()
    {
        while (true) {
            if (double.TryParse(Console.ReadLine(), out double value))
                return value;
            Console.Write("Ошибка! Число должно быть типа double: ");
        }
    }

    private double ValidateDoubleAndZero() {
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out double value) && value > 0)
                return value;
            Console.Write("Ошибка! Число должно быть типа double: ");
        }
    }
}
