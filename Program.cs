using System.ComponentModel;

namespace Student_Info_Management
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            List<string> name = new List<string>();
            List<string> course = new List<string>();
            List<string> year = new List<string>();
            List<string> contactNo = new List<string>();
            List<string> email = new List<string>();
            List<string> address = new List<string>();
            List<string> dateOfBirth = new List<string>();

            int choice;

            do 
            {
                Console.WriteLine("--- Student Information Management ---");
                Console.WriteLine("1. View All Students");
                Console.WriteLine("2. Add a Student");
                Console.WriteLine("3. Update a Student");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Exit");
                Console.Write("Enter Choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        if (name.Count == 0)
                        {
                            Console.WriteLine("No records found.");
                        } 
                        else
                        {
                            for (int i = 0; i < name.Count; i++)
                            {
                                Console.WriteLine("\n--- Student {0} ---", i + 1);
                                Console.WriteLine("Name: " + name[i]);
                                Console.WriteLine("Course: " + course[i]);
                                Console.WriteLine("Year: " + year[i]);
                                Console.WriteLine("Contact No.: " + contactNo[i]);
                                Console.WriteLine("Email: " + email[i]);
                                Console.WriteLine("Address: " + address[i]);
                                Console.WriteLine("Date of Birth: " + dateOfBirth[i]);
                            }
                        }
                        break;

                    case 2:
                        Console.Write("Name: ");
                        name.Add(Console.ReadLine());

                        Console.Write("Course: ");
                        course.Add(Console.ReadLine());

                        Console.Write("Year: ");
                        year.Add(Console.ReadLine());

                        Console.Write("Contact No.: ");
                        contactNo.Add(Console.ReadLine());

                        Console.Write("Email: ");
                        email.Add(Console.ReadLine());

                        Console.Write("Address: ");
                        address.Add(Console.ReadLine());

                        Console.Write("Date of Birth: ");
                        dateOfBirth.Add(Console.ReadLine());

                        Console.WriteLine("Student added successfully!");
                        break;
                }


            }

        }
    }
}
