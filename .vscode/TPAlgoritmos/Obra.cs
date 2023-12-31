using System;
using TPAlgoritmos_Constructora;

namespace TPAlgoritmos_Constructora
{
    public class Obra
    {
        private string nombre_propietario, tipo_obra;
        private int dni_propietario, id, estado_avance, tiempoestimado_ejecucion;
        private double costo;
        private Jefe_Obrero jefe_Obra;
        public Obra(string nombre_p, string tipo_obra, int dni_p, int id, int estado_avance, int tiempo_ejecucion, double costo, Jefe_Obrero jefe_Obra)
        {
            nombre_propietario= nombre_p ;
            this.tipo_obra = tipo_obra;
            dni_propietario= dni_p ;
            this.id = id;
            this.estado_avance = estado_avance;
            tiempoestimado_ejecucion=tiempo_ejecucion ;
            this.costo = costo;
            this.jefe_Obra = jefe_Obra;
        }
        public string Nombre_propietario
        {
            get { return nombre_propietario; }
            set { nombre_propietario = value; }
        }
        public string Tipo_Obra
        {
            get { return tipo_obra; }
            set { tipo_obra = value; }
        }
        public int DNI_Propietario
        {
            get { return dni_propietario; }
            set { dni_propietario = value; }
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public int Estado_Avance
        {
            get { return estado_avance; }
            set { estado_avance = value; }
        }
        public int Tiempo_Ejecucion
        {
            get { return tiempoestimado_ejecucion; }
            set { tiempoestimado_ejecucion = value; }
        }
        public double Costo
        {
            get { return costo; }
            set { costo = value; }
        }
        public Jefe_Obrero Jefede_Obra
        {
            get { return jefe_Obra; }
            set { jefe_Obra = value; }
        }
        public override string ToString()
{
    
    return "Nombre:"+Nombre_propietario+"--Tipo de obra:"+Tipo_Obra+"--DNI Propietario:"+DNI_Propietario+"--ID:"+ID+"--Estado de Avance:"+Estado_Avance+"--Tiempo estimado de ejecucion:"+Tiempo_Ejecucion+ "--Costo:"+Costo+"--Jefe a cargo:"+Jefede_Obra.Nombre+"";
}



    }
}
