﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.Common
{
    [Serializable]
    public class AdminLogin
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
    }
}