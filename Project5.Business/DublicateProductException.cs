using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5.Business
{
    public class DublicateProductException : Exception // own exception class
    {
        public DublicateProductException(string message):base(message) // if can't adding string message, you can't send message to user.
        // The message starting with the capital letter m is an parameter of exception. Therefore, we need to call the exception constructor with the base.

        {

        }
    }
}
