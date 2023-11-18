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
}