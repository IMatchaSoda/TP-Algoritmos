using System;
using TPAlgoritmos_Constructora;


using System.Collections;
namespace TPAlgoritmos_Constructora
{
    public class Grupo_Obrero
    {
        private ArrayList listaObreros;
        private int idobra;
        private int id_Grupo;

        public Grupo_Obrero(int idobra, int id_Grupo)
        {
            this.idobra = idobra;
            this.id_Grupo = id_Grupo;
            listaObreros = new ArrayList();

        }
        public int IDobra
        {
            get { return idobra; }
            set { idobra = value; }
        }
        public ArrayList ListaObreros
        {
            get { return listaObreros; }
        }
        public int ID_Grupo
        {
            get { return id_Grupo; }
            set { id_Grupo = value; }
        }
        //crea una instancia de obrero, y la añade a la lista
        public void Agregar_Obrero(Obrero Nuevo_obrero)
        {
            listaObreros.Add(Nuevo_obrero);
        }
        //muestra la cantidad de elementos en lista
        public int cantidad_Obreros()
        {
            return listaObreros.Count;
        }
        //itera sobre lista,buscando en base a DNI
        public Obrero buscar_Obrero(int dni)
        {

            foreach (Obrero obrero in listaObreros)
            {
                if (obrero.DNI == dni)
                {
                    return obrero;
                }
            }
            return null;
        }
        public Jefe_Obrero BuscarJefe(int dni)
        {
            foreach (Jefe_Obrero J in listaObreros)
            {
                if (J.DNI == dni)
                {
                    return J;
                }
            }
            return null;
        }
        //itera sobre la lista de obreros,y llama al metodo imprimir
        public void mostrar_Obreros()
        {
            foreach(Obrero ob in listaObreros) 
            {
                ob.imprimir();
            }
        }
        //itera sobre lista,buscando en base a DNI, elimina en indice
        public void Eliminar_Obrero(Obrero obrero)
        {
            for (int i = 0; i < listaObreros.Count; i++)
            {
                listaObreros.Remove(obrero);
            }

        }
    }
}
