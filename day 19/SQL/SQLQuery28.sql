create or alter procedure sp_GetSalary
@empid int,@sal money output
as
begin
select @sal=salary from Customer where cust_id=@empid
end;

exec sp_GetSalary 11

select * from Customer;
alter table Customer
add salary money;

UPDATE Customer
SET salary = 76222
WHERE cust_id=13;