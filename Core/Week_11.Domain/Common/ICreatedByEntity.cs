﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_11.Domain.Common
{
    public interface ICreatedByEntity
    {
        DateTimeOffset CreatedOn { get; set; }
    }
}
