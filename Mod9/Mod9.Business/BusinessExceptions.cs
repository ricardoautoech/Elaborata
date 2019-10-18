using System;
using System.Collections.Generic;
using System.Text;

namespace Mod9.Business
{
    public class BusinessExceptions : Exception
    {
        public BusinessExceptions(string msg) : base(msg)
        {

        }
        public BusinessExceptions(string msg, Exception ex) : base(msg, ex)
        {

        }
        public void Tratar()
        {

        }
    }
}
