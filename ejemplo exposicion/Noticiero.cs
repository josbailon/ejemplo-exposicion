using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_exposicion
{
    //clase padre 
    class Noticiero
        //ponemos un string
    {
        protected string mensaje;
        // constructor en el que recivimos una cadena del exterior y la ponemos en la variable interna 
        public Noticiero (string pMensaje)
        {
            mensaje = pMensaje;
        }
        //primera prueba 
       /* public void Muestra()
        {
            Console.WriteLine("desde el noticiero", mensaje);
        }
       */
       // segunda prueba

        public virtual void Muestra()
        {
            Console.WriteLine(" desde el noticiero : {0}", mensaje);
        }
    }
}
