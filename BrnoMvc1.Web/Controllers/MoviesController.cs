using BrnoMvc1.Business.Services;
using BrnoMvc1.Web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BrnoMvc1.Web.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IEmailService emailService;
        private readonly IMovieService movieService;
        private readonly ApplicationDbContext context;

        public List<MovieViewModel> MoviesViewModel { get; set; } = new List<MovieViewModel>();
        public List<Movie> Movies { get; set; } = new List<Movie>();

        public MoviesController(IEmailService emailService, IMovieService movieService, ApplicationDbContext context)
        {
            //this.Movies.Add(new MovieViewModel { Id = 1, Title = "Pelisky" });
            //this.Movies.Add(new MovieViewModel { Id = 2, Title = "Pelisky" });
            //this.Movies.Add(new MovieViewModel { Id = 3, Title = "Homer" });

            this.Movies = this.context.Movies.ToList();

            //context.Set<Movie>().Create()
            //context.Database.Log = x => { context.Movies.Add(new Movie() { Title = x }); };
            //context.Set<Movie>().Add(new Movie() { Title = "Test LOG" });
            //context.SaveChanges();

            //this.MoviesViewModel = this.Movies.Select(x => new MovieViewModel() { Id = x.Id, Title = x.Title }).ToList();

            var movie = new Movie() { Id = 20, Title = "Test Auto Mapper" };
            var movieViewModel = new MovieViewModel();

            //movieViewModel.Id = movie.Id;
            //movieViewModel.Title = movie.Title;
            movieViewModel = AutoMapper.Mapper.Map<Movie, MovieViewModel>(movie);
            this.MoviesViewModel = AutoMapper.Mapper.Map<List<Movie>, List<MovieViewModel>>(this.Movies);
            this.emailService = emailService;
            this.movieService = movieService;
            this.context = context;


            // Debugger.Break();


        }



        // GET: Movies
        public ActionResult Index()
        {
            //if(CurrentCulture)

            //this.TempData["Key"] = "Value from Movies";

            return View();
        }

        public ActionResult Released(int year, int month)
        {
            return this.Content($"Year={year} Month={month}");
        }

        public ActionResult Create()
        {
            MovieViewModel model = new MovieViewModel();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MovieViewModel model)
        {
            if (string.IsNullOrEmpty(model.Title))
            {
                this.ModelState.AddModelError(nameof(MovieViewModel.Title), "Title is required");
            }

            if (this.ModelState.IsValid)
            {
                return this.Json(model, JsonRequestBehavior.AllowGet);
            }

            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MovieViewModel model)
        {
            using (var context = new ApplicationDbContext())
            {
                //var entity = context.Movies.FirstOrDefault(x => x.Id == model.Id);
                var entity = new Movie() { Id = model.Id };
                context.Movies.Attach(entity);

                entity.Title = model.Title;
                context.SaveChanges();
            }

            return View(model);
        }

        public ActionResult SendMovieByEmail(int id)
        {
            var movie = this.context.Movies.FirstOrDefault(x => x.Id == id);
            //var emailService = new Business.Services.EmailService();
            //this.emailService.Send($"Movie {movie.Id} {movie.Title}");

            this.movieService.CreateFilm();
            
            return Content("Yeah. The email will be delivered in a moment :)");
        }
    }
}