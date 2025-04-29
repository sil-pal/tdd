using System.Text.RegularExpressions;

namespace TDD.App;

public class Funciones
{
    public int Sumar(int dato1, int dato2)
    {
        return dato1 + dato2;
    }

    public bool EsPalindrome(string text)
    {
        var reverse = new string(text.Reverse().ToArray());
        text = text.Replace(" ", "");
        reverse = reverse.Replace(" ", "");
        return reverse.ToLower().Equals(text.ToLower());
    }
     
    public int CalCularnumeroMayor(int[] numeros)
    {
        return numeros.OrderByDescending(x => x).ToList()[0];


    }

    public bool EsContrasenaValida(string password)
    {
        if (password.Length < 8)
            return false;

        bool tieneMayuscula = Regex.IsMatch(password, "[A-Z]");
        bool tieneNumero = Regex.IsMatch(password, "[0-9]");
        bool tieneSimbolo = Regex.IsMatch(password, "[^a-zA-Z0-9]");

        return tieneMayuscula && tieneNumero && tieneSimbolo;
    }
}