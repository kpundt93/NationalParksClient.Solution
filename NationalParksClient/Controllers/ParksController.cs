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
      var allTrails = Park.GetParks();
      return View(allTrails);
    }

  }
}