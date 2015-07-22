using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BerekeEnergy.Models
{
    public class VTestimony
    {
    public int Id { get; set; }	
	public decimal general_T { get; set; }	
	public decimal tt_1 { get; set; }	
	public decimal tt_cof_1 { get; set; }	
	public decimal amount_tt_cof_1 { get; set; }	
	public decimal tt_2 { get; set; }
	public decimal tt_Cof_2 { get; set; }
	public decimal amount_tt_cof_2 { get; set; }
	public decimal tt_3 { get; set; }
	public decimal tt_cof_3 { get; set; }
	public decimal amount_tt_cof_3 { get; set; }
	public decimal tt_4 { get; set; }
	public decimal tt_cof_4 { get; set; }
	public decimal amount_tt_cof_4 { get; set; }
	public decimal total { get; set; }
    public decimal date_of_testimony { get; set; }	

    }
}