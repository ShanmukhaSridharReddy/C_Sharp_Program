﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLayer.Models
{
    public class ForgotPassword
    {
        public int Id {  get; set; }
        public string Email {  get; set; }
        public string Token { get; set; }
    }
}
