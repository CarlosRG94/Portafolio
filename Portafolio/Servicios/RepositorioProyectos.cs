using Portafolio.Models;

namespace Portafolio.Servicios
{
    public class RepositorioProyectos:IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            var proyectos = new List<Proyecto>()
            {
                new Proyecto(){
                Titulo="Amazon",Descripcion="E-Commerce realizado ASP.NET Core",
                Link = "https://amazon.com",ImagenURL = "/Imagenes/amazon.png"
                },
                new Proyecto(){
                Titulo="New york times",Descripcion="Página de noticias en React",
                Link = "https://nytimes.com",ImagenURL = "/Imagenes/nyt.png"
                },
                new Proyecto(){
                Titulo="Redit",Descripcion="Red social para compartir en comunidades",
                Link = "https://reddit.com",ImagenURL = "/Imagenes/reddit.png"
                },
                new Proyecto(){
                Titulo="Steam",Descripcion="Tienda para comprar juegos",
                Link = "https://store.steampowered.com",ImagenURL = "/Imagenes/steam.png"
                }
              };
            return proyectos;
        }
    }
}
