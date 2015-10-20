﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SleepHunter.Win32
{
   internal enum ProcessCreationFlags : uint
   {
      None = 0x0,
      Debug = 0x1,
      DebugOnlyThis = 0x2,
      Suspended = 0x4
   }
}
