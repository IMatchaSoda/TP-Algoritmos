using System;
using System.Collections;
using TPAlgoritmos_Constructora;


namespace TPAlgoritmos_Constructora
{
	
	public class Empresa_Constructora
	{
		//Atributos
		private string empresa_nombre; 
		private ArrayList listaObras;
		private ArrayList listaGrupos;
	 	private ArrayList ListaObrasFinalizadas();
		//Constructor
		public Empresa_Constructora(string empresa_nombre)
		{
			this.empresa_nombre=empresa_nombre;
			listaObras= new ArrayList();
			listaGrupos= new ArrayList();
            ListaObrasFinalizadas= new ArrayList();
			for (int i = 1; i <= 8; i++) //crea los 8 grupos
        {
                listaGrupos.Add(new Grupo_Obrero(0,i));
            }
		}
		//Metodos

		public string EmpresaNombre{
			get{return empresa_nombre;}
			set{empresa_nombre=value;}
		}
		public ArrayList ListaObras{
			get{return listaObras;}
		}
		public ArrayList ListaGrupos{
			get{return listaGrupos;}
		}

		//Agregar,Buscar,Eliminar,Listar,largo de lista(cantidad).(son 5 por lista)
		public void Agregar_Obra(string nombre_p,string tipo_obra,int dni_p,int id,int estado_avance,int tiempo_ejecucion,double costo,Jefe_Obrero jefe_Obra)
		{
			Obra Nueva_Obra= new Obra(nombre_p,tipo_obra,dni_p,id,estado_avance,tiempo_ejecucion,costo, jefe_Obra);
			listaObras.Add(Nueva_Obra);
		}
		public void cantidad_Obras()
		{
			
			Console.WriteLine("cantidad de obras: {0}",listaObras.Count);
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
			
			for(int i=0;i<listaObras.Count;i++){
				if(listaObras[i].ID==id)
				{
					listaObras.RemoveAt(i);
					break;
				}	
			}

		}
		public void Agregar_Grupo(Grupo_Obrero grupo){
			listaGrupos.Add(grupo);
		}
		public void Mostrar_Grupo()
		{
			for(int i=0;i<listaGrupos.Count;i++){
				Console.WriteLine(listaGrupos[i].ToString());
			}
		}
		public void Eliminar_Grupo(int ID_Grupo){
			
			for(int i=0;i<listaGrupos.Count;i++)
			{
                if (((Grupo_Obrero)listaGrupos[i]).ID_Grupo == ID_Grupo)

                    listaGrupos.RemoveAt(i);
					break;
				}	
			}
		}
		public void Buscar_Grupo(int ID_Grupo){
			bool encontrado= false;
			foreach(Grupo_Obrero grupo in listaGrupos)
        {
				if(grupo.ID_Grupo==ID_Grupo){
					encontrado=true;
					Console.WriteLine("Grupo encontrada");
					break;
				}
			}
		}
    public static void MoverObraAListaFinalizada(Obra obra)
    {
        // mueve a lista de obras finalizadas
        ListaObrasFinalizadas.Add(obra);

        // Elimina la obra de la lista de obras en ejecución
        ListaObras.Remove(obra);
    }


}
}
