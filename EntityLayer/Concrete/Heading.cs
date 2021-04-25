﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        [Key]
        public int HeadingID { get; set; }


        [StringLength(50)]
        public string HeadingName { get; set; }
        public DateTime Date { get; set; }


        public int CategoryID { get; set; }
        public virtual  Category Category { get; set; }

        public int? AuthorID { get; set; }
        public virtual Author Author { get; set; }

        public ICollection<Content> Contents { get; set; }
    }
}
