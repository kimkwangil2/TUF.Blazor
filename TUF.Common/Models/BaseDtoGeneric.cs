﻿
using Daniel.Common.Enums;
using Knus.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knus.Common.Models
{

    public class BaseDtoGeneric<T, S> : IResultModelGeneric<T, S>
    {
        public BaseDtoGeneric()
        {
            this.HasAlert = false;
            this.HasError = false;
            this.Success = true;
            this.Message = string.Empty;
        }
        public bool Success { get; set; }

        public bool HasAlert { get; set; }
        public bool HasError { get; set; }
        public string Message { get; set; }
        public List<string> ListMessage { get; set; } = new List<string>();

        public string SystemMessage { get; set; }

        public string Code { get; set; }
        public S InputValue { get; set; }
        public T OutPutValue { get; set; }
        public ContentState ContentState { get; set; }
        
        public void AlertMessage(string mes)
        {

            this.Message = mes;
            this.Success = false;
            this.HasAlert = true;
        }

        public void ErrorMessage(string mes)
        {
            this.Message = mes;
            this.Success = false;
            this.HasError = true;

        }
        public void SuccessSet()
        {

        }
    }
}
