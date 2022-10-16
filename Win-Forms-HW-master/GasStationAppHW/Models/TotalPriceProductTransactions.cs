using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp6.Models
{
    public class TotalPriceProductTransactions
    {
        public float TotalCafe { get; set; }
        public float TotalGasStation { get; set; }
        public DateTime TimeTranscations { get; set; } = DateTime.Now;
        public override string ToString()
        {
            return $"Total - {TotalCafe + TotalGasStation}   " +
                $"Payment time - {TimeTranscations.ToString("yyyy:MM:dd")} ";
        }

        public string LongToString()
        { 
            return $" Total cafe - {TotalCafe}\n " +
                $"Total gas station - {TotalGasStation}\n " +
                $"Total - {TotalCafe + TotalGasStation}\n " +
                $"Payment time {TimeTranscations.ToString("yyyy:MM:dd , HH::mm:ss")}\n\n ";
        }

    }
}
