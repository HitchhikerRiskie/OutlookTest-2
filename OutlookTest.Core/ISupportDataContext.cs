﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookTest.Core
{
    public interface ISupportDataContext
    {
        object DataContext { get; set; }
    }
}
