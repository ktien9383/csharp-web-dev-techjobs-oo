using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
    public abstract class JobField
    {
        public int Id { get; }
        public string Value { get; set; }
        private static int nextId = 1;

        public JobField()
        {
            Id = nextId;
            nextId++;
        }

        public JobField(string value) : this()
        {
            Value = value;
        }
    }
}
