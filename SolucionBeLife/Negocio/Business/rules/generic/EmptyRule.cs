using Negocio.Business.exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Business.rules.generic
{
    public class EmptyRule
    {
        public void isEmpty(string nameElement,
            string value)
        {

            if (string.IsNullOrEmpty(value))
            {

                throw new BusinessException(
                    "EL CAMPO " + nameElement +
                    " NO PUEDE ESTAR EN BLANCO");
            }
        }
    }
}

