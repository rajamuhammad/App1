using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public byte Experience { get; set; }

        public string Degree { get; set; }

    }
}