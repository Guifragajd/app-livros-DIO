using System;
using System.Collections.Generic;
using dio.series.Interface;

namespace dio.series
{
    public class Serierepositorio : IRepositorio<Serie>
    {

        private List<Serie> listaSerie = new List<Serie>();
        public void Atualizar(int id, Serie objeto)
        {
            listaSerie[id] =objeto;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Exclui();
        }

        public void Insere(Serie obejto)
        {
            listaSerie.Add(obejto);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }

}
