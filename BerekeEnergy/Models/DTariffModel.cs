using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BerekeEnergy.Models
{
    public class DTariffModel
    {
    public int Id { get; set; } 
    public int device_Id { get; set; } 
    public int tariff_1 { get; set; } 
    public int tariff_2 { get; set; } 
    public int tariff_3 { get; set; }
    public int tariff_4 { get; set; } 
    }
}