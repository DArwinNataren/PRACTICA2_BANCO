/*Instituto Tecnologico Superior de Cintalapa
Asignatura: POO
Nombre_Alumno: Darwin Amaury Nataren Arellano
Nombre_Prpfesor: Jorge Ivan Bermudez Rodriguez
Nombre De La Practica: C# Clase Banco en Paro
*/
class Banco
{
    private String nombre;
    private String cuenta;
    private double saldo;
    private double tipoInteres;


    public void asignarNombre(string nom)
    {
        if (nom.Length == 0)
        {
            System.Console.WriteLine("error cadena vacia");
            return;
        }
        nombre = nom;
    }
    public String obtenerNombre()
    {
        return nombre;
    }
    public void asignarCuenta(string cta)
    {
        if (cta.Length == 0)
        {
            System.Console.WriteLine("error en la cuenta");
            return;
        }
        cuenta = cta;
    }
    public String ontenerCuenta()
    {
        return cuenta;
    }
    public double estado()
    {
        return saldo;
    }
    public void ingreso(double cantidad)
    {
        if (cantidad < 0)
        {
            System.Console.WriteLine("Error:Cantidad Negativa");
            return;
        }
        saldo = cantidad;
    }
    public void reintegro(double cantidad)
    {
        if (saldo - cantidad < 0)
        {
            System.Console.WriteLine("Saldo insuficiente");
            return;
        }
        saldo = saldo - cantidad;
    }
    public void asignarTipoInteres(double inter)
    {
        if (inter < 0)
        {
            System.Console.WriteLine("Tipo de interes no valido");
            ; return;
        }
        tipoInteres = inter;
    }
    public double obtieneTipoInteres()
    {
        return tipoInteres;
    }
    public static void Main(String[] args)
    {
        Banco cuenta01 = new Banco();
        Console.Write("Ingrese su nombre:  ");
        String nom = Console.ReadLine();
        Console.Write("Ingrese su numero de cuenta:  ");
        String cta = Console.ReadLine();
        Console.Write("Ingrese su tipo de interes:  ");
        double inter = Convert.ToDouble(Console.ReadLine());
        cuenta01.asignarNombre(nom);
        cuenta01.asignarCuenta(cta);
        cuenta01.asignarTipoInteres(inter);
        Console.WriteLine("Ingrese la cantidad a ingresar:  ");
        double cantidad = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad a retirar:  ");
        double retiro = Convert.ToDouble(Console.ReadLine());
        cuenta01.ingreso(cantidad);
        cuenta01.reintegro(retiro);
        Console.WriteLine();
        System.Console.WriteLine("Usuario: " + cuenta01.obtenerNombre());
        System.Console.WriteLine("Cuenta: " + cuenta01.ontenerCuenta());
        System.Console.WriteLine("Saldo: " + cuenta01.estado());
        System.Console.WriteLine("Interes: " + cuenta01.obtieneTipoInteres());
    }
}