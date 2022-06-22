using System;
namespace ejemplo_exposicion{
    class Program
    {
        static void Main(string[] args) {
            // primera prueba con new
            Noticiero miNoticiero = new Noticiero("hola todos");
            miNoticiero.Muestra();

            Radio miRadio = new Radio("como estan");
            miRadio.Muestra();

            Console.WriteLine("---------");

            // sustituimos la clase hija y vemos como se comportan
            // una instacia de radio puede se referencada por una variable de tipo noticiero
            //noticiero guarda a radio
            Noticiero sustitucion = new Radio("estamos probando");
            sustitucion.Muestra();



        }
    }   
    

    }
