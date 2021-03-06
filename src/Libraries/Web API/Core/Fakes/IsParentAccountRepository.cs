// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.Entities.Core;

namespace MixERP.Net.Api.Core.Fakes
{
    public class IsParentAccountRepository : IIsParentAccountRepository
    {
        public long Parent { get; set; }
        public long Child { get; set; }

        public bool Execute()
        {
            return new bool();
        }
    }
}