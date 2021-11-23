using System;
using System.Collections.Generic;
using DioSeries.Interface;


namespace DioSeries
{
    public class SerieRepositorio : Irepositorio<Series>
    {
        private List<Series> listaSeries = new List<Series>();
        public void Atualiza (int id, Series objeto)
        {
            listaSeries[id] = objeto;
        }

        public void Excluir(int id )
        {
            listaSeries[id].Excluir();
        }

        public void Inserir(Series Objeto)
        {
            listaSeries.Add(Objeto);
        }

        public List<Series> lista()
        {
            return listaSeries;
        }

        public int Proximo()
        {
            return listaSeries.Count;
        }

        public Series RetornaPorID(int id)
        {
            return listaSeries (id);
        }

        internal void Atualiza(int indideSerie, Action atualizarSeries)
        {
            throw new NotImplementedException();
        }
    }
}
