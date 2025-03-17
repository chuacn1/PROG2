﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public class Institution
    {
        private string name;
        private string region;
        private string country;
        public Institution(string name, string region, string country)
        {
            this.name = name;
            this.region = region;
            this.country = country;
        }

        public string Name { get => name; set => name = value; }
        public string Region { get => region; set => region = value; }
        public string Country { get => country; set => country = value; }

        public string DisplayInfo() => $"name: {name} , region: {region} , country: {country}";
    }
}
