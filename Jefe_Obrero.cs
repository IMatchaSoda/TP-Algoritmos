using System;

namespace TPAlgoritmos_Constructora
{
	public class Jefe_Obrero:Obrero
	{
		private double bono;
		Grupo_Obrero grupo;
		public Jefe_Obrero(double bono,Grupo_Obrero grupo,string nom,string ape,string carg,double sueld,int legaj,int doc):base(nom,ape,carg,sueld,legaj,doc)
		{
			this.bono=bono;
			this.grupo=grupo;
		}

		public double Bono{
			get{return bono;}set{bono=value;}
		}
		public Grupo_Obrero Grupo{
			get{return grupo;}set{grupo=value;}
		}
		
	}
}
