using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_exposicion
{
    //herencia
     class Radio: Noticiero
    {
        // se recibe una cadena y la mandamos al constructor de la clase padre
        public Radio (string pMensaje) : base(pMensaje)
        {
            
        }
        // primera prueba 
        // su propia muestra 
        /*public new void Muestra()
        {
            Console.WriteLine("desde la radio : {0}", mensaje);
        }
        */
        // es valido pero pierde la funcionalidad de la clase padre por que se usa la clase hija 
        public override void Muestra()
        {
            Console.WriteLine(" desde el radio : {0} ", mensaje);
        }

    }
}
