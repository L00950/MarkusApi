using System;
using Microsoft.AspNetCore.Mvc;

namespace MarkusApi
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class BasicAuthorizeAttribute : TypeFilterAttribute
    {
        public BasicAuthorizeAttribute(string realm = null)
            : base(typeof(BasicAuthorizeFilter))
        {
            Arguments = new object[]
            {
                realm
            };
        }
    }
}