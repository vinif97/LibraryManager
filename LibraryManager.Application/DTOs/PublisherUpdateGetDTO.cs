﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Application.DTOs
{
    public class PublisherUpdateGetDTO
    {
        public int PublisherId { get; set; }
        public string? PublisherName { get; set; }
    }
}
