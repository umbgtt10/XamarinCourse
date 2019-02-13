using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace XamarinCourse.DataAccess.Exercise.NetflixRoulette
{
    public class NetFlixDataAccess : DataAccess
    {
        // Unfortunately this cannot be tested for the API has been changed completely...
        private readonly string _urlActor = "http://netflixroulette.net/api/api.php?actor={0}";
        private string _urlTitle = "http://netflixroulette.net/api/api.php?title={0}";

        public async Task<IEnumerable<Movie>> GetByActorAsync(string actor)
        {
            var url = string.Format(_urlActor, actor);

            using (var handler = new HttpClientHandler())
            {
                using (var client = new HttpClient(handler))
                {
                    var response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        if (response.StatusCode == HttpStatusCode.NotFound)
                        {
                            return JsonConvert.DeserializeObject<IEnumerable<Movie>>(
                                string.Empty);
                        }
                        else
                        {
                            return JsonConvert.DeserializeObject<IEnumerable<Movie>>(
                                await response.Content.ReadAsStringAsync());
                        }
                    }

                    return JsonConvert.DeserializeObject<IEnumerable<Movie>>(
                        string.Empty);
                }
            }
        }

        public async Task<Movie> GetByTitleAsync(string title)
        {
            var url = string.Format(_urlTitle, title);

            using (var handler = new HttpClientHandler())
            {
                using (var client = new HttpClient(handler))
                {
                    var response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        if (response.StatusCode == HttpStatusCode.NotFound)
                        {
                            return JsonConvert.DeserializeObject<Movie>(
                                string.Empty);
                        }
                        else
                        {
                            return JsonConvert.DeserializeObject<Movie>(
                                await response.Content.ReadAsStringAsync());
                        }
                    }

                    return JsonConvert.DeserializeObject<Movie>(
                        string.Empty);
                }
            }
        }
    }
}
