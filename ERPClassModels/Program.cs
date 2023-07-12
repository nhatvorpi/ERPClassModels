using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

#region connection string
string connectionString_Users = "Data Source=192.168.88.8;Initial Catalog=ERPTest1;User ID=erptestAdmin;Password=!@#QWEasd";
SqlConnection connection = new SqlConnection(connectionString_Users);
#endregion

#region methods
static List<int> GetUserInputList()
{
    List<int> inputList = new List<int>();

    Console.Write("Enter the size of the list: ");
    int size = int.Parse(Console.ReadLine());

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Enter element {i + 1}: ");
        int element = int.Parse(Console.ReadLine());
        inputList.Add(element);
    }

    return inputList;
}

static string MaxSOnumber(SqlConnection connection)
{
    /* author: Nhat Vo - 7/11/2023
         * return the current SO number, or null of the database is empty
    */
    connection.Open();
    int SO_number = 0;
    string query = "SELECT MAX(SOnumber) FROM [HW-SODetail]";
    SqlCommand command = new SqlCommand(query, connection);
    string currentSOnumber = command.ExecuteScalar().ToString();
    connection.Close();
    int? result = null;

    if (!string.IsNullOrEmpty(currentSOnumber))
    {
        if(int.TryParse(currentSOnumber, out int parsedNumber))
        {
            result = parsedNumber;
        }
    }

    if (result.HasValue)
    {
        return result.ToString();
    }
    else
    {
        return "null";
    }
}

static int SONumGenerator(SqlConnection connection)
{
    string maxresult = MaxSOnumber(connection);
    if (maxresult == "null")
    {
        return 1;
    }
    else
    {
        int.TryParse(maxresult, out int newSOnum);
        return newSOnum + 1;
    }
}





#region body
void body()
{
    //Menu option:
    Console.WriteLine("Please selection an option: ");
    Console.WriteLine("0. Exit the program");
    Console.WriteLine("1. New SO");
    Console.WriteLine("2. View SO");

    string input = Console.ReadLine();

    int choice;
    if (int.TryParse(input, out choice))
    {
        Console.WriteLine("You entered: " + choice);
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid integer number.");
    }
    switch (choice)
    {
        case 1:
            //Generate new SO_number

            //Create new SO with SO_number

            //Write new SO into HW-SOHeader

            //Prompt user to input FG_code and put it in SO, recursive until user exit

            //Write FG_code into HW-SODetail
            body();
            break;
        case 2:
            //Prompt user to input SO_number

            //Connect to DB

            //Present
            body();
            break;
        case 3:
            Console.WriteLine(SONumGenerator(connection));
            body();
            break;
        case 0:
            Console.WriteLine("Exiting program");
            break;
        default:
            Console.WriteLine("Invalid input");
            break;
    }
}
#endregion

body();