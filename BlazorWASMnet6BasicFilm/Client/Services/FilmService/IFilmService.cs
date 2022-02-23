using BlazorWASMnet6BasicFilm.Shared;

namespace BlazorWASMnet6BasicFilm.Client.Services.FilmService
{
    public interface IFilmService
    {
        List<Film> Films { get; set; }
        Task GetAllFilms();
        Task<Film> GetSingleFilm(int id);
    }
}
