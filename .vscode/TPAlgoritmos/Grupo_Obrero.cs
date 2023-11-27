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
        public void Agregar_Obrero(string nombre, string apellido, string cargo, double sueldo, int legajo, int dni)
        {
            Obrero Nuevo_obrero = new Obrero(nombre, apellido, cargo, sueldo, legajo, dni);
            listaObreros.Add(Nuevo_obrero);
        }
        //muestra la cantidad de elementos en lista
        public void cantidad_Obreros()
        {
            Console.WriteLine(listaObreros.Count);
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
        //itera sobre la lista de obreros,y llama al metodo imprimir
        public void mostrar_Obreros()
        {
            for (int i = 0; i < listaObreros.Count; i++)
            {
                ((Obrero)listaObreros[i]).imprimir();
            }
        }
        //itera sobre lista,buscando en base a DNI, si existe=true, elimina en indice
        public void eliminar_Obrero(Obrero obrero)
        {
            for (int i = 0; i < listaObreros.Count; i++)
            {
                listaObreros.Remove(obrero);
            }

        }
    }
}
