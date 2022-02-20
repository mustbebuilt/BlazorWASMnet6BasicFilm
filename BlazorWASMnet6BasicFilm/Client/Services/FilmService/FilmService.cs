using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace BlazorWASMnet6BasicFilm.Client.Services.FilmService
{
    public class FilmService : IFilmService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;

        public FilmService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }

        public List<Film> Films { get; set; } = new List<Film>();


        public async Task GetAllFilms()
        {
            var result = await _http.GetFromJsonAsync<List<Film>>("api/film");
            if (result != null)
                Films = result;
        }

    }
}
