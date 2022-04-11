using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiSeriesCoreOAuth.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personajes",
                columns: table => new
                {
                    IdPersonaje = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Imagen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdSerie = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personajes", x => x.IdPersonaje);
                });

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    IdSerie = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Imagen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Puntuacion = table.Column<float>(type: "real", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.IdSerie);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUsuario);
                });

            migrationBuilder.InsertData(
                table: "Personajes",
                columns: new[] { "IdPersonaje", "IdSerie", "Imagen", "Nombre" },
                values: new object[,]
                {
                    { 1, 6, "https://i.pinimg.com/originals/cd/ec/06/cdec069e361d3e41b0259fe6991e48a2.png", "Koothrappali" },
                    { 33, 3, "https://s1.r29static.com/bin/entry/a48/x,80/2215864/image.jpg", "Steve Harrington" },
                    { 32, 3, "https://static.wikia.nocookie.net/strangerthings/images/2/2f/Jim_Hopper_Season_3.jpg", "Jim Hooper" },
                    { 31, 3, "https://www.ecartelera.com/images/sets/44900/44983.jpg", "REACT JUEVES" },
                    { 30, 2, "https://www.ecestaticos.com/image/clipping/197877ded7f8697b4ed50937c073ac2b/los-soprano-diez-anos-despues-del-fundido-en-negro-mas-famoso-de-la-historia.jpg", "YOYO" },
                    { 29, 3, "https://images-na.ssl-images-amazon.com/images/I/41n3ccU6aML._AC_.jpg", "Sonny" },
                    { 28, 2, "C:/fakepath/5.jpg", "Sonny Crokett" },
                    { 27, 3, "https://www.infobae.com/new-resizer/OqESAKmJLemcmmfnJuS4w9AuMTE=/1200x900/filters:format(jpg):quality(85)//s3.amazonaws.com/arc-wordpress-client-uploads/infobae-wp/wp-content/uploads/2016/06/20144634/chavo1.jpg", "REACT" },
                    { 26, 2, "https://www.infobae.com/new-resizer/OqESAKmJLemcmmfnJuS4w9AuMTE=/1200x900/filters:format(jpg):quality(85)//s3.amazonaws.com/arc-wordpress-client-uploads/infobae-wp/wp-content/uploads/2016/06/20144634/chavo1.jpg", "aaa" },
                    { 25, 2, "https://i.pinimg.com/originals/8f/65/1a/8f651a6ec72dd4528e1f6a948b323558.jpg", "Lucia" },
                    { 23, 8, "https://i.pinimg.com/originals/00/29/68/0029683aad5d3c861b621dc1036113af.png", "Robin Scherbatsky" },
                    { 22, 6, "https://hips.hearstapps.com/es.h-cdn.co/fotoes/images/noticias-cine/the-big-bang-theory-y-el-secreto-del-apellido-de-penny/109791953-1-esl-ES/The-Big-Bang-Theory-y-el-secreto-del-apellido-de-Penny.jpg", "Penny" },
                    { 21, 9, "https://imagenes.milenio.com/Abv1Q6uPaHtF41DDvdnbqwXU8Hk=/958x596/smart/https://www.milenio.com/uploads/media/2020/05/28/creador-serie-revela-tuvieron-matar_0_150_458_285.png", "Berlin" },
                    { 20, 9, "https://images.clarin.com/2017/12/20/SyJOzIdzG_1256x620.jpg", "Tokio" },
                    { 19, 5, "https://www.quever.news/u/fotografias/m/2020/9/4/f638x638-964_59131_5333.jpg", "Luz Estelar" },
                    { 24, 2, "https://i.pinimg.com/originals/18/c0/25/18c02539aee1425c62972d0aa98f2e13.jpg", "Ada Thorne" },
                    { 17, 4, "https://cadenaser00.epimg.net/ser/imagenes/2017/09/28/television/1506579243_820899_1506581069_noticia_normal.jpg", "Agente Peña" },
                    { 2, 4, "https://i.pinimg.com/originals/b9/e2/b3/b9e2b367ec3cdd3db683803f36e40b64.jpg", "Barney Stinson" },
                    { 18, 5, "https://hipertextual.com/files/2020/09/hipertextual-2020569181.jpg", "Patriota" },
                    { 4, 7, "https://i.pinimg.com/originals/d6/da/4a/d6da4a6d4a2bc7029845abb5a59f702b.jpg", "Oliver Atom" },
                    { 5, 7, "https://media.revistagq.com/photos/5e7212ac9da1570008d603e5/16:9/w_1920,c_limit/benji-price-campeones-serie.jpg", "Benji Price" },
                    { 6, 3, "https://vader.news/__export/1598037970333/sites/gadgets/img/2020/08/21/once.jpg_691115875.jpg", "Once" },
                    { 7, 6, "https://www.bolsamania.com/cine/wp-content/uploads/2015/04/26.jpg", "Sheldon Cooper" },
                    { 8, 8, "https://la.sonychannel.com/sites/la.set/files/ct_custom_page_f_primary_image/ted_portada.jpg", "Ted Mosby" },
                    { 3, 3, "https://spoilertime.com/wp-content/uploads/2019/05/Gaten-Matarazzo-in-Stranger-Things-2016-780x1155.jpg", "Dustin Henderson" },
                    { 10, 2, "https://static2.abc.es/media/play/2020/11/13/baby-yoda-kdIH--620x349@abc.jpg", "Baby Yoda" },
                    { 11, 6, "https://www.periodicodigitalgratis.com/gratis/imagen/736_20160416040412.jpg", "Howard Wolowitz" },
                    { 12, 1, "https://assets.afcdn.com/story/20150813/736968_w980h638c1cx494cy293.jpg", "Daenerys Targaryen" },
                    { 14, 1, "https://vader.news/__export/1593841129501/sites/gadgets/img/2020/07/04/tyrion_lannister_game_of_thrones.jpg_1255757245.jpg", "Tyrion Lannister" },
                    { 15, 4, "https://api.time.com/wp-content/uploads/2016/09/narcos_season_2.jpg", "Pablo Escobar" },
                    { 9, 2, "https://static.wikia.nocookie.net/esstarwars/images/8/8a/Pascal_as_The_Mando-Advanced_Graphics.png", "El Mandaloriano" }
                });

            migrationBuilder.InsertData(
                table: "Series",
                columns: new[] { "IdSerie", "Imagen", "Puntuacion", "Titulo", "Year" },
                values: new object[,]
                {
                    { 9, "https://s1.eestatic.com/2019/07/23/cultura/series/Netflix-Series-Ursula_Corbero-Series_415970383_130773402_1024x576.jpg", 8.4f, "La casa de papel", 2017 },
                    { 8, "https://www.giztele.com/wp-content/uploads/2020/07/como-conoci-a-vuestra-madre.png", 8.3f, "Como conocí a vuestra madre", 2005 },
                    { 7, "https://www.dibujos-animados.net/wp-content/uploads/2016/11/serie-oliver-benji-campeones.jpg", 8f, "Campeones", 1983 },
                    { 6, "https://www.camaracivica.com/wp-content/uploads/2016/12/The-Big-Bang-Theory.jpg", 8.1f, "The Big Bang Theory", 2007 },
                    { 3, "https://e.rpp-noticias.io/xlarge/2020/02/14/145014_901131.png", 8.8f, "Stranger Things", 2016 },
                    { 4, "https://www.sdpnoticias.com/files/content_image/uploads/2019/08/07/5d4ab931aba2c.jpeg", 8.8f, "Narcos", 2015 },
                    { 2, "https://cnet1.cbsistatic.com/img/aTFHkUWhY0jK0ekKstyAfMd10xI=/940x0/2020/07/02/1a2c7d33-e1c4-4e31-b128-aff87dee41f6/art-of-mandalorian-final-cover-credits.jpg", 8.9f, "The Mandalorian", 2019 },
                    { 1, "https://cadenaser00.epimg.net/ser/imagenes/2019/05/23/television/1558591913_020782_1558595107_noticia_normal.jpg", 9.3f, "Juego de tronos", 2011 },
                    { 5, "https://p3c8r6f2.rocketcdn.me/web/wp-content/uploads/2020/01/The-Boys-portada-1280x640.jpg", 8.7f, "The Boys", 2019 }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "IdUsuario", "Apellidos", "Email", "Nombre", "Password" },
                values: new object[,]
                {
                    { 2, "ALUMNO", "alumno@alumno.com", "ALUMNO", "ALUMNO" },
                    { 1, "PERRY", "perry@perry.com", "PERRY", "PERRY" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "IdUsuario", "Apellidos", "Email", "Nombre", "Password" },
                values: new object[] { 3, "AZURE", "azure@azure.com", "AZURE", "AZURE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personajes");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
