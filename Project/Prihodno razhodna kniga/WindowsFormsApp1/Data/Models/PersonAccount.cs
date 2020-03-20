﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Data.Models
{
    public class PersonAccount
    {
        [Key]
        public int PersonRegistersId { get; set; }

        [ForeignKey(nameof(PersonBook))]
        public int PersonBookTypesId { get; set; }
        public virtual PersonBookType PersonBook { get; set; }
    }
}
