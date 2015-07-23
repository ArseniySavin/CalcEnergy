using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BerekeEnergy.Models
{
    public class DTariffModel
    {
    public int Id { get; set; }
    public string code { get; set; }
    public string name { get; set; }
    public int device_Id { get; set; }
    public decimal tariff_1 { get; set; }
    public decimal? tariff_2 { get; set; }
    public decimal? tariff_3 { get; set; }
    public decimal? tariff_4 { get; set; } 
    }
}