namespace MetodosDiccionarios;

    public class MisFunciones
    {
        public static void AñadirElemento(Dictionary<string, string> dicc){
            try{
                Console.Clear();
                Console.Write("Ingrese la clave del elemento: ");
                string clave = Console.ReadLine();
                Console.Write("Ingrese el valor del elemento: ");
                string valor = Console.ReadLine();
                dicc.Add(clave, valor);
            }catch{
                Console.WriteLine("Error en elemento ingresado, volviendo al menú");
                Console.Write("Presione enter para continuar");
                Console.ReadKey();
            }
        }

        public static void VerCantidad(Dictionary<string, string> dicc){
            try{
                Console.Clear();
                Console.WriteLine("El total de elementos en el diccionario es de {0}", dicc.Count);
                Console.Write("Presione enter para continuar");
                Console.ReadKey();
            }catch{
                Console.WriteLine("Error en elemento ingresado, volviendo al menú");
                Console.Write("Presione enter para continuar");
                Console.ReadKey();
            }
        }

        public static void VerClaves(Dictionary<string, string> dicc){
            try{
                if(dicc.Count == 0){
                    Console.WriteLine("No hay claves que mostrar");
                }
                else{
                    Console.Clear();
                    Console.WriteLine("CLAVES");
                    Dictionary<string, string>.KeyCollection claves = dicc.Keys;
                    int acumulador = 1;
                    foreach(string clave in claves){
                        Console.WriteLine("Clave {0}: {1}",acumulador, clave);
                        acumulador++;
                    }
                }
                Console.Write("Presione enter para continuar");
                Console.ReadKey();
            }catch{
                Console.WriteLine("Error en elemento ingresado, volviendo al menú");
                Console.Write("Presione enter para continuar");
                Console.ReadKey();
            }
        }

        public static void VerValores(Dictionary<string, string> dicc){
            try{
                if(dicc.Count == 0){
                    Console.WriteLine("No hay valores que mostrar");
                }
                else{
                    Console.Clear();
                    Console.WriteLine("VALORES");
                    Dictionary<string, string>.ValueCollection valores = dicc.Values;
                    int acumulador = 1;
                    foreach(string valor in valores){
                        Console.WriteLine("Valor {0}: {1}",acumulador, valor);
                        acumulador++;
                    }
                }
                Console.Write("Presione enter para continuar");
                Console.ReadKey();
            }catch{
                Console.WriteLine("Error en elemento ingresado, volviendo al menú");
                Console.Write("Presione enter para continuar");
                Console.ReadKey();
            }
        }

        public static void VerClaveValor(Dictionary<string, string> dicc){
            try{
                if(dicc.Count == 0){
                    Console.WriteLine("No hay contenido que mostrar");
                }
                else{
                    Console.Clear();
                    Console.WriteLine("CLAVES Y VALORES");
                    int acumulador = 1;
                    foreach(KeyValuePair<string, string> par in dicc){
                        Console.WriteLine("Clave {0}: {1}  Valor {0}: {2}",acumulador, par.Key,par.Value);
                        acumulador++;
                    }
                }
                Console.Write("Presione enter para continuar");
                Console.ReadKey();
            }catch{
                Console.WriteLine("Error en elemento ingresado, volviendo al menú");
                Console.Write("Presione enter para continuar");
                Console.ReadKey();
            }
        }
        
        public static void ContieneClave(Dictionary<string, string> dicc){
            try{
                if(dicc.Count == 0){
                    Console.WriteLine("No hay contenido que mostrar");
                }
                else{
                    Console.Clear();
                    Console.Write("Ingrese la clave a verificar: ");
                    string clave = Console.ReadLine();
                    if(dicc.ContainsKey(clave)){
                        Console.Clear();
                        Console.WriteLine("La clave '{0}' si existe en el diccionario", clave);
                    }
                    else{
                        Console.WriteLine("La clave ingresada no existe en el diccionario");
                    }
                }
                Console.Write("Presione enter para continuar");
                Console.ReadKey();
            }catch{
                Console.WriteLine("Error en elemento ingresado, volviendo al menú");
                Console.Write("Presione enter para continuar");
                Console.ReadKey();
            }
        }

        public static void ContieneValor(Dictionary<string, string> dicc){
            try{
                if(dicc.Count == 0){
                    Console.WriteLine("No hay contenido que mostrar");
                }
                else{
                    Console.Clear();
                    Console.Write("Ingrese valor a verificar: ");
                    string valor = Console.ReadLine();
                    if(dicc.ContainsValue(valor)){
                        Console.Clear();
                        Console.WriteLine("El valor '{0}' si existe en el diccionario", valor);
                    }
                    else{
                        Console.WriteLine("El valor ingresado no existe en el diccionario");
                    }
                }
                Console.Write("Presione enter para continuar");
                Console.ReadKey();
            }catch{
                Console.WriteLine("Error en elemento ingresado, volviendo al menú");
                Console.Write("Presione enter para continuar");
                Console.ReadKey();
            }
        }

        public static void EliminarElemento(Dictionary<string, string> dicc){
            try{
                if(dicc.Count == 0){
                    Console.WriteLine("No hay contenido que mostrar");
                }
                else{
                    Console.Clear();
                    Console.Write("Ingrese clave del elemento a eliminar: ");
                    string clave = Console.ReadLine();
                    if(dicc.ContainsKey(clave)){
                        Console.Clear();
                        dicc.Remove(clave);
                        Console.WriteLine("Elemento eliminado con éxito");
                    }
                    else{
                        Console.WriteLine("La clave ingresada no existe en el diccionario");
                    }
                }
                Console.Write("Presione enter para continuar");
                Console.ReadKey();
            }catch{
                Console.WriteLine("Error en elemento ingresado, volviendo al menú");
                Console.Write("Presione enter para continuar");
                Console.ReadKey();
            }
        }

        public static void VaciarDicc(Dictionary<string, string> dicc){
            try{
                if(dicc.Count == 0){
                    Console.WriteLine("No hay contenido que eliminar");
                }
                else{
                    dicc.Clear();
                    Console.WriteLine("Diccionario vaciado con éxito");
                }
                Console.Write("Presione enter para continuar");
                Console.ReadKey();
            }catch{
                Console.WriteLine("Error en elemento ingresado, volviendo al menú");
                Console.Write("Presione enter para continuar");
                Console.ReadKey();
            }
        }
    }
