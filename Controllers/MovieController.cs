using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MovieWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class MovieController : ControllerBase
    {
      List<Movie> _movieList;

      public MovieController(List<Movie> movieList)
      {
          _movieList = movieList;
      } 

        [HttpGet]
        public List<Movie> GetAllMovies()
        {
            return _movieList;
        }

         [HttpPost]
        public string CreateMovie(Movie myNewMovie)
        {   
            _movieList.Add(myNewMovie);
            return "Creating movie";
        }
          
          // Next week...
        [HttpPut]
        public string UpdateMovie()
        {
            return "Updating movie";
        }

        [HttpDelete]
        public string DeleteMovie()
        {
            return "Deleting movie";
        }   
    

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}