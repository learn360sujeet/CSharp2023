-- CRUD operation 
  ---- create , Read, update , delete
   
----------------Create-------------------------------------------------------------------------------------

  --insert into tblVillage (id, [villageName],[PostToffice] ,[PoliceStation],[District],[State] ,[Country])
  --values (2, 'pinda','pinda','chatra','chatra','jarghand','india')

-----------------Read---------------------------------------------------------------------------------------

Select * from tblVillage 

Select villageName , District from tblVillage 

select * from  tblVillage  where  District ='gaya' -- read/fetch data conditionally


----------------update---------------------------------------------------------------------------------------
update tblVillage
set District='gaya to patna'
where District ='gaya' -- where Must 


-----------------Delete--------------------------------------------------------------------------------------
delete from tblVillage 
where id=2 -- where Must 
