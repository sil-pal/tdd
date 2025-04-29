using TDD.App;

namespace TDD.Tests;

public class FunctionesTests
{
    [Test]
    public void SumarCaso01()
    {
        //Arrange -> Preparar el escenario, datos intancias
        var funciones = new Funciones();
        var dato1 = 10;
        var dato2 = 20;
        //Act
        var resultado = funciones.Sumar(dato1, dato2);
        //Assert
        Assert.AreEqual(30, resultado);
    }
    
    [Test]
    public void SumarCaso02()
    {
        //Arrange -> Preparar el escenario, datos intancias
        var funciones = new Funciones();
        var dato1 = 15;
        var dato2 = 15;
        //Act
        var resultado = funciones.Sumar(dato1, dato2);
        //Assert
        Assert.AreEqual(30, resultado);
    }
    
    [Test]
    public void SumarCaso03()
    {
        //Arrange -> Preparar el escenario, datos intancias
        var funciones = new Funciones();
        var dato1 = 6;
        var dato2 = 7;
        //Act
        var resultado = funciones.Sumar(dato1, dato2);
        //Assert
        Assert.AreEqual(13, resultado);
    }
    
    [Test]
    public void EsPalindromeCaso01()
    {
        var funciones = new Funciones();
        var dato1 = "ana";
        var resultado = funciones.EsPalindrome(dato1);
        Assert.IsTrue(resultado);
    }
    
    [Test]
    public void EsPalindromeCaso02()
    {
        var funciones = new Funciones();
        var dato1 = "reconocer";
        var resultado = funciones.EsPalindrome(dato1);
        Assert.IsTrue(resultado);
    }
    
    [Test]
    public void EsPalindromeCaso03()
    {
        var funciones = new Funciones();
        var dato1 = "miercoles";
        var resultado = funciones.EsPalindrome(dato1);
        Assert.IsFalse(resultado);
    }
    
    [Test]
    public void EsPalindromeCaso04()
    {
        var funciones = new Funciones();
        var dato1 = "Reconocer";
        var resultado = funciones.EsPalindrome(dato1);
        Assert.IsTrue(resultado);
    }
    
    [Test]
    public void EsPalindromeCaso05()
    {
        var funciones = new Funciones();
        var dato1 = "Anita lava la tina";
        var resultado = funciones.EsPalindrome(dato1);
        Assert.IsTrue(resultado);
    }
    [Test]
    public void CalcularnumeroMayor01()
    {
        var funciones = new Funciones();
        var dato = new int [] {2,7,9,3,4};
        var resultado = funciones.CalCularnumeroMayor(dato);
        Assert.AreEqual(9,resultado);
    }

    [Test]
    public void CalcularnumeroMayor02()
    {
        var funciones = new Funciones();
        var dato = new int[] { 8, 5, 4, 3, 2 };
        var resultado = funciones.CalCularnumeroMayor(dato);
        Assert.AreEqual(8, resultado);
    }
    [Test]
    public void CalcularnumeroMayor03()
    {
        var funciones = new Funciones();
        var dato = new int[] { 10, 3, 6, 1, 5 };
        var resultado = funciones.CalCularnumeroMayor(dato);
        Assert.AreEqual(10, resultado);
    }
    [Test]
    public void CalcularnumeroMayor04()
    {
        var funciones = new Funciones();
        var dato = new int[] { 15, 14, 13, 12 };
        var resultado = funciones.CalCularnumeroMayor(dato);
        Assert.AreEqual(15, resultado);
    }


    [Test]
    public void CalcularnumeroMayor05()
    {
        var funciones = new Funciones();
        var dato = new int[] { 20, 19 };
        var resultado = funciones.CalCularnumeroMayor(dato);
        Assert.AreEqual(20, resultado);
    }

    [Test]
    public void Contrasenavalida01()
    {
        var funciones = new Funciones();
        var dato = "S457@%_5";
        var resultado = funciones.EsContrasenaValida(dato);
        Assert.IsTrue(resultado);
    }

    [Test]
    public void Contrasenavalida02()
    {
        var funciones = new Funciones();
        var dato = "Bo_l68@m";
        var resultado = funciones.EsContrasenaValida(dato);
        Assert.IsTrue(resultado);
    }



    [Test]
    public void Contrasenavalida03()
    {
        var funciones = new Funciones();
        var dato = "Jt_@47y$%";
        var resultado = funciones.EsContrasenaValida(dato);
        Assert.IsTrue(resultado);
    }

    [Test]
    public void Contrasenavalida04()
    {
        var funciones = new Funciones();
        var dato = "A_ju/6";
        var resultado = funciones.EsContrasenaValida(dato);
        Assert.IsFalse(resultado);
    }

    [Test]
    public void Contrasenavalida05()
    {
        var funciones = new Funciones();
        var dato = "A24_k/()%";
        var resultado = funciones.EsContrasenaValida(dato);
        Assert.IsTrue(resultado);
    }


}