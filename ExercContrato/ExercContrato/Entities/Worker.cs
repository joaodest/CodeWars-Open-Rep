﻿

using ExercContrato.Entities.Enums;
using System.Collections.Generic;

namespace ExercContrato.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
    }
}
