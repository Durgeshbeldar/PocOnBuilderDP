using POConBuilderDesignPattern.Builders;
using POConBuilderDesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POConBuilderDesignPattern.Presentation
{
    internal class BuilderPatternDemoUI
    {
        public static void PocOnBuilderDP()
        {
            // Hello This is an POC on Builder Design Pattern... So Lets understand!

            /* Explaination : The Builder Design Pattern is Pattern which helps us to create complex objects
               it also allow us an flexibility while creating an object. 

            ** Why we need Builders : 
               1. Provide More Flexible Way to Create and Complex Objects.
               2. Prevents the Constructor Overloading.
               3. Prevents the Constructor Chaining
               4. We have to pass so many argument list in a complex obejcts so it reduces the overhead.
               5. Some Parameters might be optional Which I Demonstrated in 2nd Example
            */


            // 1st Example 

            IPhoneBuilder phoneBuilder = new PhoneBuilder();
            Phone customPhone = phoneBuilder
                .AddProcessor("Mediatek Dimensity 7300")
                .AddDisplay("6.77-inch OLED Display")
                .AddBattery("5500mAh")
                .AddCamera("50MP Dual Camera")
                .AddWirelessCharger("Support Wireless Charging")
                .Build();

            Console.WriteLine("Custom Built Phone1:\n");
            Console.WriteLine(customPhone + "\n\n");

            // 2nd Example  Here we Skip the Wireless Charging Supported Hardware Component.

            IPhoneBuilder phoneBuilder1 = new PhoneBuilder();
            Phone customPhone1 = phoneBuilder1
                .AddProcessor("Snapdragon 712")
                .AddDisplay("6.3-inch IPS Display")
                .AddBattery("4500mAh")
                .AddCamera("32MP Dual Camera") // After Camera I Skipped Wireless Charging Support Option...
                .Build();

            Console.WriteLine("Custom Built Phone2:\n");
            Console.WriteLine(customPhone1);

            // I have Demonstrated POC on Builder Design Pattern, Thank You!
        }
    }
}
