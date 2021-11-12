using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NixPDC
{
    class FuncoesUteis
    {


        public static void deletarArquivo(string arquivo, bool obrigatorioDeletar = false, bool verificarSeAberto = false, string path = "")
        {
            path = path == "" ? AppDomain.CurrentDomain.BaseDirectory : "path";
            bool reiniciar = false;

            if (!verificarSeAberto)
            {
                File.Delete(path + arquivo);
            }
            else
            {
                try
                {
                    File.Delete(path + arquivo);
                }
                catch (Exception e)
                {
                    var result = MessageBox.Show("Erro ao deletar arquivo. Feche o arquivo aberto e tente novamente." + Environment.NewLine +
                    "Caso o erro persistir contate o administrador" + Environment.NewLine +
                    "Local: " + path + Environment.NewLine +
                    "Arquivo: " + arquivo
                    , "Erro ao deletar arquivo", MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning);

                    // If the no button was pressed ...
                    if (result == DialogResult.Retry)
                    {
                        deletarArquivo(arquivo, obrigatorioDeletar, true);
                    }
                    else
                    {
                        if (obrigatorioDeletar)
                        {
                            var result2 = MessageBox.Show("É necessário deletar o arquivo para continuar o processo" + Environment.NewLine +
                      "Deseja tentar deletar o arquivo novamente?" + Environment.NewLine +
                      "Caso clique em NÃO o processo será interrompido."                      
                      , "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result2 == DialogResult.No || result2 == DialogResult.Cancel)
                            {
                                reiniciar = true;
                            }
                            else
                            {
                                deletarArquivo(arquivo, obrigatorioDeletar, true);
                            }
                        }                     
                    }
                }
            }
            if (reiniciar)
            {
                encerraPrograma();
            }
        }

        public static void encerraPrograma()
        {
            //Application.Restart();
            Environment.Exit(0);
        }
        public static void reiniciaPrograma()
        {
            Application.Restart();
            Environment.Exit(0);
        }

        public static void pausa(int ms)
        {
            System.Threading.Thread.Sleep(ms);
        }

    }
}
