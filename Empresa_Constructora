using System;
using System.Collections;

namespace TPAlgoritmos_Constructora
{
	
	public class Empresa_Constructora
	{
		//Atributos
		private string empresa_nombre; 
		ArrayList listaObras;
		ArrayList listaGrupos;
	 	//Arraylist ListaObras_100%();
		//Constructor
		public Empresa_Constructora(string empresa_nombre)
		{
			this.empresa_nombre=empresa_nombre;
			listaObras= new ArrayList();
			listaGrupos= new ArrayList();
			for (int i = 1; i <= 8; i++) //crea los 8 grupos
        {
            lista_grupos.Add(new Grupo_Obreros(i));
        }
		}
		//Metodos

		Public string EmpresaNombre{
			get{return empresa_nombre;}
			set{empresa_nombre=value;}
		}
		public Arraylist ListaObras{
			get{return listaObras;}

		}
		public ArrayList ListaGrupos{
			get{return listaGrupos;}
		}

		//Agregar,Buscar,Eliminar,Listar,largo de lista(cantidad).(son 5 por lista)
		public void Agregar_Obra(string nombre_p,string tipo_obra,int dni_p,int id,int estado_avance,int tiempo_ejecucion,double costo,Jefe_Obra jefe_Obra){
			Obra Nueva_Obra= new Obra(nombre_p,tipo_obra,dni_p,id,estado_avance,tiempo_ejecucion,costo,jefe_Obra);
			listaObras.Add(Nueva_Obra);
		}
		public void cantidad_Obras(){
			listaObras.Count();
		}
		public void buscar_Obra(int ID){
			bool encontrado= false;
			foreach(Obra obra in listaObras){
				if(obra.ID==ID){
					encontrado=true;
					Console.WriteLine("Obra encontrada");
					break;
				}
			}
		}
		public void mostrar_Obras(){
			for(int i=0;i<listaObras.Count;i++){
				Console.WriteLine(listaObras[i].ToString());
			}
		}
		public void eliminar_Obra(int id){
			bool existe=false;
			for(int i=0;i<listaObras.Count;i++){
				if(listaObras[i].ID==id){
					existe=true;
					listaObras.RemoveAt(i);
					break;
				}	
			}

		}
		public void Agregar_Grupo(Grupo_Obrero grupo){
			listaGrupos.Add(grupo);
		}
		public void Mostrar_Grupo(){
			for(int i=0;i<listaGrupos.Count;i++){
				Console.WriteLine(listaGrupos[i].ToString());
			}
		}
		public void Eliminar_Grupo(ID_Grupo){
			bool existe=false;
			for(int i=0;i<listaGrupos.Count;i++){
				if(listaGrupos[i].ID_Grupo==ID_Grupo;){
					existe=true;
					listaGrupos.RemoveAt(i);
					break;
				}	
			}
		}
		public void buscar_Grupo(int ID_Grupo){
			bool encontrado= false;
			foreach(Grupo_Obrero grupo in listaGrupos){
				if(grupo.ID_Grupo==ID_Grupo){
					encontrado=true;
					Console.WriteLine("Grupo encontrada");
					break;
				}
			}
		}

		
		
	}
}
