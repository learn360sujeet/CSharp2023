
using three_method_class_paramter;


// create object to pass in parameter 
EmployeeDetails employeeDetails = new EmployeeDetails();
employeeDetails._email = "f@gmail.com";
employeeDetails._mobile = 567;
employeeDetails.strname = "sujeet";

// mother class 
EmployeeV2 emp = new EmployeeV2();


// pass class object to method
emp.Display(employeeDetails);