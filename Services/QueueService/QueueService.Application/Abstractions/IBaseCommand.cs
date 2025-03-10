﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueService.Application.Abstractions
{
    public interface IBaseCommand<TResponse> : IRequest<Result<TResponse>>
    {

    }
}
