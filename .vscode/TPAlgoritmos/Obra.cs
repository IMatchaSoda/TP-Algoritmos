using System;

namespace TPAlgoritmos_Constructora
{
	public class Obra
	{
	string nombre_propietario,tipo_obra;
	int dni_propietario,id,estado_avance,tiempoestimado_ejecucion;
	double costo;
	Jefe_Obrero jefe_Obra;
		public Obra(string nombre_p,string tipo_obra,int dni_p,int id,int estado_avance,int tiempo_ejecucion,double costo,Jefe_Obra jefe_Obra)
		{
			nombre_p=nombre_propietario;
			this.tipo_obra=tipo_obra;
			dni_p=dni_propietario;
			this.id=id;
			this.estado_avance=estado_avance;
			tiempo_ejecucion=tiempoestimado_ejecucion;
			this.costo=costo;
			this.jefe_Obra=jefe_Obra;
		}
		public string nombre_propietario{
			get{return nombre_propietario;}set{nombre_propietario=value;}
		}
		public string Tipo_Obra{
			get{return tipo_obra;}set{tipo_obra=value;}
		}
		public int DNI_Propietario{
			get{return dni_propietario;}set{dni_propietario=value;}
		}
		public int ID{
			get{return id;}set{id=value;}
		}
		public int Estado_Avance{
			get{return estado_avance;}set{estado_avance=value;}
		}
		public int Tiempo_Ejecucion{
			get{return tiempoestimado_ejecucion;}set{tiempoestimado_ejecucion=value;}
		}
		public double Costo{
			get{return costo;}set{costo=value;}
		}
		public Jefe_Obrero Jefede_Obra{
			get{return jefe_Obra;}set{jefe_Obra=value;}
		}
		


	}
}
