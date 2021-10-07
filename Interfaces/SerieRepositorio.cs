using System;
using System.Collections.Generic;
using series.Interfaces;

namespace projetoseries.Interfaces
{
    public class SerieRepositorio : IRepositorio<Series>
    {
        private List<Serie> listaSerie = new List<Serie>();

        public void Atualiza(int id, Series objeto)
        {
            listaSerie[id] = objeto;
        }
        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }
        public void Insere(Series entidade)
        {
            listaSerie.Add(objeto);
        }
        public List<Series> Lista()
        {
            return listaSerie;
        }
        public int ProximoId()
        {
            return listaSerie.Count;
        }
        public Serie RetornaPorId(int Id)
        {
            return listaSerie[id]
        }
    }
}