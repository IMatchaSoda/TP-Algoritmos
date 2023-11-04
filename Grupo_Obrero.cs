using System;
using System.Collections;
namespace TPAlgoritmos_Constructora
{
	public class Grupo_Obrero
	{
		private Arraylist listaObreros;
		private int idobra;
		private int id_Grupo;
		
		public Grupo_Obrero_Obrero(int idobra,int id_Grupo)
		{
			this.idobra=idobra;
			this.id_Grupo=id_Grupo;
			listaObreros=new Arraylist();	

		}
		public IDobra{
			get{return idobra;}set{idobra=value;}
		}
		public ArrayList ListaObreros{
			get{return listaObreros;}
		}
		public int ID_Grupo{
			get{return id_Grupo;}set{id_Grupo=value;}
		}
	}
}
