using System;
using System.Collections.Generic;


namespace DioSeries.Interface
{
    public interface Irepositorio<T>
    {
        List<T> List();
        T RetornaPorID(int id);
        void Insere(T entidade);
        void Excluir(int id);
        void Atualiza(int id, T entidade);
        int Proximo();
        void RetornaPorId(int id);
       

    }
}
