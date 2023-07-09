using System;
using System.Drawing;
using System.Windows.Forms;

namespace BuscaTexto
{
    public class ForcaBruta
    {
        public static int forcaBruta(String p, String t, RichTextBox w)
        {
            int i, j, aux;
            int m = p.Length;
            int n = t.Length;

            for (i = 0; i < n; i++)
            {
                aux = i;
                for (j = 0; j < m && aux < n; j++)
                {

                    if (t[aux] != p[j])
                    {
                        if (p[j] == '?')
                            p.Replace(p[j], t[aux]);
                        else
                            break; 
                    }
                    aux++;
                }
                if (j == m)
                {
                    //Posição inicial para começar a colorir
                    w.SelectionStart = i;
                    w.SelectionLength = j; // Largura do background 
                    w.SelectionBackColor = Color.DarkRed;
                }
            }

            return -1;   
        }
    }
}