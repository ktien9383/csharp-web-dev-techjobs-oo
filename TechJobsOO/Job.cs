using System;
namespace TechJobsOO
{
    public class Job : JobField
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
           Name = name;
           EmployerName = employerName;
           EmployerLocation = employerLocation;
           JobType = jobType;
           JobCoreCompetency = jobCoreCompetency;
        }

        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            const string dataStr = "Data not available";
            string jobInfo;
            string nameStr = Name == "" ? dataStr : Name;
            string employerNameStr = EmployerName.Value == "" ? dataStr : EmployerName.Value; 
            string employerLocationStr = EmployerLocation.Value == "" ? dataStr: EmployerLocation.Value;
            string jobTypeStr = JobType.Value == "" ? dataStr : JobType.Value;    
            string jobCoreCompetencyStr = JobCoreCompetency.Value == "" ? dataStr : JobCoreCompetency.Value;    
            
            if (nameStr == dataStr  && employerNameStr == dataStr  && 
                employerLocationStr == dataStr && jobTypeStr == dataStr && 
                jobCoreCompetencyStr == dataStr)
            {
                jobInfo = $"\n***** OOPS! This job ID: {Id} does not seem to have data *****";
            }
            else
            {
                jobInfo = $"\nID: {Id}\nName: {nameStr}\nEmployer: {employerNameStr}" +
                          $"\nLocation: {employerLocationStr}" +
                          $"\nPosition Type: {jobTypeStr}" +
                          $"\nCore Competency: {jobCoreCompetencyStr}";
            }
            return jobInfo;
            
            
        }
    }
}
