using System;
using TPAlgoritmos_Constructora;

namespace TPAlgoritmos_Constructora
{
	public class Obra
	{
	private string nombre_propietario,tipo_obra;
	private int dni_propietario,id,estado_avance,tiempoestimado_ejecucion;
	private double costo;
	private Jefe_Obrero jefe_Obra;
		public Obra(string nombre_p,string tipo_obra,int dni_p,int id,int estado_avance,int tiempo_ejecucion,double costo,Jefe_Obrero jefe_Obra)
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
		public string Nombre_propietario{
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
        public void ModificarEstadoAvance(int avance)
        {
            if (avance >= 0 && avance <= 100)
            {
				//if(avance>A_actual && A_actual<100)
                Estado_Avance = avance;

                if (Estado_Avance == 100)
                {
                    Console.WriteLine("�La obra ha finalizado!");
                    // Mueve la obra de la lista de obras en ejecuci�n a la lista de obras finalizadas
                    Empresa_Constructora.MoverObraAListaFinalizada(this);
                }
                else
                {
                    Console.WriteLine("Estado de avance modificado correctamente.");
                }
            }
            else
            {
                Console.WriteLine("Error: El estado de avance debe estar entre 0 y 100.");
            }
        }



    }
}
