using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POConBuilderDesignPattern.Models
{
    internal class Phone
    {
        public string Processor { get; set; }
        public string Display { get; set; }
        public string Battery { get; set; }
        public string Camera { get; set; }
        
        public string WirelessChargeSupport { get; set; }

        // Overriding ToString to display phone specifications...
        // In some Smart Phone Wirelesss Charging Support is Present so I just make it optional ... and it helps
        // To Demonstrate Builder Design pattern where we can represent our object in different way
        public override string ToString()
        {
            return $"Phone Specifications:\nProcessor: {Processor}" +
                   $"\nScreen: {Display}" +
                   $"\nBattery: {Battery}" +
                   $"\nCamera: {Camera}" +
                   (string.IsNullOrEmpty(WirelessChargeSupport) ? "" : $"\nWireless Charge Support: {WirelessChargeSupport}") +
                   "\n";
        }

    }
}
