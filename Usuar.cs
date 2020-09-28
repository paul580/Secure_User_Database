using System;

namespace PR1___Secure_User_Database
{
    class Usuario
    {
        string nombre { get; set; }
        string numeroId { get; set; }
        int[] claveNum { get; set; }
        string valides { get; set; }


        public Usuario(string nombre, string numeroId, int[] claveNum, string valides)
        {
            this.nombre = nombre;
            this.numeroId = numeroId;
            this.claveNum = claveNum;
            this.valides = valides;

        } 


         public string AgarrarNombre()
        {
            return nombre;
        }

        public string AgarrarNumeroId()
        {
            return numeroId;
        }

        public int[] AgarrarClaveNum()
        {
            return claveNum;
        }

        public string AgarrarValides()
        {
            return valides;
        }

    }
}