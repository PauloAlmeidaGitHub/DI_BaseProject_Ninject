using System.IO;
using Interfaces;

namespace ArquivoProject
{
    public class Arquivo : IArquivo
    {
        public void EscreveNoArquivo(string mensagem)
        {
            using (var arquivo = new StreamWriter(Path.GetTempPath() + "arquivo.txt", true))
            {
                arquivo.WriteLine(mensagem);
            }
        }
    }
}
