using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using PetDesk.Vet.Api.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace PetDesk.Vet.Api.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<Appointment> _logger;

        public AppointmentService(IHttpClientFactory httpClientFactory,
                                  ILogger<Appointment> logger)
        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
        }

        public async Task<IEnumerable<Appointment>> GetAppointments()
        {
            try
            {
                using var client = _httpClientFactory.CreateClient("Appointments");
                var response = await client.GetAsync("api/appointments");
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonConvert.DeserializeObject<IEnumerable<Appointment>>(content);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                throw;
            }
        }
    }
}
