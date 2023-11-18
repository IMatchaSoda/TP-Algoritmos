/*
 * Creado por SharpDevelop.
 * Usuario: iori_
 /*Una empresa constructora tiene varias obras en ejecución y 8 grupos de obreros que trabajan en las
obras. De cada obra se conoce el nombre y dni del propietario, código interno (se lo asigna el
sistema), tipo de obra (construcción, remodelación, ampliación, etc.), el tiempo estimado de
ejecución (expresado en días), estado de avance (porcentaje), el jefe de obra y el costo. De cada
obrero se almacena su nombre y apellido, dni, nro legajo, sueldo y cargo (capataz, albañil, peón,
plomero, electricista, etc.). El jefe de obra es un obrero responsable de una obra por lo cual cobra
una bonificación especial a parte de su sueldo y dirige al grupo de obreros que trabajan en dicha
obra. De cada grupo de obreros se conoce el código de obra en la que están trabajando (0 en caso
de no estar asignado a ninguna obra) y los integrantes.
Se deberá desarrollar una aplicación, utilizando las clases que considere necesarias, utilizando
herencia cuando corresponda. La aplicación debe proveer, mediante un menú, las siguientes
funcionalidades:
a) Contratar un obrero nuevo (se agrega a la empresa y a un grupo)
b) Eliminar un obrero (se elimina de la empresa y de su grupo)
c) Submenú de impresión: listado de obreros, de obras en ejecución con más del 50% de
avance, de obras finalizadas y de jefes
d) Agregar una obra y asignarle un jefe. Se debe crear el jefe y asociarle el grupo de obreros
que va a dirigir. Verificar que haya grupo libre; en caso contrario se debe levantar una
excepción que informe lo sucedido.
e) Modificar el estado de avance de una obra. Si el estado de avance llega al 100% la obra debe
darse por finalizada, se elimina del listado de obras en ejecución y se guarda en el de obras
finalizadas
f) Dar de baja a un jefe (se elimina de la empresa, se desvincula de la obra y se libera el grupo
de obreros asignado)
*/
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TPAlgoritmos_Constructora;

