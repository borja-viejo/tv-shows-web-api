﻿// <auto-generated />
using ApiSeriesCoreOAuth.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiSeriesCoreOAuth.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20220318153347_M1")]
    partial class M1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApiSeriesCoreOAuth.Models.Personaje", b =>
                {
                    b.Property<int>("IdPersonaje")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdSerie")
                        .HasColumnType("int");

                    b.Property<string>("Imagen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPersonaje");

                    b.ToTable("Personajes");

                    b.HasData(
                        new
                        {
                            IdPersonaje = 1,
                            IdSerie = 6,
                            Imagen = "https://i.pinimg.com/originals/cd/ec/06/cdec069e361d3e41b0259fe6991e48a2.png",
                            Nombre = "Koothrappali"
                        },
                        new
                        {
                            IdPersonaje = 2,
                            IdSerie = 4,
                            Imagen = "https://i.pinimg.com/originals/b9/e2/b3/b9e2b367ec3cdd3db683803f36e40b64.jpg",
                            Nombre = "Barney Stinson"
                        },
                        new
                        {
                            IdPersonaje = 3,
                            IdSerie = 3,
                            Imagen = "https://spoilertime.com/wp-content/uploads/2019/05/Gaten-Matarazzo-in-Stranger-Things-2016-780x1155.jpg",
                            Nombre = "Dustin Henderson"
                        },
                        new
                        {
                            IdPersonaje = 4,
                            IdSerie = 7,
                            Imagen = "https://i.pinimg.com/originals/d6/da/4a/d6da4a6d4a2bc7029845abb5a59f702b.jpg",
                            Nombre = "Oliver Atom"
                        },
                        new
                        {
                            IdPersonaje = 5,
                            IdSerie = 7,
                            Imagen = "https://media.revistagq.com/photos/5e7212ac9da1570008d603e5/16:9/w_1920,c_limit/benji-price-campeones-serie.jpg",
                            Nombre = "Benji Price"
                        },
                        new
                        {
                            IdPersonaje = 6,
                            IdSerie = 3,
                            Imagen = "https://vader.news/__export/1598037970333/sites/gadgets/img/2020/08/21/once.jpg_691115875.jpg",
                            Nombre = "Once"
                        },
                        new
                        {
                            IdPersonaje = 7,
                            IdSerie = 6,
                            Imagen = "https://www.bolsamania.com/cine/wp-content/uploads/2015/04/26.jpg",
                            Nombre = "Sheldon Cooper"
                        },
                        new
                        {
                            IdPersonaje = 8,
                            IdSerie = 8,
                            Imagen = "https://la.sonychannel.com/sites/la.set/files/ct_custom_page_f_primary_image/ted_portada.jpg",
                            Nombre = "Ted Mosby"
                        },
                        new
                        {
                            IdPersonaje = 9,
                            IdSerie = 2,
                            Imagen = "https://static.wikia.nocookie.net/esstarwars/images/8/8a/Pascal_as_The_Mando-Advanced_Graphics.png",
                            Nombre = "El Mandaloriano"
                        },
                        new
                        {
                            IdPersonaje = 10,
                            IdSerie = 2,
                            Imagen = "https://static2.abc.es/media/play/2020/11/13/baby-yoda-kdIH--620x349@abc.jpg",
                            Nombre = "Baby Yoda"
                        },
                        new
                        {
                            IdPersonaje = 11,
                            IdSerie = 6,
                            Imagen = "https://www.periodicodigitalgratis.com/gratis/imagen/736_20160416040412.jpg",
                            Nombre = "Howard Wolowitz"
                        },
                        new
                        {
                            IdPersonaje = 12,
                            IdSerie = 1,
                            Imagen = "https://assets.afcdn.com/story/20150813/736968_w980h638c1cx494cy293.jpg",
                            Nombre = "Daenerys Targaryen"
                        },
                        new
                        {
                            IdPersonaje = 14,
                            IdSerie = 1,
                            Imagen = "https://vader.news/__export/1593841129501/sites/gadgets/img/2020/07/04/tyrion_lannister_game_of_thrones.jpg_1255757245.jpg",
                            Nombre = "Tyrion Lannister"
                        },
                        new
                        {
                            IdPersonaje = 15,
                            IdSerie = 4,
                            Imagen = "https://api.time.com/wp-content/uploads/2016/09/narcos_season_2.jpg",
                            Nombre = "Pablo Escobar"
                        },
                        new
                        {
                            IdPersonaje = 17,
                            IdSerie = 4,
                            Imagen = "https://cadenaser00.epimg.net/ser/imagenes/2017/09/28/television/1506579243_820899_1506581069_noticia_normal.jpg",
                            Nombre = "Agente Peña"
                        },
                        new
                        {
                            IdPersonaje = 18,
                            IdSerie = 5,
                            Imagen = "https://hipertextual.com/files/2020/09/hipertextual-2020569181.jpg",
                            Nombre = "Patriota"
                        },
                        new
                        {
                            IdPersonaje = 19,
                            IdSerie = 5,
                            Imagen = "https://www.quever.news/u/fotografias/m/2020/9/4/f638x638-964_59131_5333.jpg",
                            Nombre = "Luz Estelar"
                        },
                        new
                        {
                            IdPersonaje = 20,
                            IdSerie = 9,
                            Imagen = "https://images.clarin.com/2017/12/20/SyJOzIdzG_1256x620.jpg",
                            Nombre = "Tokio"
                        },
                        new
                        {
                            IdPersonaje = 21,
                            IdSerie = 9,
                            Imagen = "https://imagenes.milenio.com/Abv1Q6uPaHtF41DDvdnbqwXU8Hk=/958x596/smart/https://www.milenio.com/uploads/media/2020/05/28/creador-serie-revela-tuvieron-matar_0_150_458_285.png",
                            Nombre = "Berlin"
                        },
                        new
                        {
                            IdPersonaje = 22,
                            IdSerie = 6,
                            Imagen = "https://hips.hearstapps.com/es.h-cdn.co/fotoes/images/noticias-cine/the-big-bang-theory-y-el-secreto-del-apellido-de-penny/109791953-1-esl-ES/The-Big-Bang-Theory-y-el-secreto-del-apellido-de-Penny.jpg",
                            Nombre = "Penny"
                        },
                        new
                        {
                            IdPersonaje = 23,
                            IdSerie = 8,
                            Imagen = "https://i.pinimg.com/originals/00/29/68/0029683aad5d3c861b621dc1036113af.png",
                            Nombre = "Robin Scherbatsky"
                        },
                        new
                        {
                            IdPersonaje = 24,
                            IdSerie = 2,
                            Imagen = "https://i.pinimg.com/originals/18/c0/25/18c02539aee1425c62972d0aa98f2e13.jpg",
                            Nombre = "Ada Thorne"
                        },
                        new
                        {
                            IdPersonaje = 25,
                            IdSerie = 2,
                            Imagen = "https://i.pinimg.com/originals/8f/65/1a/8f651a6ec72dd4528e1f6a948b323558.jpg",
                            Nombre = "Lucia"
                        },
                        new
                        {
                            IdPersonaje = 26,
                            IdSerie = 2,
                            Imagen = "https://www.infobae.com/new-resizer/OqESAKmJLemcmmfnJuS4w9AuMTE=/1200x900/filters:format(jpg):quality(85)//s3.amazonaws.com/arc-wordpress-client-uploads/infobae-wp/wp-content/uploads/2016/06/20144634/chavo1.jpg",
                            Nombre = "aaa"
                        },
                        new
                        {
                            IdPersonaje = 27,
                            IdSerie = 3,
                            Imagen = "https://www.infobae.com/new-resizer/OqESAKmJLemcmmfnJuS4w9AuMTE=/1200x900/filters:format(jpg):quality(85)//s3.amazonaws.com/arc-wordpress-client-uploads/infobae-wp/wp-content/uploads/2016/06/20144634/chavo1.jpg",
                            Nombre = "REACT"
                        },
                        new
                        {
                            IdPersonaje = 28,
                            IdSerie = 2,
                            Imagen = "C:/fakepath/5.jpg",
                            Nombre = "Sonny Crokett"
                        },
                        new
                        {
                            IdPersonaje = 29,
                            IdSerie = 3,
                            Imagen = "https://images-na.ssl-images-amazon.com/images/I/41n3ccU6aML._AC_.jpg",
                            Nombre = "Sonny"
                        },
                        new
                        {
                            IdPersonaje = 30,
                            IdSerie = 2,
                            Imagen = "https://www.ecestaticos.com/image/clipping/197877ded7f8697b4ed50937c073ac2b/los-soprano-diez-anos-despues-del-fundido-en-negro-mas-famoso-de-la-historia.jpg",
                            Nombre = "YOYO"
                        },
                        new
                        {
                            IdPersonaje = 31,
                            IdSerie = 3,
                            Imagen = "https://www.ecartelera.com/images/sets/44900/44983.jpg",
                            Nombre = "REACT JUEVES"
                        },
                        new
                        {
                            IdPersonaje = 32,
                            IdSerie = 3,
                            Imagen = "https://static.wikia.nocookie.net/strangerthings/images/2/2f/Jim_Hopper_Season_3.jpg",
                            Nombre = "Jim Hooper"
                        },
                        new
                        {
                            IdPersonaje = 33,
                            IdSerie = 3,
                            Imagen = "https://s1.r29static.com/bin/entry/a48/x,80/2215864/image.jpg",
                            Nombre = "Steve Harrington"
                        });
                });

            modelBuilder.Entity("ApiSeriesCoreOAuth.Models.Serie", b =>
                {
                    b.Property<int>("IdSerie")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Imagen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Puntuacion")
                        .HasColumnType("real");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("IdSerie");

                    b.ToTable("Series");

                    b.HasData(
                        new
                        {
                            IdSerie = 1,
                            Imagen = "https://cadenaser00.epimg.net/ser/imagenes/2019/05/23/television/1558591913_020782_1558595107_noticia_normal.jpg",
                            Puntuacion = 9.3f,
                            Titulo = "Juego de tronos",
                            Year = 2011
                        },
                        new
                        {
                            IdSerie = 2,
                            Imagen = "https://cnet1.cbsistatic.com/img/aTFHkUWhY0jK0ekKstyAfMd10xI=/940x0/2020/07/02/1a2c7d33-e1c4-4e31-b128-aff87dee41f6/art-of-mandalorian-final-cover-credits.jpg",
                            Puntuacion = 8.9f,
                            Titulo = "The Mandalorian",
                            Year = 2019
                        },
                        new
                        {
                            IdSerie = 3,
                            Imagen = "https://e.rpp-noticias.io/xlarge/2020/02/14/145014_901131.png",
                            Puntuacion = 8.8f,
                            Titulo = "Stranger Things",
                            Year = 2016
                        },
                        new
                        {
                            IdSerie = 4,
                            Imagen = "https://www.sdpnoticias.com/files/content_image/uploads/2019/08/07/5d4ab931aba2c.jpeg",
                            Puntuacion = 8.8f,
                            Titulo = "Narcos",
                            Year = 2015
                        },
                        new
                        {
                            IdSerie = 5,
                            Imagen = "https://p3c8r6f2.rocketcdn.me/web/wp-content/uploads/2020/01/The-Boys-portada-1280x640.jpg",
                            Puntuacion = 8.7f,
                            Titulo = "The Boys",
                            Year = 2019
                        },
                        new
                        {
                            IdSerie = 6,
                            Imagen = "https://www.camaracivica.com/wp-content/uploads/2016/12/The-Big-Bang-Theory.jpg",
                            Puntuacion = 8.1f,
                            Titulo = "The Big Bang Theory",
                            Year = 2007
                        },
                        new
                        {
                            IdSerie = 7,
                            Imagen = "https://www.dibujos-animados.net/wp-content/uploads/2016/11/serie-oliver-benji-campeones.jpg",
                            Puntuacion = 8f,
                            Titulo = "Campeones",
                            Year = 1983
                        },
                        new
                        {
                            IdSerie = 8,
                            Imagen = "https://www.giztele.com/wp-content/uploads/2020/07/como-conoci-a-vuestra-madre.png",
                            Puntuacion = 8.3f,
                            Titulo = "Como conocí a vuestra madre",
                            Year = 2005
                        },
                        new
                        {
                            IdSerie = 9,
                            Imagen = "https://s1.eestatic.com/2019/07/23/cultura/series/Netflix-Series-Ursula_Corbero-Series_415970383_130773402_1024x576.jpg",
                            Puntuacion = 8.4f,
                            Titulo = "La casa de papel",
                            Year = 2017
                        });
                });

            modelBuilder.Entity("ApiSeriesCoreOAuth.Models.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            IdUsuario = 1,
                            Apellidos = "PERRY",
                            Email = "perry@perry.com",
                            Nombre = "PERRY",
                            Password = "PERRY"
                        },
                        new
                        {
                            IdUsuario = 2,
                            Apellidos = "ALUMNO",
                            Email = "alumno@alumno.com",
                            Nombre = "ALUMNO",
                            Password = "ALUMNO"
                        },
                        new
                        {
                            IdUsuario = 3,
                            Apellidos = "AZURE",
                            Email = "azure@azure.com",
                            Nombre = "AZURE",
                            Password = "AZURE"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}