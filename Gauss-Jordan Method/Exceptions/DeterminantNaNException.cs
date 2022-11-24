namespace Gauss_Jordan_Method.Exceptions
{
    public class DeterminantNaNException : Exception
    {
        public override string Message => "El determinante es cero o no es computable (NaN)";
    }
}