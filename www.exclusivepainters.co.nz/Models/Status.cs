
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using www.exclusivepainters.co.nz.DAL;

namespace www.exclusivepainters.co.nz.Models
{
    public class Status
    {
        [Key]
        [ForeignKey("Job")]
        public int JobId { get; set; }

        public bool QuotedFor { get; set; }
        public bool PriceForJob { get; set; }
        public DateTime StartedOn { get; set; }
        public bool HasStarted { get; set; }
        public bool HasFinished { get; set; }
        public DateTime CompletedOn { get; set; }
        public double Duration { get; set; }
        public int PercentageOfWordDone { get; set; }
        public double Profit { get; set; }

        public virtual Job Job { get; set; }

    }
}