/**
 * Temat: Color pop
 * Roman Gawenda semestr 5 2022/2023
 * Biblioteka C#
*/

namespace CsharpDll
{
    public class GrayCsharp
    {
        public static void MakeGrayC(byte[] tab_red, byte[] tab_green, byte[] tab_blue)
        {
            for (int x = 0; x < 8; x++)
            {
                tab_red[x] = (byte)(tab_red[x] * 0.3);
                tab_green[x] = (byte)(tab_green[x] * 0.59);
                tab_blue[x] = (byte)(tab_blue[x] * 0.11);
                tab_red[x] = (byte)(tab_red[x] + tab_green[x] + tab_blue[x]);
            }
        }
    }
}
