﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DBInterface
{
    public interface IClock
    {
        UInt32 NetMinutes { get; set; }
        UInt32 NetHours { get;set; }
    }
}
