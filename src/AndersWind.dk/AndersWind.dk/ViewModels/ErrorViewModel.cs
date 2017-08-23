﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndersWind.dk.ViewModels
{
    public class ErrorViewModel : ViewModelBase
    {
        public string HeaderImage { get; set; }
        public string ErrorMessage { get; set; } = "Ups something went wrong on our end";
    }
}
