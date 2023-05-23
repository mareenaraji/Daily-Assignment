declare 
@in1 int ,@in2 int;
declare @s char;
begin
set @in1=10;
set @in2=13;
set @s=@in1+@in2;
print @s
end;