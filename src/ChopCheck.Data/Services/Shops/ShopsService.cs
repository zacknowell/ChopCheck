using System;
using System.Collections.Generic;
using System.Text;
using ChopCheck.Data.EntityFramework;
using ChopCheck.Data.Models;

namespace ChopCheck.Data.Services
{
    public class ShopsService : ServiceBase<Branch>
    {
        private readonly ChopCheckContext context;

        public ShopsService(ChopCheckContext context) : base(context)
        {
            this.context = context;
        }
    }
}
