using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.Common.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CarRent.Common.Infrastructure.Context
{
    public abstract class BaseDbContext : DbContext
    {
    }
}
