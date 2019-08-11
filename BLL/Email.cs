using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Email:Entity
    {
        public string Address { get; set; }
        public string ValidationCode { get; set; }
        public DateTime? EmailHasValidated { get; set; }

        public void MakeValidationCode()
        {
            if (!string.IsNullOrEmpty(ValidationCode))
            {
                throw new Exception($"在ValidationCode已经有值（当前值为{ValidationCode}）的情况下，试图再次生成");
            }
            ValidationCode = new Random().Next(1000,9999).ToString();
        }

        public void Send()
        {

        }



        public void Validate()
        {
            EmailHasValidated = DateTime.Now;
        }
    }
}
