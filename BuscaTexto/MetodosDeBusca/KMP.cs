using System;
using System.Drawing;
using System.Windows.Forms;

namespace BuscaTexto
{
    public class KMP
    {
        static int[] next = new int[1000];
        public static void initNext(String p)
        {
            int i = 0, j = -1, m = p.Length;
            next[0] = -1;
            while (i < m)
            {
                while (j >= 0 && p[i] != p[j])
                {
                    j = next[j];
                }
                i++;
                j++;
                next[i] = j;
            }
        }

        public static int KMPSearch(String p, String t, RichTextBox w)
        {
            int i = 0, j, m = p.Length, n = t.Length;
            initNext(p);
            while (i!=n) // enquanto i não for igual a n, para o while 
            {
                j = 0; // resetando j 
                while (j < m && i <= n) // mudar o i < n  para o metodo funcionar
                {
                    while (j >= 0 && t[i] != p[j])
                    {
                        j = next[j];
                    }
                    i++;
                    j++;
                }
                if (j == m)
                {
                    //Posição inicial para começar a colorir
                    w.SelectionStart = i - m;
                    w.SelectionLength = j; // Largura do background 
                    w.SelectionBackColor = Color.DarkRed;
                } 
            }

            return -1; 
        }
    }
}
