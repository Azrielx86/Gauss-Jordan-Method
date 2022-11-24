namespace Gauss_Jordan_Method.Exceptions
{
    public class DeterminantZeroException : Exception
    {
        public override string Message => "El determinante es cero, la solución no existe";
    }
}