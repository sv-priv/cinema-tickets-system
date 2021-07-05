using Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interface
{
    public interface IMovieService
    {
        List<Movie> GetAllMovies();
        Movie GetDetailsForMovie(Guid? id);
        void CreateNewMovie(Movie m);
        void UpdeteExistingProjection(Movie m);
        void DeleteProjection(Guid id);
    }
}
