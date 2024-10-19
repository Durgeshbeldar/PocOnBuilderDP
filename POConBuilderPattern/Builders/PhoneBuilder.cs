using POConBuilderDesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POConBuilderDesignPattern.Builders
{
    internal class PhoneBuilder : IPhoneBuilder
    {
        Phone _phone;
        public PhoneBuilder()
        {
            _phone = new Phone();
        }

        // Step-by-step methods to build parts of the phone
        public IPhoneBuilder AddProcessor(string processor)
        {
            _phone.Processor = processor;
            return this; 
        }

        public IPhoneBuilder AddDisplay(string display)
        {
            _phone.Display = display;
            return this;
        }

        public IPhoneBuilder AddBattery(string battery)
        {
            _phone.Battery = battery;
            return this;
        }

        public IPhoneBuilder AddCamera(string camera)
        {
            _phone.Camera = camera;
            return this;
        }

        public IPhoneBuilder AddWirelessCharger(string wirelessCharger) 
        {
            _phone.WirelessChargeSupport = wirelessCharger;
            return this;
        }

        // Final step to return the completed phone
        public Phone Build()
        {
            return _phone;  
        }

    }
}
