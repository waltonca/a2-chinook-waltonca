﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2500_A2_Chinook.Models
{
    public partial class Track
    {
        public string FormattedPrice
        {
            get
            {
                return string.Format("Price: ${0:N2}", UnitPrice);
            }
        }
    }
}
