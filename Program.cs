namespace MetodosDiccionarios;
internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, string> diccionario = new Dictionary<string, string>
        {
            { "txt", "notepad.exe" },
            { "bmp", "paint.exe" },
            { "dib", "paint.exe" },
            { "rtf", "wordpad.exe" }
        };
        bool bandera = true;
        do{
            try{
                Console.Clear();
                Console.WriteLine("--------- PROPIEDADES Y MÉTODOS DE DICCIONARIOS ---------");
                Console.WriteLine("1. Añadir clave y valor a diccionario");
                Console.WriteLine("2. Ver cantidad de  elementos en diccionario");
                Console.WriteLine("3. Imprimir las claves del diccionario");
                Console.WriteLine("4. Imprimir los valores del diccionario");
                Console.WriteLine("5. Imprimir las claves y valores del diccionario");
                Console.WriteLine("6. Verificar si existe una clave");
                Console.WriteLine("7. Verificar si existe un valor");
                Console.WriteLine("8. Eliminar un elemento del diccionario");
                Console.WriteLine("9. Vaciar diccionario");
                Console.WriteLine("0. Salir del Programa");
                Console.Write("Digite opcion: ");
                int diccOpcion = Convert.ToInt32(Console.ReadLine());
                switch (diccOpcion){
                    case 1:
                    MisFunciones.AñadirElemento(diccionario);
                    break;

                    case 2:
                    MisFunciones.VerCantidad(diccionario);
                    break;

                    case 3:
                    MisFunciones.VerClaves(diccionario);
                    break;

                    case 4:
                    MisFunciones.VerValores(diccionario);
                    break;

                    case 5:
                    MisFunciones.VerClaveValor(diccionario);
                    break;

                    case 6:
                    MisFunciones.ContieneClave(diccionario);
                    break;

                    case 7:
                    MisFunciones.ContieneValor(diccionario);
                    break;

                    case 8:
                    MisFunciones.EliminarElemento(diccionario);
                    break;

                    case 9:
                    MisFunciones.VaciarDicc(diccionario);
                    break;

                    case 0:
                    Console.Clear();
                    Console.WriteLine("Adioos!!");
                    bandera = false;
                    break;

                    default:
                    Console.Clear();
                    Console.WriteLine("Valor ingresado no es una opción, intente de nuevo");
                    break;
                }
            }catch{
                Console.Clear();
                Console.WriteLine("Valor ingresado incorrecto, por favor sólo digite numeros");
                Console.Write("Presione enter para continuar");
                Console.ReadKey();
            }
        }while(bandera);
    }
}