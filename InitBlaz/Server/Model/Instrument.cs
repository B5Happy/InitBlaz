﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InitBlaz.Server.Model
{
    /// <summary>
    /// Model Instrument.
    /// </summary>
    public class Instrument
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Strings { get; set; }
        public int YearManufacture { get; set; }
    }
}
