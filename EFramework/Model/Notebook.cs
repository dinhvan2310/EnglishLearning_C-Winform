﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFramework.Model
{
    [Table("Notebook")]
    public class Notebook
    {
        [Key]
        [Column(Order = 0)]
        [ForeignKey(nameof(Account))]
        public int AccountID { set; get; }
        [Key]
        [Column(Order = 1)]
        [ForeignKey(nameof(Wn_Word))]
        public decimal SynsetID { set; get; }
        [Key]
        [Column(Order = 2)]
        [ForeignKey(nameof(Wn_Word))]
        public decimal WordNum { set; get; }
        public int LearnedPercent { set; get; }

        public virtual Account Account { set; get; }
        public virtual wn_word Wn_Word { set; get; }

    }
}
