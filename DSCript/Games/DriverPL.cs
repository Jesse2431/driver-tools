using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DSCript
{
    public sealed class DriverPL
    {
        // List of vehicles + ID's found by Fireboyd78
        public static readonly Dictionary<int, string> VehicleNames = new Dictionary<int, string>() {
            { 0, "Coyote" },
            { 1, "?" }, // YET UNKNOWN, NULL VEHICLE?
            { 2, "?" }, // YET UNKNOWN, NULL VEHICLE?
            { 3, "Taxi" },
            { 4, "Bus" },
            { 5, "Truck" },
            { 6, "Dash_Test" },
            { 7, "?" }, // YET UNKNOWN, NULL VEHICLE?
            { 8, "Bronco" },
            { 9, "Tram" },
            { 10, "Delivery_van" },
            { 11, "Fairview" },
            { 12, "Traveller" },
            { 13, "Armored_bus" },
            { 14, "Dodge_Conquest" },
            { 15, "Cop_Car" },
            { 16, "Firetruck" },
            { 17, "Parademic" },
            { 18, "Refuse_truck" },
            { 19, "Boldius" },
            { 20, "Namorra" },
            { 21, "Regina" },
            { 22, "San_Marino" },
            { 23, "SWAT" },
            { 24, "Brooklyn" },
            { 25, "Ford_Thunderbird" },
            { 26, "Dodge_Charger" },
            { 27, "Dodge_Challenger" },
            { 28, "Ford_GranTorino" },
            { 29, "4x4" },
            { 30, "Mob4x4" },
            { 31, "Ford_GT5" },
            { 32, "ArmVan" },
            { 33, "RC_Truck" },
            { 34, "Old_Car" },
            { 35, "Sheriff_Cop" },
            { 36, "COP_Mission" },
            { 37, "Boltus" },
            { 38, "Mission_Truck" },
            { 39, "Brooklyn Sport" },
            { 40, "Brooklyn_Sport" },
            { 41, "Customs_Van" },
            { 42, "Box_Van" },
            { 43, "RC_Car" },
            { 44, "RC_Sport" },
            { 45, "RC_Muscle" },
            { 46, "Car_Truck" },
            { 47, "Fairview_Sport" },
            { 48, "Namorra_Sport" },
            { 49, "San_Marino_Sport" },
            { 50, "Armtruck" },
            { 51, "Super_Cop" },
            { 52, "TV_Van"},
            { 53, "Paramedic_Mission" },
            { 54, "Van_Mission" },

            { 55, "<NULL>" }
        };
    }
}
