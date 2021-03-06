﻿using System;

namespace WebSample.Domain
{
    public class User
    {
        public int I { get; private set; }
        public string UserId { get; set; }

        public string UserName { get; set; }

        public DateTime CreateTime { get; set; }

        public decimal Money { get; set; }
    }

    public class Manager
    {
        public string UserId { get; set; }

        public string UserName { get; set; }

        public DateTime CreateTime { get; set; }

        public decimal Money { get; set; }
    }
}