﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IspitIB220035
{
    public class DrzaveIB220035
    {
        public int Id { get; set; }
        public string Naziv {  get; set; }
        public bool Status { get; set; }
        public byte[] Zastava { get; set; }
        public override string ToString()
        {
            return Naziv;
        }
    }
}
