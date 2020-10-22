using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using CCB_Administrativo.Models;
using System.Net.Http.Json;

namespace CCB_Administrativo.Helpers
{
    public class API : ComponentBase
    {
        [Inject] public NavigationManager Navigation { get; set; }
        public HttpClient Http { get; set; } = new HttpClient();

        #region OBREIROS
        public const string ObreirosApi = "Api/Obreiros";
        public async Task<List<Obreiro>> GetObreiros()
        {
            return await Http.GetFromJsonAsync<List<Obreiro>>($"{Navigation.BaseUri}{ObreirosApi}");
        }

        public async Task<Obreiro> GetObreiro(int id)
        {
            return await Http.GetFromJsonAsync<Obreiro>($"{Navigation.BaseUri}{ObreirosApi}/{id}");
        }

        public async Task PostObreiro(Obreiro obreiro)
        {
            await Http.PostAsJsonAsync($"{Navigation.BaseUri}{ObreirosApi}", obreiro);
        }

        public async Task PutObreiro(Obreiro obreiro)
        {
            await Http.PutAsJsonAsync($"{Navigation.BaseUri}{ObreirosApi}/{obreiro.ID}", obreiro);
        }

        public async Task DeleteObreiro(int id)
        {
            await Http.DeleteAsync($"{Navigation.BaseUri}{ObreirosApi}/{id}");
        }
        #endregion
    }
}
