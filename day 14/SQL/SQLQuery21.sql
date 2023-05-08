Select a.AccountNo as ACNO,
a.Name as [Account Holder Name],
a.Balance,
a.refAc as [Ref AcNo],
r.Name[Name of Referer]
from BankTB a join BankTB r
on a.RefAc=r.AccountNo;

/* self join*/