using Kmakai.ShiftsLogger.Models;
using System.Net.Http.Json;

namespace Kmakai.ShiftsLoggerUI.Services;

public class ShiftsLoggerService
{
    private readonly HttpClient _httpClient;
    private readonly string _baseUrl = "https://localhost:7168/";

    public ShiftsLoggerService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<Shift>> GetShiftsAsync()
    {
        return await _httpClient.GetFromJsonAsync<IEnumerable<Shift>>(_baseUrl + "api/shifts");
    }

    public async Task<Shift> GetShiftAsync(int id)
    {
        return await _httpClient.GetFromJsonAsync<Shift>(_baseUrl + $"api/shifts/{id}");
    }

    public async Task<Shift> AddShiftAsync(Shift shift)
    {
        var response = await _httpClient.PostAsJsonAsync("api/shifts", shift);
        return await response.Content.ReadFromJsonAsync<Shift>();
    }

    public async Task UpdateShiftAsync(Shift shift)
    {
        await _httpClient.PutAsJsonAsync($"api/shifts/{shift.Id}", shift);
    }

    public async Task DeleteShiftAsync(int id)
    {
        await _httpClient.DeleteAsync($"api/shifts/{id}");
    }
}
