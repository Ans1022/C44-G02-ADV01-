namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Generics - SWAP Example
            //Generics :
            //C# Feature 

            // Swep 

            //int A = 4 , B = 5;

            //Console.WriteLine($" A : {A}"); 
            //Console.WriteLine($" B : {B}");

            //Console.WriteLine("********After*******");

            //Helper.Swep(ref A , ref B); // Passing By ref
            //Console.WriteLine($" A : {A}");
            //Console.WriteLine($" B : {B}");

            //double L = 4.5, M = 5.5;
            //Console.WriteLine($" L : {L}");
            //Console.WriteLine($" M : {M}");

            //Console.WriteLine("*********After Swep*****");

            //Helper.Swep(ref L, ref M);
            //Console.WriteLine($" L : {L}");
            //Console.WriteLine($" M : {M}");


            //Point p01 = new Point(1, 1);
            //Point p02 = new Point(2, 2);

            //Console.WriteLine($"P01 : {p01}");
            //Console.WriteLine($"P02 : {p02}");

            //Console.WriteLine("*********After Swep*****");

            //Helper.Swep(ref p01, ref p02);

            //Console.WriteLine($"P01 : {p01}");
            //Console.WriteLine($"P02 : {p02}");






            #endregion

            #region Linear Search Example
            //int[] Number = { 13, 6, 5, 3, 2, 1, 7, -1, 9, 10, 11 };
            //int Index = Helper.LinerSearach(Number, 7);
            //Console.WriteLine($"index : {Index}");

            //Employee Emp01 = new Employee() { Id = 1, Name = "Anas", Salary = 12000, Age = 22 };
            //Employee Emp02 = new Employee() { Id = 2, Name = "Makram", Salary = 13000, Age = 25 };
            //Employee Emp03 = new Employee() { Id = 3, Name = "Maher", Salary = 14000, Age = 28 };
            //Employee Emp04 = new Employee() { Id = 4, Name = "Mohsen", Salary = 15000, Age = 29 };

            //Employee[] employees = { Emp01, Emp02, Emp03, Emp04 };
            //int index = Helper.LinerSearach(employees, Emp02); 
            //Console.WriteLine($"Index : {index}");

            #endregion

            #region Equality (Class and Struct)
            // Equality in Class or Struct
            // Equals
            // 'Class' : HAs Equals Function Which Inherited From Object Class ----> Compare Reference
            // 'Struct': HAs Equals Function Which Inherited From Object Class ----> Compare Data 
            //NOTE : Sturct Don't Have Implmention for The ==> Operator


            //Employee Emp01 = new Employee() { Id = 1, Name = "Anas", Salary = 12000, Age = 22 };
            //Employee Emp02 = new Employee() { Id = 1, Name = "Anas", Salary = 12000, Age = 22 };
            //Employee Emp02 = new Employee() { Id = 2, Name = "Makram", Salary = 13000, Age = 25 };

            //Console.WriteLine($"Emp01 : {Emp01.GetHashCode()}");

            //if (Emp01.Equals(Emp02))
            //    Console.WriteLine($"E01 == E02!");
            //else
            //    Console.WriteLine($"E01 != E02!");
            #endregion

            #region Generics - BubbleSort Exmaple
            //int[] Numper = { 10, 22, 44, 3, 6, 77, 98, 12, 2, 1 };
            //Helper.PrintArray(Numper);
            //Console.WriteLine();

            //Helper.BubleSort(Numper);

            //Helper.PrintArray(Numper);

            //Point[] points =
            //    {
            //    new Point(9,9),
            //    new Point(37,37),
            //    new Point(10,10),
            //    new Point(5,5),
            //    new Point(7,7),
            //    new Point(8,8)
            //};
            //Helper.BubleSort(points);
            //Helper.PrintArray(points);

            #endregion

            #region is And as Operators

            //Point[] points =
            //    {
            //    new Point(9,9),
            //    new Point(37,37),
            //    new Point(10,10),
            //    new Point(5,5),
            //    new Point(7,7),
            //    new Point(8,8)
            //};

            //Helper.BubleSort(points);
            //Helper.PrintArray(points);


            //Point P01 = new Point(2,2);
            //Point P02 = new Point(3,3);

            //if (P01.CompareTo("Ahmed") > 0)
            //    Console.WriteLine("P01 Is greater Then P02");
            //else Console.WriteLine("P01 Is not greater Then P02");
            #endregion

            #region IComparable Vs Generic IComparable
            //Point[] points =
            //    {
            //    new Point(9,9),
            //    new Point(37,37),
            //    new Point(10,10),
            //    new Point(5,5),
            //    new Point(7,7),
            //    new Point(8,8)
            //};

            //Helper.BubleSort(points);
            //Helper.PrintArray(points);


            //Employee Emp01 = new Employee() { Id = 1, Name = "Anas", Salary = 12000, Age = 22 };
            //Employee Emp02 = new Employee() { Id = 1, Name = "Anas", Salary = 12000, Age = 22 };
            //Employee Emp03 = new Employee() { Id = 2, Name = "Makram", Salary = 13000, Age = 25 };

            //Console.WriteLine($"Emp01 : {Emp01.GetHashCode()}");

            //if (Emp01.Equals(Emp02))
            //    Console.WriteLine($"E01 == E02!");
            //else
            //    Console.WriteLine($"E01 != E02!");
            #endregion

            #region Built-in Interface Generic IEquatable
            //Employee Emp01 = new Employee() { Id = 1, Name = "Anas", Salary = 12000, Age = 22 };
            //Employee Emp02 = new Employee() { Id = 1, Name = "Anas", Salary = 12000, Age = 22 };
            //Employee Emp03 = new Employee() { Id = 2, Name = "Makram", Salary = 13000, Age = 25 };


            //if (Emp01.Equals(Emp02))
            //    Console.WriteLine($"E01 == E02!");
            //else
            //    Console.WriteLine($"E01 != E02!");

            //if (Emp01.Equals("Ahmed"))
            //    Console.WriteLine($"E01 == E02");
            //else
            //    Console.WriteLine($"E01 != E02");
            #endregion

            #region Built-in Interface Generic IEqualityComparer

            //Employee Emp01 = new Employee() { Id = 1, Name = "Anas", Salary = 11000, Age = 20 };
            //Employee Emp02 = new Employee() { Id = 2, Name = "Mohamed", Salary = 12000, Age = 22 };
            //Employee Emp03 = new Employee() { Id = 3, Name = "Makram", Salary = 19000, Age = 24 };
            //Employee Emp04 = new Employee() { Id = 4, Name = "mostafa", Salary = 73000, Age = 29 };

            //Employee[] employees = { Emp01, Emp02, Emp03 , Emp04 };
            //int indaex = Helper.LinerSearach(employees, new Employee() { Id = 1, Name = "Anas", Salary = 11000, Age = 20 });
            // Console.WriteLine(indaex);
            #endregion

            #region IComparer With Bubble Sort

            #endregion

            #region Generic Constraints
            //1.Primary Constraints
             //1.1 : Class
             //1.2 : Struct 
             //1.3 : Spacial type point 
             //1.4 : Enum 
             //1.5 : not null



            //2.secondery Constraints
            // T implemnt interface

            //3.Constactor Constraints
            #endregion
        }
    }
}
