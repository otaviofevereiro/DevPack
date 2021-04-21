﻿using System;
using System.Collections.Generic;

namespace DevPack
{
    public class DevPackConfiguration
    {
        public TimeSpan DateTimeOffset { get; private set; }

        public DevPackConfiguration WithDateTimeOffSet(TimeSpan offset)
        {
            DateTimeOffset = offset;

            return this;
        }
    }
}
