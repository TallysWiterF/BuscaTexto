using System;
using System.Drawing;
using System.Windows.Forms;

namespace BuscaTexto
{
    public class RabinKarp
    {
        const long q = 10014521L;
        const int d = 128;

        public static int RKSearch(String p, String t, RichTextBox w)
        {
            long dm = 1, h1 = 0, h2 = 0;
            int i;
            int m = p.Length;
            int n = t.Length;
             
            if (n < m) // texto MENOR que o padrão
            {
                return -1;
            }
            for (i = 1; i < m; i++)
            {
                dm = (d * dm) % q;
            }
            for (i = 0; i < m; i++)
            {
                h1 = (h1 * d + p[i]) % q;
                h2 = (h2 * d + t[i]) % q;
            }
            for (i = 0; i < n; i++) // enquanto i for menor que o tamanho do texto: continua
            {
                if (i >= n - m) // chegou ao final do texto sem encontrar
                {
                    return -1;
                }
                h2 = (h2 + d * q - t[i] * dm) % q;
                h2 = (h2 * d + t[i + m]) % q;
                if (h1 == h2) // se o hash 1 for igual ao hash 2
                {
                    //Posição inicial para começar a colorir 
                    w.SelectionStart = i; 
                    w.SelectionLength = m; // Largura do background 
                    w.SelectionBackColor = Color.DarkRed;
                }

            }
              
            return i;
        }
    }
}
