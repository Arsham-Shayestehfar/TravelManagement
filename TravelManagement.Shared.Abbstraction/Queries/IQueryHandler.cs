﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelManagement.Shared.Abbstraction.Queries
{
    public interface IQueryHandler<in TQuery, TResult> where TQuery : class, IQuery<TResult>
    {
        Task<TResult> HandleAsync(TQuery query);
    }
}
