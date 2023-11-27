using System;
using TPAlgoritmos_Constructora;


using System.Collections;
namespace TPAlgoritmos_Constructora
{
    public class nohayobradisponible:Exception
    {
        private string message;
        public nohayobradisponible(string message):base(){
            this.message=message;
        }
    }
    public class EstadoNegativoException:Exception{
        private string mensaje;
        public EstadoNegativoException(string m):base(){
            mensaje=m;
        }
    }
    public class ObraNoEncontradaException : Exception
    {
        private string message;
        public ObraNoEncontradaException(string men):base()
        {
            message=men;
        }
    }
}