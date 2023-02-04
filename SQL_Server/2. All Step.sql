
/*


 1. Database 
 --- --create database TCS

 2. Table - Coloumn 
   create table Employee
	( id int ,
	  fn nvarchar(20),
	  ln nvarchar(20),
	  mobile int 
	)

 ============================================

 3. Operation on table = CRUD
 
 -- Create 
 ---------insert into dbo.Employee (id, fn , ln , mobile)   values (101, 'sujeet' , 'kumar' , 123456789)

 -- Read 
-----select * from employee  -- * real all record 
-----Select * from employee where ln ='kumar' -- Read conditionally 
-----Select id, fn from employee where ln ='kumar' -- Read conditionally 

--update 
	UPDATE employee
	SET mobile = 9999
	where id=102

-- Delete 
	delete from  employee
	where id =1345687

**/

use TCS;






