using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        //Test the Empty Constructor 
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.AreEqual(job1.Id, job2.Id, 1);
            //Assert.IsTrue(job2.Id > job1.Id);
            //Assert.IsFalse(job1.Id > job2.Id);
        }

        //Test the Full Constructor 
        [TestMethod]
        public void TestJobConstructorSetAllFields()
        {
            Job job = new Job("Product tester", new Employer("ACME"), new Location("Desert"),
                              new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.IsTrue(job.Name == "Product tester" && job.EmployerName.Value == "ACME"
                          && job.EmployerLocation.Value == "Desert" && job.JobType.Value == "Quality control"
                          && job.JobCoreCompetency.Value == "Persistence");             
        }

        //Test the Equals() Method 
        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"),
                              new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Job job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"),
                              new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.IsFalse(job1.Id == job2.Id);
        }

        //Test the ToString() Method 
        [TestMethod]
        public void TestToString()
        {
            Job job = new Job("Product tester", new Employer("ACME"), new Location("Desert"),
                             new PositionType("Quality control"), new CoreCompetency("Persistence"));

            string nameStr = "Product tester";
            string employerNameStr = "ACME";
            string employerLocationStr = "Desert";
            string jobTypeStr = "Quality control";
            string jobCoreCompetencyStr = "Persistence";

            string expectedJob = $"\nID: {job.Id}\nName: {nameStr}\nEmployer: {employerNameStr}" +
                                 $"\nLocation: {employerLocationStr}" +
                                 $"\nPosition Type: {jobTypeStr}" +
                                 $"\nCore Competency: {jobCoreCompetencyStr}";

            Assert.IsTrue(job.ToString() == expectedJob);
        }
    }
}
