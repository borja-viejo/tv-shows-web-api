using ApiSeriesCoreOAuth.Models;
using System.Collections.Generic;

namespace ApiSeriesCoreOAuth.Repositories
{
    public interface ISeriesRepository
    {
        List<Serie> GetSeries();

        Serie GetSerie(int idserie);

        Serie AddSerie(Serie serie);

        Serie UpdateSerie(Serie serie);

        void DeleteSerie(int idserie);
    }
}
