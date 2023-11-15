using System;
using System.Collections;
namespace TPAlgoritmos_Constructora
{
	public class Grupo_Obrero
	{
		private Arraylist listaObreros;
		private int idobra;
		private int id_Grupo;
		
		public Grupo_Obrero_Obrero(int idobra,int id_Grupo)
		{
			this.idobra=idobra;
			this.id_Grupo=id_Grupo;
			listaObreros=new Arraylist();	

		}
		public IDobra{
			get{return idobra;}set{idobra=value;}
		}
		public ArrayList ListaObreros{
			get{return listaObreros;}
		}
		public int ID_Grupo{
			get{return id_Grupo;}set{id_Grupo=value;}
		}
		public ArrayList Listaobreros{
			get{return listaObreros;}
		}
		//crea una instancia de obrero, y la añade a la lista
		public void Agregar_Obrero(string nombre,string apellido,string cargo,double sueldo,int legajo,int dni){
			Obra Nuevo_obrero= new Obrero(nombre,apellido,cargo,sueldo,legajo,dni);
			listaObras.Add(Nuevo_obrero);
		}
		//muestra la cantidad de elementos en lista
		public void cantidad_Obreros(){
			listaObreros.Count();
		}
		//itera sobre lista,buscando en base a DNI, si existe=true,lo encontró
		public void buscar_Obrero(int dni){ 
			bool encontrado= false;
			foreach(Obrero obrero in listaObreros){
				if(obrero.DNI==dni){
					encontrado=true;
					Console.WriteLine("Obrero encontrado");
					break;
				}
			}
		}
		//itera sobre la lista de obreros,y llama al metodo imprimir
		public void mostrar_Obreros(){
			for(int i=0;i<listaObreros.Count;i++){
				listaObreros[i].imprimir();
			}
		}
		//itera sobre lista,buscando en base a DNI, si existe=true, elimina en indice
		public void eliminar_Obrero(int dni){ 
			bool existe=false;
			for(int i=0;i<listaObras.Count;i++){
				if(listaObreros[i].DNI==dni){
					existe=true;
					listaObreros.RemoveAt(i);
					break;
				}	
			}

		}
	}
}