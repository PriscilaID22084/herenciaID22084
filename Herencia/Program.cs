﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia
{
    static class Program
    {
        /* Clase principal o clase papá qye guarda los metodos de lectura 
        de valores y almacenado de valores en variables*/
        //nombre de clase
        class operacion
        {
            //declaracion de variables que usa la clase
            //tipo de acceso            tipo de dato              nombre de dato
            protected                       int                     valor1;
            protected                       int                     valor2;
            protected                       int                     resultado;
        }
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
