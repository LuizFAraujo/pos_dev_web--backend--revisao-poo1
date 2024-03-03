/* Message Box para Console.
Tipos (botão):
- 1 = OK
- 2 = OK | Cancelar
- 3 = Sim | Não | Cancelar
- 4 = Sim | Não
- 5 = Repetir | Cancelar
- 6 = Cancelar | Tentar | Continuar

Retornos:
-  1 = OK
-  2 = Cancelar
-  4 = Repetir
-  6 = Sim
-  7 = Não
- 10 = Tentar
- 11 = Continuar

Para usar, incluir | e chamar a função:
using UtilTools;
Util_MessageBox.ShowMessageBox("msg", "tit", 1);
*/

using System.Runtime.InteropServices;

namespace UtilTools

{
    public class Util_MessageBox
    {
        // ==============================================
        public static int ShowMessageBox(String texto, String titulo, uint tipo, Boolean checkReturn = false)
        {
            //Chama a API Win32 para abrir uma caixa de mensagens (não requer nenhuma outra biblioteca)
            [DllImport("user32.dll", CharSet = CharSet.Unicode)]
            static extern int MessageBox(IntPtr _hWnd, String _texto, String _titulo, uint _type);

            int value = MessageBox(new IntPtr(0), texto, titulo, tipo);

            if (checkReturn) CheckRetorno(value);

            return value;
        }

        // ==============================================
        // Para confimar valor de retorno
        private static void CheckRetorno(int value)
        {
            Console.WriteLine($"\n\n --- Retorno de MessageBox  =  < {value.ToString()} > ---\n\n");
        }

    }
}