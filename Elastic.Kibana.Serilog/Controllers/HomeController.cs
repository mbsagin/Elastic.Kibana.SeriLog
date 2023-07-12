using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Elastic.Kibana.Serilog.Models;

namespace Elastic.Kibana.Serilog.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        _logger.LogTrace(
            $"LogTrace from Index at {DateTime.UtcNow}");
        _logger.LogDebug(
            $"LogDebug from Index at {DateTime.UtcNow}");
        _logger.LogInformation(
            $"LogInformation from Index at {DateTime.UtcNow}");
        _logger.LogWarning(
            $"LogWarning from Index at {DateTime.UtcNow}");
        _logger.LogError(
            $"LogError from Index at {DateTime.UtcNow}");
        _logger.LogCritical(
            $"LogCritical from Index at {DateTime.UtcNow}");

        return View();
    }

    public IActionResult Privacy()
    {
        _logger.LogTrace(
    $"LogTrace from Privacy at {DateTime.UtcNow}");
        _logger.LogDebug(
            $"LogDebug from Privacy at {DateTime.UtcNow}");
        _logger.LogInformation(
            $"LogInformation from Privacy at {DateTime.UtcNow}");
        _logger.LogWarning(
            $"LogWarning from Privacy at {DateTime.UtcNow}");
        _logger.LogError(
            $"LogError from Privacy at {DateTime.UtcNow}");
        _logger.LogCritical(
            $"LogCritical from Privacy at {DateTime.UtcNow}");

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