namespace TPAlgoritmos_Constructora
{
    class Program
    {
        public static void Main(string[] args)
        {


            menu();
            Console.ReadKey(true);
        }
        public static void menu()
        {
            Empresa_Constructora e1 = new Empresa_Constructora("chupala kioscu");
            bool salir = false;
            string opcion, opcionL;
            int idob = 1;
            try
            {
                while (!salir)
                {

                    Console.WriteLine("************************************");
                    Console.WriteLine("elija una de las siguientes opciones:");
                    Console.WriteLine("************************************");
                    Console.WriteLine("a) Contratar un obrero nuevo");
                    Console.WriteLine("b) Eliminar un obrero ");
                    Console.WriteLine("c) Submenu Impresion ");//Submenu de impresion
                    Console.WriteLine("d) Agregar Obra. ");
                    Console.WriteLine("e) Modificar estado de avance de una obra. ");
                    Console.WriteLine("f) Dar de baja a un jefe.");
                    Console.WriteLine("g) Salir.");
                    Console.WriteLine("************************************");
                    opcion = Console.ReadLine();
                    opcionL = opcion.ToLower();
                    switch (opcionL)
                    {
                        //pedida de datos para creacion de obrero
                        case "a":
                            Console.Write("Nombre: ");
                            string nombre = Console.ReadLine();
                            Console.Write("Apellido: ");
                            string apellido = Console.ReadLine();
                            Console.Write("DNI: ");
                            int dni = int.Parse(Console.ReadLine());
                            Console.Write("Número de legajo: ");
                            int nroLegajo = int.Parse(Console.ReadLine());
                            Console.Write("Sueldo: ");
                            double sueldo = double.Parse(Console.ReadLine());
                            Console.WriteLine("ingrese Numero de grupo donde quiere asignar al obrero");
                            int id = int.Parse(Console.ReadLine());
                            Console.Write("Cargo: ");
                            string cargo = Console.ReadLine();
                            Obrero ob1 = new Obrero(nombre, apellido, cargo, sueldo, nroLegajo, dni);
                            ((Grupo_Obrero)e1.ListaGrupos[id]).ListaObreros.Add(ob1);
                            break;
                        case "b":
                            Console.Clear();
							e1.Mostrar_Grupo();
							Console.WriteLine("ingrese numero de grupo a consultar.");
							id=int.Parse(Console.ReadLine());
							((Grupo_Obrero)e1.ListaGrupos[id]).mostrar_Obreros();
							Console.WriteLine("ingrese documento del obrero a eliminar.");
							dni=int.Parse(Console.ReadLine());
							((Grupo_Obrero)e1.ListaGrupos[id]).eliminar_Obrero(dni);
                            break;
                        case "c":
                            Console.Clear();
                            Console.WriteLine("************************************");
                            Console.WriteLine("elija una de las siguientes opciones:");
                            Console.WriteLine("************************************");
                            Console.WriteLine("1)lista obreros");
                            Console.WriteLine("2)lista obras 50%+");
                            Console.WriteLine("3)lista obras finalizadas");
                            Console.WriteLine("4)jefes");
                            int op2 = int.Parse(Console.ReadLine());

                            switch (op2)
                            {
                                //lista de obreros
                                case 1:
                                    Console.Clear();
                                    if (e1.ListaGrupos.Count > 0)
                                    {
                                        e1.Mostrar_Grupo();
                                        Console.WriteLine("ingrese ID del grupo que desea consultar.");
                                        int idgrup = int.Parse(Console.ReadLine());
                                        e1.Buscar_Grupo(idgrup);
                                        foreach (Grupo_Obrero g in e1.ListaGrupos)
                                        {
                                            if (g.ID_Grupo == idgrup)
                                            {
                                                g.mostrar_Obreros();
                                            }
                                        }
                                    }

                                    break;
                                //Lista obras 50%+
                                case 2:
                                    Console.Clear();
                                    for (int i = 0; i < e1.ListaObras.Count; i++)
                                    {
                                        if (((Obra)e1.ListaObras[i]).Estado_Avance > 50)
                                        {
                                            Console.WriteLine(e1.ListaObras[i]);
                                        }
                                    }
                                    break;
                                //Obras Finalizadas
                                case 3:
                                    Console.Clear();
                                    e1.mostrar_ObrasF();   
                                    break;
                                //Lista de jefes
                                case 4:
                                    for (int j = 0; j < e1.ListaJefes.Count; j++)
                                    {
                                        ((Jefe_Obrero)e1.ListaJefes[j]).imprimir();
                                    }
                                    Console.Clear();
                                    break;
                            }

                            break;
                        case "d":
                            Console.Clear();
                            bool disponible = false;
                            Console.WriteLine("Nombre Propietario: ");
                            string nombreP = Console.ReadLine();
                            Console.WriteLine("DNI Propietario: ");
                            int dnip = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese tipo de obra: ");
                            string obratipo = Console.ReadLine();
                            Console.WriteLine("ingrese tiempo de ejecucion estimado: ");
                            int tiempo_ejecucion = int.Parse(Console.ReadLine());
                            Console.WriteLine("Costo de la obra: ");
                            double costo = double.Parse(Console.ReadLine());
                            Console.Write("Nombre: ");
                            nombre = Console.ReadLine();
                            Console.Write("Apellido: ");
                            apellido = Console.ReadLine();
                            Console.Write("DNI: ");
                            dni = int.Parse(Console.ReadLine());
                            Console.Write("Número de legajo: ");
                            nroLegajo = int.Parse(Console.ReadLine());
                            Console.Write("Sueldo: ");
                            sueldo = double.Parse(Console.ReadLine());
                            Console.WriteLine("ingrese Numero de grupo donde quiere asignar al obrero");
                            int idj = int.Parse(Console.ReadLine());
                            Console.Write("Cargo: ");
                            cargo = Console.ReadLine();
                            Console.Write("Bono x Cargo: ");
                            double bono = double.Parse(Console.ReadLine());
                            foreach (Grupo_Obrero g in e1.ListaGrupos)
                            {
                                if (g.IDobra == null)
                                {
                                    disponible = true;
                                    g.IDobra = idob;
                                    Jefe_Obrero j1 = new Jefe_Obrero(bono, g, nombre, apellido, cargo, sueldo, nroLegajo, dni);
									e1.Agregar_jefe(j1);
                                    e1.Agregar_Obra(nombreP, obratipo, dnip, idob, 0, tiempo_ejecucion, costo, j1);
									
                                    break;
                                }
                                if (!disponible)
                                {
                                    //throw new nohayobradisponible;
                                }

                            }

                            idob++;

                            break;
                        case "e":
                            Console.Clear();
                            Console.WriteLine("ingrese el Codigo de obra");
                            int obra = int.Parse(Console.ReadLine());
                            Console.WriteLine("ingrese el avance");
                            int avance = int.Parse(Console.ReadLine());


                            break;
                        case "f":
                            Console.Clear();

                            break;
                        case "g":
                            Console.Clear();
							Console.WriteLine("hasta la proxima.");
                            salir = true;
                            Thread.Sleep(2000);

                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("La opcion ingresada es inexistente, por favor trate de nuevo." + " " + "Espere a que reaparezca el menu.");
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                    }
                }
            }
            catch ()
            {

            }
        }

    }
}


