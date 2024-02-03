using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Flashy_thing
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            int x = 0;
            String Poem = "";
            while (x < 4)
            {
                Poem = Poem + "a";
                if(x < 1)//Fix
                {
                    Poem = Poem + " ";
                }
                Poem = Poem + "n";
                if (x > 1)
                {
                    Poem = Poem + " oyster";
                    x = x + 2;//Falta algo
                }
                if(x == 1)//Fix
                {
                    Poem = Poem + "noys ";
                }
                if(x < 1)
                {
                    Poem = Poem + "oise ";
                }
                x = x + 1;
            }
            MessageBox.Show(Poem);

            //Second
            x = 0;
            Poem = "";
            while (x < 4)
            {
                Poem = Poem + "a";
                if (x < 1)//Fix
                {
                    Poem = Poem + " ";
                }
                Poem = Poem + "n";
                if (x > 1)
                {
                    Poem = Poem + " oyster";
                    x = x + 2;//Falta algo
                }
                if (x == 1)//Fix
                {
                    Poem = Poem + "noys ";
                }
                if (x < 1)
                {
                    Poem = Poem + "oise ";
                }
                x = x + 1;
            }
            MessageBox.Show(Poem);
        }
    }
}
