﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharedClasses
{
    [Serializable]
    public class GetUserDataMessage
    {
        public string Username;
        public string Password;
    }
}
