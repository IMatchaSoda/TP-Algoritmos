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
		private ArrayList lista_jefes;
        //Constructor
        public Empresa_Constructora(string empresa_nombre)
        {
            this.empresa_nombre = empresa_nombre;
            listaObras = new ArrayList();
            listaGrupos = new ArrayList();
			ListaObrasFinalizadas= new ArrayList();
			lista_jefes= new ArrayList();
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
		public ArrayList ListaJefes
        {
            get { return lista_jefes; }
        }
		public ArrayList ListaObras_Finalizadas{
			get{return ListaObrasFinalizadas;}
		}

        //Agregar,Buscar,Eliminar,Listar,largo de lista(cantidad).(son 5 por lista)
        public void Agregar_Obra(string nombre_p, string tipo_obra, int dni_p, int id, int estado_avance, int tiempo_ejecucion, double costo, Jefe_Obrero jefe_Obra)
        {
            Obra Nueva_Obra = new Obra(nombre_p, tipo_obra, dni_p, id, estado_avance, tiempo_ejecucion, costo, jefe_Obra);
            listaObras.Add(Nueva_Obra);
        }
        public void cantidad_Obras()
        {

            Console.WriteLine("cantidad de obras: {0}", listaObras.Count);
        }
        public void buscar_Obra(int ID)
        {
            foreach (Obra obra in listaObras)
            {
                if (obra.ID == ID)
                {
                    Console.WriteLine("Obra encontrada");
                    break;
                }
            }
        }
        public void mostrar_Obras()
        {
            for (int i = 0; i < listaObras.Count; i++)
            {
                Console.WriteLine(listaObras[i].ToString());
            }
        }
        public void eliminar_Obra(int id)
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
            for (int i = 0; i < listaGrupos.Count; i++)
            {
                Console.WriteLine(listaGrupos[i].ToString());
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

        public void Buscar_Grupo(int ID_Grupo)
        {
            foreach (Grupo_Obrero grupo in listaGrupos)
            {
                if (grupo.ID_Grupo == ID_Grupo)
                {
                    Console.WriteLine("Grupo encontrado");
                    break;
                }
            }
        }
public void ModificarEstadoAvance(int idObra, int avance,Empresa_Constructora empresa)
{
    Obra obraAModificar = null;

    // Busca la obra en la lista basándote en el ID
    foreach (Obra obra in ListaObras)
    {
        if (obra.ID == idObra)
        {
            obraAModificar = obra;
            break;
        }
    }
    // Verifica si se encontró la obra
    if (obraAModificar != null)
    {
        // Modifica el estado de avance de la obra encontrada
        if (avance >= 0 && avance <= 100)
        {
            obraAModificar.Estado_Avance = avance;

            if (avance == 100)
            {
                Console.WriteLine("¡La obra ha finalizado!");
                // Mueve la obra de la lista de obras en ejecución a la lista de obras finalizadas
               	// mueve a lista de obras finalizadas
    			ListaObrasFinalizadas.Add(obraAModificar);

   	 			// Elimina la obra de la lista de obras en ejecución
    			listaObras.Remove(obraAModificar);
            }
            else
            {
                Console.WriteLine("Estado de avance modificado correctamente: {obraAModificar.Estado_Avance}%.");
            }
        }
        else
        {
            Console.WriteLine("Error: El estado de avance debe estar entre 0 y 100.");
        }
    }
    else
    {
        Console.WriteLine("Error: No se encontró una obra con el ID especificado.");
    }
}
        public void MoverObraAListaFinalizada(Obra obra)
        {
            // mueve a lista de obras finalizadas
            ListaObrasFinalizadas.Add(obra);

            // Elimina la obra de la lista de obras en ejecuci�n
            ListaObras.Remove(obra);
        }
		public void mostrar_ObrasF()
        {
            for (int i = 0; i < ListaObras_Finalizadas.Count; i++)
            {
                Console.WriteLine(ListaObras_Finalizadas[i].ToString());
            }
        }
		public void Agregar_jefe(Jefe_Obrero Nuevo_jefe)
        { 
            lista_jefes.Add(Nuevo_jefe);
        }
        public void cantidad_Jefes()
        {

            Console.WriteLine("cantidad de jefes: {0}", listaObras.Count);
        }
        public void buscar_Jefe(int nroLegajo)
        {
            foreach (Jefe_Obrero jefe in lista_jefes)
            {
                if (jefe.Legajo == nroLegajo)
                {
                    Console.WriteLine("Jefe encontrado");
                    break;
                }
            }
        }
        public void mostrar_Jefes()
        {
            for (int i = 0; i < lista_jefes.Count; i++)
            {
                Console.WriteLine(lista_jefes[i].ToString());
            }
        }
        public void eliminar_Jefe(int nroLegajo)
        {

            for (int i = 0; i < ListaObras.Count; i++)
            {
                if (((Jefe_Obrero)lista_jefes[i]).Legajo == nroLegajo)
                {
                    lista_jefes.RemoveAt(i);
                    break;
                }
            }

        }

    }
}

