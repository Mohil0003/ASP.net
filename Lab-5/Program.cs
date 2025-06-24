
// program-1
//using Lab_5;

//Arraylist arraylist = new Arraylist();

//while (true)
//{
//    Console.WriteLine("1. Add Student \n 2.Remove Student through Index \n 3.Remove by Range \n 4.CLear all Students \n 5.Display Students \n Anything Else for Terminated");
//    int n = Convert.ToInt32(Console.ReadLine());

//    switch (n)
//    {
//        case 1:
//            Console.WriteLine("Enter Student Name: ");
//            string Name = Console.ReadLine();
//            arraylist.Add(Name);
//            break;

//        case 2:
//            Console.WriteLine("Enter Index for Remove Students : ");
//            int index = Convert.ToInt32(Console.ReadLine());
//            arraylist.Remove(index);
//            break;

//        case 3:
//            Console.WriteLine("Enter Index for Remove Students : ");
//            int Rindex = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter Counts for : ");
//            int counts = Convert.ToInt32(Console.ReadLine());
//            arraylist.RemoveRange(Rindex,counts);
//            break;

//        case 4:
//            arraylist.CLear();
//            break;

//        case 5:
//            arraylist.Display();
//            break;

//        default:
//            break;

//    }
//}







//program - 2

//using Lab_5;

//StudentList studentList = new StudentList();

//while (true)
//{
//    Console.WriteLine("\nMenu:");
//    Console.WriteLine("1. Add Student");
//    Console.WriteLine("2. Remove Student by Index");
//    Console.WriteLine("3. Remove Students by Range");
//    Console.WriteLine("4. Clear All Students");
//    Console.WriteLine("5. Display Students");
//    Console.WriteLine("Any other key to exit");

//    Console.Write("Enter your choice: ");
//    string input = Console.ReadLine();


//    switch (true)
//    {
//        case 1:
//            Console.Write("Enter Student Name: ");
//            string name = Console.ReadLine();
//            studentList.Add(name);
//            break;

//        case 2:
//            Console.Write("Enter Index to Remove Student: ");
//            int index = Convert.ToInt32(Console.ReadLine());
//            studentList.Remove(index);
//            break;

//        case 3:
//            Console.Write("Enter Start Index for Range Remove: ");
//            int start = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Enter Number of Students to Remove: ");
//            int count = Convert.ToInt32(Console.ReadLine());
//            studentList.RemoveRange(start, count);
//            break;

//        case 4:
//            studentList.Clear();
//            break;

//        case 5:
//            studentList.Display();
//            break;

//        default:
//            Console.WriteLine("Exiting program.");
//            break;
//    }
//}





//program-3
//using Lab_Stack;

//IntegerStack stack = new IntegerStack();

//while (true)
//{
//    Console.WriteLine("\n=== Stack Menu ===");
//    Console.WriteLine("1. Push");
//    Console.WriteLine("2. Pop");
//    Console.WriteLine("3. Peek");
//    Console.WriteLine("4. Contains");
//    Console.WriteLine("5. Clear");
//    Console.WriteLine("6. Display");
//    Console.WriteLine("Any other key to exit");

//    Console.Write("Enter your choice: ");
//    string input = Console.ReadLine();
//    if (!int.TryParse(input, out int choice))
//    {
//        Console.WriteLine("Exiting...");
//        break;
//    }

//    switch (choice)
//    {
//        case 1:
//            Console.Write("Enter value to push: ");
//            if (int.TryParse(Console.ReadLine(), out int pushValue))
//            {
//                stack.Push(pushValue);
//            }
//            else
//            {
//                Console.WriteLine("Invalid input. Please enter an integer.");
//            }
//            break;

//        case 2:
//            stack.Pop();
//            break;

//        case 3:
//            stack.Peek();
//            break;

//        case 4:
//            Console.Write("Enter value to check: ");
//            if (int.TryParse(Console.ReadLine(), out int checkValue))
//            {
//                stack.Contains(checkValue);
//            }
//            else
//            {
//                Console.WriteLine("Invalid input. Please enter an integer.");
//            }
//            break;

//        case 5:
//            stack.Clear();
//            break;

//        case 6:
//            stack.Display();
//            break;

//        default:
//            Console.WriteLine("Exiting program.");
//            break;
//    }
//}



using Lab_5;

IntegerQueue queue = new IntegerQueue();

while (true)
{
    Console.WriteLine("\n=== Queue Menu ===");
    Console.WriteLine("1. Enqueue");
    Console.WriteLine("2. Dequeue");
    Console.WriteLine("3. Peek");
    Console.WriteLine("4. Contains");
    Console.WriteLine("5. Clear");
    Console.WriteLine("6. Display");
    Console.WriteLine("Any other key to exit");

    Console.Write("Enter your choice: ");
    string input = Console.ReadLine();
    if (!int.TryParse(input, out int choice))
    {
        Console.WriteLine("Exiting...");
        break;
    }

    switch (choice)
    {
        case 1:
            Console.Write("Enter value to enqueue: ");
            if (int.TryParse(Console.ReadLine(), out int enqueueValue))
            {
                queue.Enqueue(enqueueValue);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
            }
            break;

        case 2:
            queue.Dequeue();
            break;

        case 3:
            queue.Peek();
            break;

        case 4:
            Console.Write("Enter value to check: ");
            if (int.TryParse(Console.ReadLine(), out int checkValue))
            {
                queue.Contains(checkValue);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
            }
            break;

        case 5:
            queue.Clear();
            break;

        case 6:
            queue.Display();
            break;

        default:
            Console.WriteLine("Exiting program.");
            break;
    }
}
