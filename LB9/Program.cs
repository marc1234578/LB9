using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB9
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("============================");
            Console.WriteLine("TIENDA DON LUCAS");
            Console.WriteLine("============================");
            Console.WriteLine("1: Registrar venta");
            Console.WriteLine("2: Registrar devolución");
            Console.WriteLine("3: Cerrar Caja");
            Console.WriteLine("============================");
            Console.WriteLine("Ingrese una opcion");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1:
                    ejercicio2(); break;
                case 2:
                    ejercicio3(); break;
                case 3: ejercicio4(); break;

            }
            Console.ReadKey();

            return;
        }
        static void ejercicio2()
        {
            Console.WriteLine("============================");
            Console.WriteLine("REGISTAR VENTA DE:");
            Console.WriteLine("============================");
            Console.WriteLine("1: lIMPIEZA ");
            Console.WriteLine("2: ABARROTES");
            Console.WriteLine("3: GOLOSINAS");
            Console.WriteLine("4: Electrónicos");
            Console.WriteLine("5: <- Regresar");
            Console.WriteLine("============================");
            Console.WriteLine("INGRESE UNA OPCION");
            int opcion2 = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion2)
            {
                case 1: limpiezaVendidos(); break;
                case 2: abarrotesVendidos(); break;
                case 3: golosinasVendidos(); break;
                case 4: electronicosVendidos(); break;
                case 5: Main(); break;
            }
            return;
        }
        static void ejercicio3()
        {
            Console.WriteLine("============================");
            Console.WriteLine("REGISTAR DEVOLUCION DE:");
            Console.WriteLine("============================");
            Console.WriteLine("1: lIMPIEZA ");
            Console.WriteLine("2: ABARROTES");
            Console.WriteLine("3: GOLOSINAS");
            Console.WriteLine("4: Electrónicos");
            Console.WriteLine("5: <- Regresar");
            Console.WriteLine("============================");
            Console.WriteLine("INGRESE UNA OPCION");
            int opcion3 = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion3)
            {
                case 1: limpiezaDevueltos(); break;
                case 2: abarrotesDevueltos(); break;
                case 3: golosinasDevueltos(); break;
                case 4: electronicosDevueltos(); break;
                case 5: Main(); break;
            }
            return;
        }
        static void limpiezaVendidos()
        {
            Console.WriteLine("============================");
            Console.WriteLine("REGISTAR VENTA DE LIMPIEZA:");
            Console.WriteLine("============================");
            Console.Write("Ingrese cantidad (unidades):");
            int UNIDADES = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            float PRECIO = float.Parse(Console.ReadLine());
            float TOTAL1;
            TOTAL1 = UNIDADES * PRECIO;
            Console.WriteLine("============================");
            Console.WriteLine("Se han ingresado " + UNIDADES + " unidades");
            Console.WriteLine("Se han ingresado " + TOTAL1 + " en caja");
            Console.WriteLine("============================");
            Console.WriteLine("1: Registrar más productos de limpieza ");
            Console.WriteLine("2: <- Regresar");
            Console.WriteLine("============================");
            Console.WriteLine("INGRESE UNA OPCION");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1: limpiezaVendidos(); break;
                case 2: ejercicio2(); break;
            }
        }
        static void abarrotesVendidos()
        {
            Console.WriteLine("============================");
            Console.WriteLine("REGISTAR VENTA DE ABARROTES:");
            Console.WriteLine("============================");
            Console.Write("Ingrese cantidad (unidades):");
            int UNIDADES = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            float PRECIO = float.Parse(Console.ReadLine());
            float TOTAL1;
            TOTAL1 = UNIDADES * PRECIO;
            Console.WriteLine("============================");
            Console.WriteLine("Se han ingresado " + UNIDADES + " unidades");
            Console.WriteLine("Se han ingresado " + TOTAL1 + " en caja");
            Console.WriteLine("============================");
            Console.WriteLine("1: Registrar más productos de ABARROTES ");
            Console.WriteLine("2: <- Regresar");
            Console.WriteLine("============================");
            Console.WriteLine("INGRESE UNA OPCION");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1: abarrotesVendidos(); break;
                case 2: ejercicio2(); break;
            }
        }
        static void golosinasVendidos()
        {
            Console.WriteLine("============================");
            Console.WriteLine("REGISTAR VENTA DE GOLOSINAS:");
            Console.WriteLine("============================");
            Console.Write("Ingrese cantidad (unidades):");
            int UNIDADES = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            float PRECIO = float.Parse(Console.ReadLine());
            float TOTAL1;
            TOTAL1 = UNIDADES * PRECIO;
            Console.WriteLine("============================");
            Console.WriteLine("Se han ingresado " + UNIDADES + " unidades");
            Console.WriteLine("Se han ingresado " + TOTAL1 + " en caja");
            Console.WriteLine("============================");
            Console.WriteLine("1: Registrar más productos de GOLOSINAS ");
            Console.WriteLine("2: <- Regresar");
            Console.WriteLine("============================");
            Console.WriteLine("INGRESE UNA OPCION");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1: golosinasVendidos(); break;
                case 2: ejercicio2(); break;
            }
        }
        static void electronicosVendidos()
        {
            Console.WriteLine("============================");
            Console.WriteLine("REGISTAR VENTA DE ELECTRONICOS:");
            Console.WriteLine("============================");
            Console.Write("Ingrese cantidad (unidades):");
            int UNIDADES = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            float PRECIO = float.Parse(Console.ReadLine());
            float TOTAL1;
            TOTAL1 = UNIDADES * PRECIO;
            Console.WriteLine("============================");
            Console.WriteLine("Se han ingresado " + UNIDADES + " unidades");
            Console.WriteLine("Se han ingresado " + TOTAL1 + " en caja");
            Console.WriteLine("============================");
            Console.WriteLine("1: Registrar más productos  ELECTRONICOS ");
            Console.WriteLine("2: <- Regresar");
            Console.WriteLine("============================");
            Console.WriteLine("INGRESE UNA OPCION");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1: electronicosVendidos(); break;
                case 2: ejercicio2(); break;
            }
        }
        static void limpiezaDevueltos()
        {
            Console.WriteLine("============================");
            Console.WriteLine("REGISTAR DEVOLUCION DE LIMPIEZA:");
            Console.WriteLine("============================");
            Console.Write("Ingrese cantidad (unidades):");
            int UNIDADES = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            float PRECIO = float.Parse(Console.ReadLine());
            float TOTAL1;
            TOTAL1 = UNIDADES * PRECIO;
            Console.WriteLine("============================");
            Console.WriteLine("Se han REGRESADO " + UNIDADES + " unidades");
            Console.WriteLine("Se han DEVUELTO " + TOTAL1 + " en caja");
            Console.WriteLine("============================");
            Console.WriteLine("1: Registrar más productos de limpieza ");
            Console.WriteLine("2: <- Regresar");
            Console.WriteLine("============================");
            Console.WriteLine("INGRESE UNA OPCION");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1: limpiezaDevueltos(); break;
                case 2: ejercicio3(); break;
            }
        }
        static void abarrotesDevueltos()
        {
            Console.WriteLine("============================");
            Console.WriteLine("REGISTAR DEVOLUCION DE ABARROTES:");
            Console.WriteLine("============================");
            Console.Write("Ingrese cantidad (unidades):");
            int UNIDADES = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            float PRECIO = float.Parse(Console.ReadLine());
            float TOTAL1;
            TOTAL1 = UNIDADES * PRECIO;
            Console.WriteLine("============================");
            Console.WriteLine("Se han REGRESADO " + UNIDADES + " unidades");
            Console.WriteLine("Se han DEVUELTO " + TOTAL1 + " en caja");
            Console.WriteLine("============================");
            Console.WriteLine("1: Registrar más productos de ABARROTES ");
            Console.WriteLine("2: <- Regresar");
            Console.WriteLine("============================");
            Console.WriteLine("INGRESE UNA OPCION");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1: abarrotesDevueltos(); break;
                case 2: ejercicio3(); break;
            }
        }
        static void golosinasDevueltos()
        {
            Console.WriteLine("============================");
            Console.WriteLine("REGISTAR DEVOLUCION DE GOLOSINAS:");
            Console.WriteLine("============================");
            Console.Write("Ingrese cantidad (unidades):");
            int UNIDADES = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            float PRECIO = float.Parse(Console.ReadLine());
            float TOTAL1;
            TOTAL1 = UNIDADES * PRECIO;
            Console.WriteLine("============================");
            Console.WriteLine("Se han REGRESADO " + UNIDADES + " unidades");
            Console.WriteLine("Se han DEVUELTO " + TOTAL1 + " en caja");
            Console.WriteLine("============================");
            Console.WriteLine("1: Registrar más productos de GOLOSINAS ");
            Console.WriteLine("2: <- Regresar");
            Console.WriteLine("============================");
            Console.WriteLine("INGRESE UNA OPCION");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1: golosinasVendidos(); break;
                case 2: ejercicio3(); break;
            }

        }
        static void electronicosDevueltos()
        {
            Console.WriteLine("============================");
            Console.WriteLine("REGISTAR DEVOLUCION DE electrodomesticos:");
            Console.WriteLine("============================");
            Console.Write("Ingrese cantidad (unidades):");
            int UNIDADES = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            float PRECIO = float.Parse(Console.ReadLine());
            float TOTAL1;
            TOTAL1 = UNIDADES * PRECIO;
            Console.WriteLine("============================");
            Console.WriteLine("Se han REGRESADO " + UNIDADES + " unidades");
            Console.WriteLine("Se han DEVUELTO " + TOTAL1 + " en caja");
            Console.WriteLine("============================");
            Console.WriteLine("1: Registrar más productos de electrodomesticos ");
            Console.WriteLine("2: <- Regresar");
            Console.WriteLine("============================");
            Console.WriteLine("INGRESE UNA OPCION");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1: electronicosDevueltos(); break;
                case 2: ejercicio3(); break;
            }
        }
        static void ejercicio4()
        {
            int limpiezaVendidos = 0;
            double limpiezaVendidosTotal = 0;
            int abarrotesVendidos = 0;
            double abarrotesVendidosTotal = 0;
            int golosinasVendidos = 0;
            double golosinasVendidosTotal = 0;
            int electronicosVendidos = 0;
            double electronicosVendidosTotal = 0;

            int limpiezaDevueltos = 0;
            double limpiezaDevueltosTotal = 0;
            int abarrotesDevueltos = 0;
            double abarrotesDevueltosTotal = 0;
            int golosinasDevueltos = 0;
            double golosinasDevueltosTotal = 0;
            int electronicosDevueltos = 0;
            double electronicosDevueltosTotal = 0;

            while (true)
            {
                Console.WriteLine("==============================");
                Console.WriteLine("CERRAR CAJA");
                Console.WriteLine("==============================");
                Console.WriteLine("1: Mostrar estadísticas finales");
                Console.WriteLine("2: Regresar");
                Console.WriteLine("==============================");
                Console.WriteLine("Ingrese una opción");
                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:


                        Console.WriteLine("======================================");
                        Console.WriteLine("Estadísticas finales");
                        Console.WriteLine("======================================");

                        Console.WriteLine("Ventas por rubro:");
                        Console.WriteLine($"Limpieza: {limpiezaVendidos} unidades - Total: S/{limpiezaVendidosTotal}");
                        Console.WriteLine($"Abarrotes: {abarrotesVendidos} unidades - Total: S/{abarrotesVendidosTotal}");
                        Console.WriteLine($"Golosinas: {golosinasVendidos} unidades - Total: S/{golosinasVendidosTotal}");
                        Console.WriteLine($"Electrónicos: {electronicosVendidos} unidades - Total: S/{electronicosVendidosTotal}");

                        Console.WriteLine("Devoluciones por rubro:");
                        Console.WriteLine($"Limpieza: {limpiezaDevueltos} unidades - Total: S/{limpiezaDevueltosTotal}");
                        Console.WriteLine($"Abarrotes: {abarrotesDevueltos} unidades - Total: S/{abarrotesDevueltosTotal}");
                        Console.WriteLine($"Golosinas: {golosinasDevueltos} unidades - Total: S/{golosinasDevueltosTotal}");
                        Console.WriteLine($"Electrónicos: {electronicosDevueltos} unidades - Total: S/{electronicosDevueltosTotal}");

                        Console.WriteLine("Inventario y total en caja por rubro:");
                        Console.WriteLine($"Limpieza: {limpiezaVendidos - limpiezaDevueltos} unidades - Total en caja: S/{limpiezaVendidosTotal - limpiezaDevueltosTotal}");
                        Console.WriteLine($"Abarrotes: {abarrotesVendidos - abarrotesDevueltos} unidades - Total en caja: S/{abarrotesVendidosTotal - abarrotesDevueltosTotal}");
                        Console.WriteLine($"Golosinas: {golosinasVendidos - golosinasDevueltos} unidades - Total en caja: S/{golosinasVendidosTotal - golosinasDevueltosTotal}");
                        Console.WriteLine($"Electrónicos: {electronicosVendidos - electronicosDevueltos} unidades - Total en caja: S/{electronicosVendidosTotal - electronicosDevueltosTotal}");

                        double totalCajaGeneral = (limpiezaVendidosTotal + limpiezaDevueltosTotal) +
                                                    (abarrotesVendidosTotal + abarrotesDevueltosTotal) +
                                                    (golosinasVendidosTotal + golosinasDevueltosTotal) +
                                                    (electronicosVendidosTotal + electronicosDevueltosTotal);
                        Console.WriteLine("======================================");
                        Console.WriteLine($"Total en caja general: S/{totalCajaGeneral}");
                        Console.WriteLine("======================================");
                        Console.ReadKey();
                        break;
                    case 2:
                        Main();
                        break;
                }

            }
        }
    }
}


        