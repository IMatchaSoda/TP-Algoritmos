using System;
using TPAlgoritmos_Constructora;

namespace TPAlgoritmos_Constructora
{

    public class Obrero
    {
        protected string nombre, apellido, cargo;
        protected double sueldo;
        protected int legajo, dni;
        public Obrero(string nombre, string apellido, string cargo, double sueldo, int legajo, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cargo = cargo;
            this.sueldo = sueldo;
            this.legajo = legajo;
            this.dni = dni;
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        public double Sueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }
        public int Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }
        public int DNI
        {
            get { return dni; }
            set { dni = value; }
        }
        //Metodo polimorfico imprimir,heredable a jefe_obrero
        public virtual void imprimir()
        {
            Console.WriteLine("nombre:{0}-apellido:{1}--cargo:{2}--sueldo:{3}--Legajo:{4}--DNI:{5}", nombre, apellido, cargo, sueldo, legajo, dni);
        }
    }
}
