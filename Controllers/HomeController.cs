﻿using System.Diagnostics;
using TrumpQuotes.WebSite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TrumpQuotes.Models;

namespace TrumpQuotes.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, HttpQuoteService quoteService)
    {
      _logger = logger;
      QuoteService = quoteService;
    }

    public HttpQuoteService QuoteService { get; }
    public QuoteModel Quote { get; set; }

    public IActionResult Index()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
