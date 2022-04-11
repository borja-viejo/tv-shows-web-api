using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Globalization;

namespace ApiSeriesCoreOAuth.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Crear SERIES
            List<Serie> series = new List<Serie>() {
                new Serie { IdSerie = 1, Titulo = "Juego de tronos", Imagen = "https://cadenaser00.epimg.net/ser/imagenes/2019/05/23/television/1558591913_020782_1558595107_noticia_normal.jpg", Puntuacion = float.Parse("9.3", NumberStyles.Float, CultureInfo.InvariantCulture), Year = 2011 },
                new Serie { IdSerie = 2, Titulo = "The Mandalorian", Imagen = "https://cnet1.cbsistatic.com/img/aTFHkUWhY0jK0ekKstyAfMd10xI=/940x0/2020/07/02/1a2c7d33-e1c4-4e31-b128-aff87dee41f6/art-of-mandalorian-final-cover-credits.jpg", Puntuacion = float.Parse("8.9", NumberStyles.Float, CultureInfo.InvariantCulture), Year = 2019 },
                new Serie { IdSerie = 3, Titulo = "Stranger Things", Imagen = "https://e.rpp-noticias.io/xlarge/2020/02/14/145014_901131.png", Puntuacion = float.Parse("8.8", NumberStyles.Float, CultureInfo.InvariantCulture), Year = 2016 },
                new Serie { IdSerie = 4, Titulo = "Narcos", Imagen = "https://www.sdpnoticias.com/files/content_image/uploads/2019/08/07/5d4ab931aba2c.jpeg", Puntuacion = float.Parse("8.8", NumberStyles.Float, CultureInfo.InvariantCulture), Year = 2015 },
                new Serie { IdSerie = 5, Titulo = "The Boys", Imagen = "https://p3c8r6f2.rocketcdn.me/web/wp-content/uploads/2020/01/The-Boys-portada-1280x640.jpg", Puntuacion = float.Parse("8.7", NumberStyles.Float, CultureInfo.InvariantCulture), Year = 2019 },
                new Serie { IdSerie = 6, Titulo = "The Big Bang Theory", Imagen = "https://www.camaracivica.com/wp-content/uploads/2016/12/The-Big-Bang-Theory.jpg", Puntuacion = float.Parse("8.1", NumberStyles.Float, CultureInfo.InvariantCulture), Year = 2007 },
                new Serie { IdSerie = 7, Titulo = "Campeones", Imagen = "https://www.dibujos-animados.net/wp-content/uploads/2016/11/serie-oliver-benji-campeones.jpg", Puntuacion = float.Parse("8", NumberStyles.Float, CultureInfo.InvariantCulture), Year = 1983 },
                new Serie { IdSerie = 8, Titulo = "Como conocí a vuestra madre", Imagen = "https://www.giztele.com/wp-content/uploads/2020/07/como-conoci-a-vuestra-madre.png", Puntuacion = float.Parse("8.3", NumberStyles.Float, CultureInfo.InvariantCulture), Year = 2005 },
                new Serie { IdSerie = 9, Titulo = "La casa de papel", Imagen = "https://s1.eestatic.com/2019/07/23/cultura/series/Netflix-Series-Ursula_Corbero-Series_415970383_130773402_1024x576.jpg", Puntuacion = float.Parse("8.4", NumberStyles.Float, CultureInfo.InvariantCulture), Year = 2017 }
            };
            modelBuilder.Entity<Serie>().HasData(series);

            // Crear PERSONAJES
            List<Personaje> personajes = new List<Personaje>() {
                new Personaje { IdPersonaje = 1, Nombre = "Koothrappali", Imagen = "https://i.pinimg.com/originals/cd/ec/06/cdec069e361d3e41b0259fe6991e48a2.png", IdSerie = series[5].IdSerie },
                new Personaje { IdPersonaje = 2, Nombre = "Barney Stinson", Imagen = "https://i.pinimg.com/originals/b9/e2/b3/b9e2b367ec3cdd3db683803f36e40b64.jpg", IdSerie = series[3].IdSerie },
                new Personaje { IdPersonaje = 3, Nombre = "Dustin Henderson", Imagen = "https://spoilertime.com/wp-content/uploads/2019/05/Gaten-Matarazzo-in-Stranger-Things-2016-780x1155.jpg", IdSerie = series[2].IdSerie },
                new Personaje { IdPersonaje = 4, Nombre = "Oliver Atom", Imagen = "https://i.pinimg.com/originals/d6/da/4a/d6da4a6d4a2bc7029845abb5a59f702b.jpg", IdSerie = series[6].IdSerie },
                new Personaje { IdPersonaje = 5, Nombre = "Benji Price", Imagen = "https://media.revistagq.com/photos/5e7212ac9da1570008d603e5/16:9/w_1920,c_limit/benji-price-campeones-serie.jpg", IdSerie = series[6].IdSerie },
                new Personaje { IdPersonaje = 6, Nombre = "Once", Imagen = "https://vader.news/__export/1598037970333/sites/gadgets/img/2020/08/21/once.jpg_691115875.jpg", IdSerie = series[2].IdSerie },
                new Personaje { IdPersonaje = 7, Nombre = "Sheldon Cooper", Imagen = "https://www.bolsamania.com/cine/wp-content/uploads/2015/04/26.jpg", IdSerie = series[5].IdSerie },
                new Personaje { IdPersonaje = 8, Nombre = "Ted Mosby", Imagen = "https://la.sonychannel.com/sites/la.set/files/ct_custom_page_f_primary_image/ted_portada.jpg", IdSerie = series[7].IdSerie },
                new Personaje { IdPersonaje = 9, Nombre = "El Mandaloriano", Imagen = "https://static.wikia.nocookie.net/esstarwars/images/8/8a/Pascal_as_The_Mando-Advanced_Graphics.png", IdSerie = series[1].IdSerie },
                new Personaje { IdPersonaje = 10, Nombre = "Baby Yoda", Imagen = "https://static2.abc.es/media/play/2020/11/13/baby-yoda-kdIH--620x349@abc.jpg", IdSerie = series[1].IdSerie },
                new Personaje { IdPersonaje = 11, Nombre = "Howard Wolowitz", Imagen = "https://www.periodicodigitalgratis.com/gratis/imagen/736_20160416040412.jpg", IdSerie = series[5].IdSerie },
                new Personaje { IdPersonaje = 12, Nombre = "Daenerys Targaryen", Imagen = "https://assets.afcdn.com/story/20150813/736968_w980h638c1cx494cy293.jpg", IdSerie = series[0].IdSerie },
                new Personaje { IdPersonaje = 14, Nombre = "Tyrion Lannister", Imagen = "https://vader.news/__export/1593841129501/sites/gadgets/img/2020/07/04/tyrion_lannister_game_of_thrones.jpg_1255757245.jpg", IdSerie = series[0].IdSerie },
                new Personaje { IdPersonaje = 15, Nombre = "Pablo Escobar", Imagen = "https://api.time.com/wp-content/uploads/2016/09/narcos_season_2.jpg", IdSerie = series[3].IdSerie },
                new Personaje { IdPersonaje = 17, Nombre = "Agente Peña", Imagen = "https://cadenaser00.epimg.net/ser/imagenes/2017/09/28/television/1506579243_820899_1506581069_noticia_normal.jpg", IdSerie = series[3].IdSerie },
                new Personaje { IdPersonaje = 18, Nombre = "Patriota", Imagen = "https://hipertextual.com/files/2020/09/hipertextual-2020569181.jpg", IdSerie = series[4].IdSerie },
                new Personaje { IdPersonaje = 19, Nombre = "Luz Estelar", Imagen = "https://www.quever.news/u/fotografias/m/2020/9/4/f638x638-964_59131_5333.jpg", IdSerie = series[4].IdSerie },
                new Personaje { IdPersonaje = 20, Nombre = "Tokio", Imagen = "https://images.clarin.com/2017/12/20/SyJOzIdzG_1256x620.jpg", IdSerie = series[8].IdSerie },
                new Personaje { IdPersonaje = 21, Nombre = "Berlin", Imagen = "https://imagenes.milenio.com/Abv1Q6uPaHtF41DDvdnbqwXU8Hk=/958x596/smart/https://www.milenio.com/uploads/media/2020/05/28/creador-serie-revela-tuvieron-matar_0_150_458_285.png", IdSerie = series[8].IdSerie },
                new Personaje { IdPersonaje = 22, Nombre = "Penny", Imagen = "https://hips.hearstapps.com/es.h-cdn.co/fotoes/images/noticias-cine/the-big-bang-theory-y-el-secreto-del-apellido-de-penny/109791953-1-esl-ES/The-Big-Bang-Theory-y-el-secreto-del-apellido-de-Penny.jpg", IdSerie = series[5].IdSerie },
                new Personaje { IdPersonaje = 23, Nombre = "Robin Scherbatsky", Imagen = "https://i.pinimg.com/originals/00/29/68/0029683aad5d3c861b621dc1036113af.png", IdSerie = series[7].IdSerie },
                new Personaje { IdPersonaje = 24, Nombre = "Ada Thorne", Imagen = "https://i.pinimg.com/originals/18/c0/25/18c02539aee1425c62972d0aa98f2e13.jpg", IdSerie = series[1].IdSerie },
                new Personaje { IdPersonaje = 25, Nombre = "Lucia", Imagen = "https://i.pinimg.com/originals/8f/65/1a/8f651a6ec72dd4528e1f6a948b323558.jpg", IdSerie = series[1].IdSerie },
                new Personaje { IdPersonaje = 26, Nombre = "aaa", Imagen = "https://www.infobae.com/new-resizer/OqESAKmJLemcmmfnJuS4w9AuMTE=/1200x900/filters:format(jpg):quality(85)//s3.amazonaws.com/arc-wordpress-client-uploads/infobae-wp/wp-content/uploads/2016/06/20144634/chavo1.jpg", IdSerie = series[1].IdSerie },
                new Personaje { IdPersonaje = 27, Nombre = "REACT", Imagen = "https://www.infobae.com/new-resizer/OqESAKmJLemcmmfnJuS4w9AuMTE=/1200x900/filters:format(jpg):quality(85)//s3.amazonaws.com/arc-wordpress-client-uploads/infobae-wp/wp-content/uploads/2016/06/20144634/chavo1.jpg", IdSerie = series[2].IdSerie },
                new Personaje { IdPersonaje = 28, Nombre = "Sonny Crokett", Imagen = "C:/fakepath/5.jpg", IdSerie = series[1].IdSerie },
                new Personaje { IdPersonaje = 29, Nombre = "Sonny", Imagen = "https://images-na.ssl-images-amazon.com/images/I/41n3ccU6aML._AC_.jpg", IdSerie = series[2].IdSerie },
                new Personaje { IdPersonaje = 30, Nombre = "YOYO", Imagen = "https://www.ecestaticos.com/image/clipping/197877ded7f8697b4ed50937c073ac2b/los-soprano-diez-anos-despues-del-fundido-en-negro-mas-famoso-de-la-historia.jpg", IdSerie = series[1].IdSerie },
                new Personaje { IdPersonaje = 31, Nombre = "REACT JUEVES", Imagen = "https://www.ecartelera.com/images/sets/44900/44983.jpg", IdSerie = series[2].IdSerie },
                new Personaje { IdPersonaje = 32, Nombre = "Jim Hooper", Imagen = "https://static.wikia.nocookie.net/strangerthings/images/2/2f/Jim_Hopper_Season_3.jpg", IdSerie = series[2].IdSerie },
                new Personaje { IdPersonaje = 33, Nombre = "Steve Harrington", Imagen = "https://s1.r29static.com/bin/entry/a48/x,80/2215864/image.jpg", IdSerie = series[2].IdSerie }
            };
            modelBuilder.Entity<Personaje>().HasData(personajes);

            // Crear registro tabla USUARIOS
            List<Usuario> usuarios = new List<Usuario>() {
                new Usuario() { IdUsuario = 1, Nombre = "PERRY", Apellidos = "PERRY", Email = "perry@perry.com", Password = "PERRY" },
                new Usuario() { IdUsuario = 2, Nombre = "ALUMNO", Apellidos = "ALUMNO", Email = "alumno@alumno.com", Password = "ALUMNO" },
                new Usuario() { IdUsuario = 3, Nombre = "AZURE", Apellidos = "AZURE", Email = "azure@azure.com", Password = "AZURE" }
            };
            modelBuilder.Entity<Usuario>().HasData(usuarios);
        }
    }
}
