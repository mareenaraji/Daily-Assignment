-- Local variables
DECLARE @Emp_num INT;
-- Define the cursor
DECLARE emp_cursor CURSOR
FOR
SELECT empid FROM Emp ORDER BY empid;
-- Open cursor (retrieve data)
OPEN emp_cursor;
-- Perform the first fetch (get first row)
FETCH NEXT FROM emp_cursor INTO @Emp_num;
-- Close cursor
CLOSE emp_cursor
-- And finally, remove it
DEALLOCATE emp_cursor;


exec @Emp_num 