﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Application.Common.Interfaces
{
    public interface IDateTimeProvider
    {
        public DateTime UtcNow { get; }
    }
}
