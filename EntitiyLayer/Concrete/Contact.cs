﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrate
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        [StringLength(100)]
        public string UsarName { get; set; }
        [StringLength(50)]
        public string UsarMail { get; set; }

        [StringLength(50)]
        public string Subject { get; set; }
        [StringLength(1000)]
        public string Message { get; set; }
    }
}
