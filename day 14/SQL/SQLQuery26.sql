

create or alter procedure SHOWProduct_Master(@productno nvarchar(30))
as
begin
select * from Product_Master where ProductNo=@productno
end;

exec SHOWProduct_Master P00001

select * from EMPLOYEES;
insert into EMPLOYEES values(1,'maya','raj','maya@gmail.com',12345678,'2022-03-02',5363,450000,7255,723,121);