using System;
using System.Collections;



namespace TPAlgoritmos_Constructora
{

    public class Empresa_Constructora
    {
        //Atributos
        private string empresa_nombre;
        private ArrayList listaObras;
        private ArrayList listaGrupos;
        private ArrayList ListaObrasFinalizadas;
		//private ArrayList lista_jefes;
        //Constructor
        public Empresa_Constructora(string empresa_nombre)
        {
            this.empresa_nombre = empresa_nombre;
            listaObras = new ArrayList();
            listaGrupos = new ArrayList();
			ListaObrasFinalizadas= new ArrayList();
			//lista_jefes= new ArrayList();
            for (int i = 1; i <= 8; i++) //crea los 8 grupos
            {
                listaGrupos.Add(new Grupo_Obrero(0, i));
            }
        }
        //Metodos

        public string EmpresaNombre
        {
            get { return empresa_nombre; }
            set { empresa_nombre = value; }
        }
        public ArrayList ListaObras
        {
            get { return listaObras; }
        }
        public ArrayList ListaGrupos
        {
            get { return listaGrupos; }
        }
		/*
        public ArrayList ListaJefes
        {
            get { return lista_jefes; }
        } */
		public ArrayList ListaObras_Finalizadas{
			get{return ListaObrasFinalizadas;}
		}

        //Agregar,Buscar,Eliminar,Listar,largo de lista(cantidad).(son 5 por lista)
        public void Agregar_Obra(Obra obra)
        {
            listaObras.Add(obra);
        }
        public int cantidad_Obras()
        {
            return listaObras.Count;
        }
        public Obra Buscar_Obra(int ID)
        {
            foreach (Obra obra in listaObras)
            {
                if (obra.ID == ID)
                {
                    return obra;
                }
            }
            return null;
        }
        public void Mostrar_Obras()
        {
            for (int i = 0; i < listaObras.Count; i++)
            {
                Console.WriteLine(listaObras[i].ToString());
            }
        }
        public void Eliminar_Obra(int id)
        {

            for (int i = 0; i < ListaObras.Count; i++)
            {
                if (((Obra)listaObras[i]).ID == id)
                {
                    listaObras.RemoveAt(i);
                    break;
                }
            }

        }
        public void Agregar_Grupo(Grupo_Obrero grupo)
        {
            listaGrupos.Add(grupo);
        }
        public void Mostrar_Grupo()
        {
            
            foreach(Grupo_Obrero grupo in listaGrupos)
            {
                
                Console.WriteLine(grupo.ToString());
                  
            }
        }
        public void Eliminar_Grupo(int ID_Grupo)
        {

            for (int i = 0; i < listaGrupos.Count; i++)
            {
                if (((Grupo_Obrero)listaGrupos[i]).ID_Grupo == ID_Grupo)

                    listaGrupos.RemoveAt(i);
                break;
            }
        }

        public Grupo_Obrero Buscar_Grupo(int dni)
        {
            foreach (Grupo_Obrero grupo in listaGrupos)
            {
                foreach(Obrero o in grupo.ListaObreros){
                    if(o.DNI==dni){
                        return grupo;
                    }
                    
                }
                foreach(Jefe_Obrero j in grupo.ListaObreros)
                {
                    if (j.DNI == dni)
                    {
                        return grupo;
                    }
                }
            }
            return null;
        }
		public void mostrar_ObrasF()
        {
            for (int i = 0; i < ListaObras_Finalizadas.Count; i++)
            {
                Console.WriteLine(ListaObras_Finalizadas[i].ToString());
            }
        }
        
        

    }
}

