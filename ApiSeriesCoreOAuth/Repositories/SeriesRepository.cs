using ApiSeriesCoreOAuth.Data;
using ApiSeriesCoreOAuth.Models;
using System.Collections.Generic;
using System.Linq;

namespace ApiSeriesCoreOAuth.Repositories
{
    public class SeriesRepository : ISeriesRepository
    {
        //https://www.pragimtech.com/blog/blazor/rest-api-repository-pattern/

        private readonly RepositoryContext _context;

        public SeriesRepository(RepositoryContext context)
        {
            this._context = context;
        }

        public List<Serie> GetSeries()
        {
            return this._context.Series.ToList();
        }

        public Serie GetSerie(int idserie)
        {
            return this._context.Series
                .FirstOrDefault(s => s.IdSerie == idserie);
        }

        public Serie AddSerie(Serie serie)
        {
            var result = this._context.Series.Add(serie);
            this._context.SaveChanges();

            return result.Entity;
        }

        public Serie UpdateSerie(Serie serie)
        {
            var result = this._context.Series
                .FirstOrDefault(s => s.IdSerie == serie.IdSerie);

            if (result != null)
            {
                result.Titulo = serie.Titulo;
                result.Imagen = serie.Imagen;
                result.Puntuacion = serie.Puntuacion;
                result.Year = serie.Year;

                this._context.SaveChanges();

                return result;
            }
            return null;
        }

        public void DeleteSerie(int idserie)
        {
            var result = this._context.Series
                .FirstOrDefault(s => s.IdSerie == idserie);

            if (result != null)
            {
                this._context.Series.Remove(result);
                this._context.SaveChanges();
            }
        }
    }
}
