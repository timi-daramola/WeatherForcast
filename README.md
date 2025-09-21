# BlazorWeatherApp

![Blazor](https://img.shields.io/badge/Blazor-Server-blue)
![.NET](https://img.shields.io/badge/.NET-8.0-blue)
![License](https://img.shields.io/badge/License-MIT-green)

**BlazorWeatherApp** is a simple Blazor Server application that displays weather forecasts, includes a counter feature, and has a responsive sidebar navigation. The app demonstrates interactive Blazor components, dynamic styling based on weather conditions, and a clean UI with Bootstrap and custom CSS.

---

## Features

- **Home Page**
  - Hero section with welcome message
  - Current weather overview
  - Weather forecast cards with temperature-based colors and icons
- **Counter Page**
  - Simple counter component that increments on button click
  - Styled counter card
- **Weather Page**
  - Fetches and displays a list of weather forecasts
  - Temperature-based card coloring
  - Weather icons for different summaries
- **Sidebar Navigation**
  - Persistent sidebar for navigation between pages
  - Highlights the active page

---

## Technologies Used

- **Blazor Server** (.NET 8)
- **C#**
- **Bootstrap 5**
- **Custom CSS for styling**
- **ASP.NET Core Dependency Injection**
- **Razor Components**

---

## Project Structure

```
BlazorWeatherApp/
├─ Pages/
│  ├─ Index.razor       # Home page
│  ├─ Counter.razor     # Counter page
│  ├─ FetchData.razor   # Weather forecast page
│  ├─ _Host.razor       # Blazor host page
├─ Shared/
│  ├─ Sidebar.razor     # Sidebar component
├─ Data/
│  ├─ WeatherForecast.cs
│  ├─ WeatherForecastService.cs
├─ wwwroot/
│  ├─ css/site.css
│  ├─ bootstrap/
├─ App.razor
├─ Program.cs
└─ BlazorWeatherApp.csproj
```

---

## Setup & Run

1. **Clone the repository**
   ```bash
   git clone <repository-url>
   cd BlazorWeatherApp
   ```

2. **Restore NuGet packages**
   ```bash
   dotnet restore
   ```

3. **Run the application**
   ```bash
   dotnet run
   ```

4. **Open the app in your browser**
   ```
   http://localhost:5000
   ```

---

## Notes

- The app uses a `WeatherForecastService` to fetch weather data. This can be adapted to fetch real weather data from an API.
- The counter page demonstrates state updates using `@onclick` events in Blazor.
- CSS styling is included in `site.css` and is used to color weather cards based on temperature and style the sidebar.

---

## License

MIT License

