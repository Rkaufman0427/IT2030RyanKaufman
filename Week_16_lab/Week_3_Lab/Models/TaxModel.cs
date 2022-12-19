using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Week_3_Lab.Models
{
    public class TaxModel
    {
        [Required(ErrorMessage = "Please enter a Subtotal.")]
        [Range(0, 9999999, ErrorMessage = "Enter a value between 0 and 9999999.")]
        public double? Subtotal { get; set; }

        [Required(ErrorMessage = "Please enter a Tax Percent.")]
        [Range(0, 100, ErrorMessage = "Enter a value between 0 and 100.")]
        public double? TaxPercent { get; set; }

        public double? TaxAmount { get; set; }
        public double? Total { get; set; }


        public double? CalculateTaxAmount()
        {
            double? TaxAmountCal = TaxPercent * 0.01;
            double? TaxAmount = TaxAmountCal * Subtotal;
          
            return TaxAmount;
        }

        public double? CalculateTotal()
        {
            double? Total = Subtotal + CalculateTaxAmount();

            return Total;
        }

    }
}