using POConBuilderDesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POConBuilderDesignPattern.Builders
{
    internal interface IPhoneBuilder
    {
        IPhoneBuilder AddProcessor(string processor);
        IPhoneBuilder AddDisplay(string display);
        IPhoneBuilder AddBattery(string battery);
        IPhoneBuilder AddCamera(string camera);
        IPhoneBuilder AddWirelessCharger(string charger);   
        Phone Build(); 
    }
}
