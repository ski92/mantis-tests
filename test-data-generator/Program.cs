using System;
using System.Collections.Generic;
using System.IO;

namespace mantis_tests
{
    public class Generator
    {
        static void Main(string[] args)
        {
            int count = Convert.ToInt32(args[0]);
            StreamWriter writer = new StreamWriter(args[1]);
            string format = args[2];
            string dataType = args[3];

            List<ProjectData> projects = new List<ProjectData>();

            for (int i = 0; i < count; i++)
            {
                if (dataType == "projects")
                {

                    projects.Add(new ProjectData()
                    {
                        Name = TestBase.GenerateRandomString(20),
                        Description = TestBase.GenerateRandomString(100)
                    });
                }
                else
                {
                    System.Console.Out.Write("Unrecognized data type: \"" + dataType + "\"");
                }
            }
            if (format == "csv")
            {
                WriteProjectsToCsvFile(projects, writer);
            }
            else
            {
                System.Console.Out.Write("Unrecognized format: \"" + format);
            }
            writer.Close();
        }

        static void WriteProjectsToCsvFile(List<ProjectData> projects, StreamWriter writer)
        {
            foreach (ProjectData project in projects)
            {
                writer.WriteLine(String.Format("${0},${1}",
                project.Name, project.Description));
            }
        }
    }
}