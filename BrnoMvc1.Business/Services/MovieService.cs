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
        private readonly ApplicationDbContext applicationDbContext;

        public MovieService(IEmailService emailService, ApplicationDbContext applicationDbContext)
        {
            this.emailService = emailService;
            this.applicationDbContext = applicationDbContext;
        }

        public void CreateFilm()
        {
            // TODO create
            applicationDbContext
            this.emailService.Send("Email has been created");
        }
    }
}
