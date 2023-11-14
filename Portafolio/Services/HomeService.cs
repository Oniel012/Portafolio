using Portafolio.Models;
using Portafolio.Services.Interface;

namespace Portafolio.Services
{
    public class HomeService: IHomeService
    {
        public List<ProyectDto> Proyects()
        {
            return new List<ProyectDto>()
            {
               new ProyectDto
               {
                   Title = "Contabilidad",
                   Description = "Web para contables",
                   ImgUrl = "/img/netcore.png",
                   link = "https://google.com.do"
               },
               new ProyectDto
               {
                   Title = "Movil",
                   Description = "App movil",
                   ImgUrl = "/img/imgF.png",
                   link = "https://amazon.com"
               },
                new ProyectDto
               {
                   Title = "Nueva app movil",
                   Description = "Nuevo uso de app movil",
                   ImgUrl = "/img/flutter.png",
                   link = "https://facebook.com"
               },
                 new ProyectDto
               {
                   Title = "Geser",
                   Description = "Web que administra tareas",
                   ImgUrl = "",
                   link = "https://unicaribe.com",
               }

            };
        }
    }
}
