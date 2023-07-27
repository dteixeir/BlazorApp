using BlazorApp.Data;
using Microsoft.AspNetCore.Components;

namespace Project.Pages
{
  public partial class FetchData : ComponentBase
  {
    private WeatherForecast[]? forecasts;

    [Inject]
    private WeatherForecastService _weatherForecastService { get; set; } = default!;

    protected override async Task OnInitializedAsync()
    {
      forecasts = await _weatherForecastService.GetForecastAsync(DateOnly.FromDateTime(DateTime.Now));
    }
  }
}