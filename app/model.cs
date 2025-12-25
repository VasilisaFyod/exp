using System;


public static class NewtonCoolingModel
{
    public static double CalculateTemperature(
        double T0,
        double Tenv,
        double k,
        double t)
    {
        return Tenv + (T0 - Tenv) * Math.Exp(-k * t);
    }
}