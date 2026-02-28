using System.ComponentModel;

namespace Student_Info_Management
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            List<string> fullName = new List<string>();
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
                        if (fullName.Count == 0)
                        {
                            Console.WriteLine("--------------------------------------");
                            Console.WriteLine("No records found. Please make a new record.");
                        } 
                        else
                        {
                            for (int i = 0; i < fullName.Count; i++)
                            {
                                Console.WriteLine("--------------------------------------");
                                Console.WriteLine("Student {0}:", i + 1);
                                Console.WriteLine("Full Name: " + fullName[i]);
                                Console.WriteLine("Course: " + course[i]);
                                Console.WriteLine("Year: " + year[i]);
                                Console.WriteLine("Contact No.: " + contactNo[i]);
                                Console.WriteLine("Email: " + email[i]);
                                Console.WriteLine("Full Address: " + address[i]);
                                Console.WriteLine("Date of Birth: " + dateOfBirth[i]);
                            }
                        }
                        break;

                    case 2:
                        Console.WriteLine("--------------------------------------");
                        Console.Write("Full Name (Surname, First Name M.I.): ");
                        fullName.Add(Console.ReadLine());

                        Console.Write("Course (e.g. BSIT): ");
                        course.Add(Console.ReadLine());

                        Console.Write("Year (e.g. 1): ");
                        year.Add(Console.ReadLine());

                        Console.Write("Contact No.: ");
                        contactNo.Add(Console.ReadLine());

                        Console.Write("Email: ");
                        email.Add(Console.ReadLine());

                        Console.Write("Full Address: ");
                        address.Add(Console.ReadLine());

                        Console.Write("Date of Birth: ");
                        dateOfBirth.Add(Console.ReadLine());

                        Console.WriteLine("\nStudent added successfully!");
                        break;

                    case 3:
                        Console.WriteLine("--------------------------------------");
                        Console.Write("Enter student number to update: ");
                        int updateIndex = Convert.ToInt32(Console.ReadLine()) - 1;

                        if (updateIndex >= 0 && updateIndex < fullName.Count)
                        {
                            Console.Write("Full Name (Surname, First Name M.I.): ");
                            fullName[updateIndex] = Console.ReadLine();

                            Console.Write("Course (e.g. BSIT): ");
                            course[updateIndex] = Console.ReadLine();

                            Console.Write("Year (e.g. 1): ");
                            year[updateIndex] = Console.ReadLine();

                            Console.Write("Contact No.: ");
                            contactNo[updateIndex] = Console.ReadLine();

                            Console.Write("Email: ");
                            email[updateIndex] = Console.ReadLine();

                            Console.Write("Full Address: ");
                            address[updateIndex] = Console.ReadLine();

                            Console.Write("Date of Birth: ");
                            dateOfBirth[updateIndex] = Console.ReadLine();

                            Console.WriteLine("\nStudent updated successfully!");
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid student number.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("--------------------------------------");
                        Console.Write("Enter student number to delete: ");
                        int deleteIndex = Convert.ToInt32(Console.ReadLine()) - 1;

                        if (deleteIndex >= 0 && deleteIndex < fullName.Count)
                        {
                            fullName.RemoveAt(deleteIndex);
                            course.RemoveAt(deleteIndex);
                            year.RemoveAt(deleteIndex);
                            contactNo.RemoveAt(deleteIndex);
                            email.RemoveAt(deleteIndex);
                            address.RemoveAt(deleteIndex);
                            dateOfBirth.RemoveAt(deleteIndex);

                            Console.WriteLine("\nStudent deleted successfully!");
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid student number.");
                        }
                        break;

                    case 5:
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine("Exiting the program...");
                        break;

                    default:
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (choice != 5);

        }
    }
}
