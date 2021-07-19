﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SecureFlight.Core
{
    public class Error
    {
        [Required]
        public ErrorCode Code { get; set; }

        [Required]
        public string Message { get; set; }

        public string Target { get; set; }

        public IEnumerable<Error> Details { get; set; }

        public InnerError InnerError { get; set; }
    }
}
