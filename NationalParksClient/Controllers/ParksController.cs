using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NationalParksClient.Models;

namespace NationalParksClient.Controllers
{
  public class ParksController : Controller
  {
    public IActionResult Index()
    {
      var allParks = Park.GetParks();
      return View(allParks);
    }

    public IActionResult Details(int id)
    {
      var park = Park.GetDetails(id);
      return View(park);
    }

  }
}