using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BerekeEnergy.Models
{
    public class DDevaceModel
    {
    public int Id { get; set; }
    public string code { get; set; }	
	public string name	{ get; set; }
	public int coefficient { get; set; }
    public DTypeDeviceModel TypeDevice { get; set; }
    public DTariffModel Tariff { get; set; }
    }
}