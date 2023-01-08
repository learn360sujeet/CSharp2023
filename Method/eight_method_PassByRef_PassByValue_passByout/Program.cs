

using eight_method_PassByRef_PassByValue_passByout;

EmployeeV6 employeeV6 = new EmployeeV6  ();


#region Pass by value 

//int n1 = 10;

//int n2 = 4;

//// calling rule - pass the parameter value 
//employeeV6.Display(n1, n2);

//Console.WriteLine("outside Method -" + n1);
//Console.WriteLine("outside Method -" + n2);

#endregion

#region Pass by ref 

//int n1 = 10;

//int n2 = 4;

//// pass by ref calling rule - pass the parameter value with ref keyword 
//employeeV6.DisplayPassByref(ref n1, ref n2);//caller

//Console.WriteLine("outside Method -" + n1);// output 50
//Console.WriteLine("outside Method -" + n2); // output 100 

#endregion


int n1 ;

// pass by out - 
employeeV6.DisplayPassByout(out n1);

Console.WriteLine("outside Method -" + n1);// output 500
