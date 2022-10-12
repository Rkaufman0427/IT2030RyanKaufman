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
        public double? Subtotal { get; set; }

        [Required(ErrorMessage = "Please enter a tax percent.")]
        public double? TaxPercent { get; set; }

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