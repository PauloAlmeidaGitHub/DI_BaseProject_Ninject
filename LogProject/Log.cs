using System;
using Interfaces;

namespace LogProject
{
    public class Log : ILog
    {
        private IArquivo Arquivo { get; }

        public Log(IArquivo arquivo)
        {
            Arquivo = arquivo;
        }

        public void EscreveLog(string mensagem)
        {
            var newMensagem = $"{DateTime.Now.ToLongDateString()} {DateTime.Now.ToShortTimeString()} - {mensagem}";
            Arquivo.EscreveNoArquivo(newMensagem);
        }
    }
}
