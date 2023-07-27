using BlazorApp.Data;
using Microsoft.AspNetCore.Components;

namespace Project.Pages
{
  public interface IFetchDataTable : IComponent
  {
    WeatherForecast[] forecasts { get; set; }
  }

  public partial class FetchDataTable : ComponentBase, IFetchDataTable
  {
    [Parameter]
    public WeatherForecast[] forecasts { get; set; } = default!;
  }
}