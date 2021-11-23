using System;


namespace DioSeries
{
    class Series : EntidadeBase

    { private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private string Genero { get; set; }
        private bool Excluido { get; set; }
        public Series(string titulo, string descricao, int ano, string genero)
        {
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Genero = genero;
            Excluido = false;
        }

        internal void Excluir(object objcto)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + Titulo + Environment.NewLine;
            retorno += "Descricao: " + Descricao + Environment.NewLine;
            retorno += "Ano de inicio: " + Ano + Environment.NewLine;
            retorno += "Excluído: " + Ano + Environment.NewLine;
            return retorno;
        }
        public string retornaTitulo()
        {
            return Titulo;
        }
        public int retornaID()
        {
            return ID;
        }
        public bool retornaExcluido()
        {
            return Excluido;
        }
        public void Excluir()
        {
            Excluido = true;
        }



    }




}
