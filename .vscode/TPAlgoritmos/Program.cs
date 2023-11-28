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
using System.Net;
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
			Obra obra1 = new Obra("Propietario1", "Construcción", 12345678, 1, 30, 60, 100000, null);
            Obra obra2= new Obra("Propietario2", "Remodelación", 87654321, 2, 60, 45, 80000, null);
			e1.Agregar_Obra(obra1);
			e1.Agregar_Obra(obra2);
            ((Grupo_Obrero)e1.ListaGrupos[0]).Agregar_Obrero(new Jefe_Obrero(5000, (Grupo_Obrero)e1.ListaGrupos[0], "Ricardio", "nahuehasd", "Capataz", 8000, 101, 11111111));
            ((Grupo_Obrero)e1.ListaGrupos[1]).Agregar_Obrero(new Jefe_Obrero(6000, (Grupo_Obrero)e1.ListaGrupos[1], "Panfilo", "jsoejose", "Capataz", 9000, 102, 22222222));

            Obrero o = new Obrero("Marta", "Nast", "Plomero", 5500, 204, 66666666);
            ((Grupo_Obrero)e1.ListaGrupos[0]).Agregar_Obrero(o);
            Obrero o1 = new Obrero("Rogelio", "Rigolleau", "Albañil", 5000, 201, 33333333);
            ((Grupo_Obrero)e1.ListaGrupos[0]).Agregar_Obrero(o1);
            Obrero o2 = new Obrero("Olga", "cossetini", "Peón", 4000, 202, 44444444);
            ((Grupo_Obrero)e1.ListaGrupos[1]).Agregar_Obrero(o2);
            Obrero o3 = new Obrero("obrero ", "ape ", "Electricista", 6000, 203, 55555555);
            ((Grupo_Obrero)e1.ListaGrupos[1]).Agregar_Obrero(o3);

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
							Console.WriteLine("Ingrese Cargo: ");
							string cargo = Console.ReadLine();
							if(cargo=="jefe"){
								Console.Write("Bono x Cargo: ");
								double bonoo = double.Parse(Console.ReadLine());
								
							}
							Obrero ob1 = new Obrero(nombre, apellido, cargo, sueldo, nroLegajo, dni);
							((Grupo_Obrero)e1.ListaGrupos[id]).Agregar_Obrero(ob1);
							break;
						case "b":
							Console.Clear();
							e1.Mostrar_Grupo();														
							Console.WriteLine("ingrese documento del obrero a eliminar.");
							dni=int.Parse(Console.ReadLine());
							Grupo_Obrero gr=e1.Buscar_Grupo(dni);
							Obrero obr=gr.buscar_Obrero(dni);
							gr.Eliminar_Obrero(obr);
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
										foreach (Grupo_Obrero g in e1.ListaGrupos)
										{ 
										g.mostrar_Obreros();
										}
									
									}
									Console.ReadKey();
									break;
								//Lista obras 50%+
								case 2:
									Console.Clear();
									for (int i = 0; i < e1.ListaObras.Count; i++)
									{
										if (((Obra)e1.ListaObras[i]).Estado_Avance > 50)
										{
                                            Console.WriteLine("id de obra: " + ((Obra)e1.ListaObras[i]).ID);
                                        }
									}
									Console.ReadKey();
									break;
								//Obras Finalizadas
								case 3:
									Console.Clear();
									e1.mostrar_ObrasF();									
									break;
								//Lista de jefes
								case 4:
									foreach(Obra Obra  in e1.ListaObras){
										if(Obra.Jefede_Obra!=null){
											Obra.Jefede_Obra.imprimir();
										}
									}
									Console.Clear();
									break;
							}

							break;
						case "d":
							Console.Clear();
							bool disponible = false;
							Console.Write("Nombre Propietario: ");
							string nombreP = Console.ReadLine();
							Console.Write("DNI Propietario: ");
							int dnip = int.Parse(Console.ReadLine());
							Console.Write("Ingrese tipo de obra: ");
                            string obratipo = Console.ReadLine();
							Console.Write("ingrese tiempo de ejecucion estimado (en dias): ");
                            int tiempo_ejecucion = int.Parse(Console.ReadLine()); Console.WriteLine();
							Console.Write("Costo de la obra: ");
                            double costo = double.Parse(Console.ReadLine());; Console.WriteLine();
							Console.Write("Nombre: ");
                            nombre = Console.ReadLine(); Console.WriteLine();
							Console.WriteLine("Apellido: ");
                            apellido = Console.ReadLine();Console.WriteLine();
							Console.WriteLine("DNI: "); 
                            dni = int.Parse(Console.ReadLine()); Console.WriteLine();
							Console.WriteLine("Número de legajo: ");
                            nroLegajo = int.Parse(Console.ReadLine()); Console.WriteLine();
                            Console.WriteLine("Sueldo: ");
							sueldo = double.Parse(Console.ReadLine()); Console.WriteLine();
                            Console.WriteLine("Cargo: ");
							cargo = Console.ReadLine(); Console.WriteLine();
                            Console.WriteLine("Bono x Cargo: ");
							double bono = double.Parse(Console.ReadLine());
							foreach (Grupo_Obrero g in e1.ListaGrupos)
							{
								if (g.IDobra == null)
								{
									disponible = true;
									g.IDobra = idob;
									Jefe_Obrero j1 = new Jefe_Obrero(bono, g, nombre, apellido, cargo, sueldo, nroLegajo, dni);
									g.Agregar_Obrero(j1);
									Obra nueva_obra= new Obra(nombreP, obratipo, dnip, idob, 0, tiempo_ejecucion, costo, j1);
									e1.Agregar_Obra(nueva_obra);
									
									break;
								}
								// no hay grupo dispobnible y no se puede setear la obra. 
								if (!disponible)
								{
									throw new nohayobradisponible("no hay grupo de tabajadores disponible en este momento");
								}

							}

							idob++;

							break;
						case "e":
                            Console.Clear();
                            Console.WriteLine("Ingrese el Código de Obra:");
                            int codigoObra = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el Nuevo Avance:");
                            int nuevoAvance = int.Parse(Console.ReadLine());
							Obra OAMod= e1.Buscar_Obra(codigoObra);
							foreach(Obra ob in e1.ListaObras){
								if(ob.ID==codigoObra){
									if (OAMod.Estado_Avance >= 0 && OAMod.Estado_Avance <= 100)
									{
									ob.Estado_Avance=nuevoAvance;
									Console.WriteLine("Estado de avance modificado correctamente: {obraAModificar.Estado_Avance}%.");
									}
								}
								else
								{
                                throw new ObraNoEncontradaException($"La obra con ID {codigoObra} no fue encontrada.");
								}	
							}
							if (OAMod.Estado_Avance >= 0 && OAMod.Estado_Avance <= 100)
        		{
            		OAMod.Estado_Avance = nuevoAvance;
            		if (OAMod.Estado_Avance == 100)
            		{
    				// Mueve la obra de la lista de obras en ejecución a la lista de obras finalizadas
    				e1.ListaObras_Finalizadas.Add(OAMod);
   	 				// Elimina la obra de la lista de obras en ejecución
    				e1.ListaObras.Remove(OAMod);
            		}	
        		}
                else
                {
                    throw new EstadoNegativoException("El estado de avance no puede ser menor que 0 ni mayor que 100");
                }
							break;                                                       
                        case "f":
							Console.Clear();
                            Console.WriteLine("Ingrese el número de DNI del jefe que desea dar de baja:");
                            int DNI = int.Parse(Console.ReadLine());
							Grupo_Obrero grupo= e1.Buscar_Grupo(DNI);
							Jefe_Obrero jefe = grupo.BuscarJefe(DNI);
							if (jefe != null)
							{
								Console.WriteLine("asdasd");
								Obra obra=e1.Buscar_Obra(grupo.IDobra);
								obra.Jefede_Obra = null;
								//se desliga el grupo de la obra 
								grupo.IDobra = 0;
								//elimina al jefe de la empresa
								grupo.Eliminar_Obrero(jefe);

							}
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
			catch (nohayobradisponible n)
			{
				Console.WriteLine(n.Message);
			}
			catch(EstadoNegativoException e)
			{
				Console.WriteLine(e.Message);
			}
			catch(FormatException)
			{ 
				Console.WriteLine("ingrese un tipo correcto de dato."); 
			}
			catch (NullReferenceException) 
			{
				Console.WriteLine("datos no encontrados. intente nuevamente.");
			}
			catch (Exception ex)
            {
            	Console.WriteLine(ex.Message);
            }
			

        }
	}
}


