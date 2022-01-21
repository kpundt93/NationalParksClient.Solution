using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace NationalParksClient.Models
{
  public class Park
  {
    public int ParkId { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; }

    [Required]
    [StringLength(2)]
    public string State { get; set; }

    public string Description { get; set; }

    [Required]
    [RegularExpression(@"^(?:Yes|No)$")]
    public string Visited { get; set; }
  }

  public static List<Park> GetParks()
  {
    var apiCallTask = ApiHelper.GetAll();
    var result = apiCallTask.Result;

    JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
    List<Park> parkList = JsonConvert.DeserializeObject<List<Park>>(jsonResponse.ToString());

    return parkList;
  }
}