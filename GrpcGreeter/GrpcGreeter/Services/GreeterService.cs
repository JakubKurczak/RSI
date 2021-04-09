using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcGreeter
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<PolynomialResult> CalculatePolynomial(PolynomialRequest request, ServerCallContext context)
        {
            double Result = 0;
            for (int i = 0; i < request.BaseArray.Count; i++)
            {
                Result += request.BaseArray[i] * Math.Pow(request.X, i);
            }

            return Task.FromResult(new PolynomialResult
            {
                Result = Result


            });
    }

}
}

