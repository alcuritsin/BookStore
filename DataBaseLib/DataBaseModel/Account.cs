﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib.DataBaseModel
{
    public class Account:DataModel
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
    }
}
