select * from EmployeeMaster

select * from Employees

select * from books

select * from Members

select * from IssueTrans

select * from StockAdjustment

select * from Authors


-- THIS IS THE STANDARD PROCEDURE
-- FOR "CRMonthStats" CRYSTAL REPORT
GO
CREATE PROCEDURE MonthlyStats
AS
BEGIN
select 
b.BookTitle, i.IssueDate
from
IssueTrans i, Books b
where
i.BookID = b.BookID order by BookTitle
END


-- THIS IS THE STANDARD PROCEDURE
-- FOR "CRTransactionHistory" CRYSTAL REPORT
GO
CREATE PROCEDURE TransactionHistory
AS
BEGIN
select 
i.MemberID, i.BookID, b.BookTitle, i.IssueDate, i.DueDate  
from 
IssueTrans i, Books b
where
i.BookID = b.BookID order by IssueDate
END
