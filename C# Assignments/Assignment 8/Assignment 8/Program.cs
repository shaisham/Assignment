using System;
using System.Reflection;

namespace Assignment_8
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

            class Properties
            {
                static void Main(string[] args)
                {

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
