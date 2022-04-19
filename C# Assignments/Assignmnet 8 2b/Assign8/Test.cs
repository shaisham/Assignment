using System;
using System.Reflection;

namespace Assign8
{
    class SoftwareAtttribute : Attribute
    {
        private string ProjectName;
        private string Description;
        private string ClientName;
        private string StartedDate;
        private string EndDate;



        public string projectName
        {
            get { return ProjectName; }
            set { ProjectName = value; }
        }
        public string description
        {
            get { return Description; }
            set { Description = value; }
        }
        public string clientName
        {
            get { return ClientName; }
            set { ClientName = value; }
        }
        public string startedDate
        {
            get { return StartedDate; }
            set { StartedDate = value; }
        }
        public string endDate
        {
            get { return EndDate; }
            set { EndDate = value; }
        }
        public class HDFCAccount : SoftwareAtttribute
        {
            public void displayAccount(string projectName, string description, string clientname)
            {

                this.Description = description;
                this.ProjectName = projectName;
                this.ClientName = clientname;
                Console.WriteLine("Project Description : " + Description);
                Console.WriteLine("Projectname : " + ProjectName);
                Console.WriteLine("Project Client Name : " + ClientName);

            }
        }

        public class ICICIAccount : SoftwareAtttribute
        {
            public void displayAccount(string description, string projectName, string clientname, string startdate, string enddate)
            {
                this.Description = description;
                this.ProjectName = projectName;
                this.ClientName = clientname;
                this.startedDate = startdate;
                this.EndDate = enddate;
                Console.WriteLine("\nProject Description : " + Description);
                Console.WriteLine("Projectname : " + ProjectName);
                Console.WriteLine("Project Client Name : " + ClientName);
                Console.WriteLine("Project Started Date : " + startedDate);
                Console.WriteLine("Project End Date : \n" + EndDate);
            }
        }

        class Test
        {
            static void Main(string[] args)
            {
                HDFCAccount hdfcacc = new HDFCAccount();
                hdfcacc.displayAccount(".net reflection assignment", "customattribute", "assignment8");
                ICICIAccount iciciacc = new ICICIAccount();
                iciciacc.displayAccount(".net reflection assignment", "customattribute", "assignment8", "01-04-2022", "12-04-2022");



                Assembly executing = Assembly.GetExecutingAssembly();
                Type[] types = executing.GetTypes();
                foreach (Type t in types)
                {
                    MethodInfo[] mi = t.GetMethods();
                    foreach (var m in mi)
                    {
                        Console.WriteLine(m);
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
