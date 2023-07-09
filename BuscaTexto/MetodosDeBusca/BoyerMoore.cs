using System;
using System.Drawing;
using System.Windows.Forms;

namespace BuscaTexto
{
    class BoyerMoore
    {
        static int[] skip = new int[256];

        public static void initSkip(String p)
        {
            int j, m = p.Length;
            for (j = 0; j < 256; j++)
            {
                skip[j] = m;
            }
            for (j = 0; j < m; j++)
            {
                skip[p[j]] = m - j - 1;
            }
        }

        public static int BMSearch(String p, String t, RichTextBox w)
        {
            int i, j, a, m = p.Length, n = t.Length;
            i = m - 1; // tamanho do palavra -1
            j = m - 1; // tamanho do palavra -1 
            initSkip(p);
            while (i != n)
            {
                while (j >= 0)
                {
                    while (t[i] != p[j])
                    {
                        a = skip[t[i]];
                        i += (m - j > a) ? (m - j) : a;
                        if (i >= n)
                        {
                            break;
                        }
                        j = m - 1;
                    }
                    i--;
                    j--;
                }
                //Posição inicial para começar a colorir 
                w.SelectionStart = i + 1;
                w.SelectionLength = m; // Largura do background 
                w.SelectionBackColor = Color.DarkRed;
                i += m + 1; // incrementando no i o tamanho da palavra + 1 
                j = m - 1; // resetando j para que o metodo funcione
            } 
            return 1;  
        }
    }
}
