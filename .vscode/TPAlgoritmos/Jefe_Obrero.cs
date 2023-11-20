using System;
using TPAlgoritmos_Constructora;

namespace TPAlgoritmos_Constructora
{
    public class Jefe_Obrero : Obrero
    {
        private double bono;
        private Grupo_Obrero grupo;
        public Jefe_Obrero(double bono, Grupo_Obrero grupo, string nom, string ape, string carg, double sueld, int legaj, int doc) : base(nom, ape, carg, sueld, legaj, doc)
        {
            this.bono = bono;
            this.grupo = grupo;
        }

        public double Bono
        {
            get { return bono; }
            set { bono = value; }
        }
        public Grupo_Obrero Grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }
        //metodo polimorfico imprimir, heredado de obrero
        public override void imprimir()
        {
            Console.WriteLine(string.Format("Nombre: {0} - Apellido: {1} - Cargo: {2} - Sueldo: ${3} - Legajo: {4} - DNI: {5} - Bono: ${6} - Grupo: {7}", nombre, apellido, cargo, sueldo, legajo, dni, bono, grupo));
        }
    }
}
