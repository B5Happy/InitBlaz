using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace InitBlaz.Client.Services.Http
{
    /// <summary>
    /// Http weather service
    /// </summary>
    public interface IHttpsWeatherService
    {
        Task<HttpResponseMessage> GetWeatherForcasts();
    }
}
