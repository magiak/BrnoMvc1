using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrnoMvc1.Business.Services
{
    public class MovieService : IMovieService
    {
        private readonly IEmailService emailService;

        public MovieService(IEmailService emailService)
        {
            this.emailService = emailService;
        }

        public void CreateFilm()
        {
            // TODO create
            this.emailService.Send("Email has been created");
        }
    }
}
