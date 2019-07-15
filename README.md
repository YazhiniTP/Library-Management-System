# Library-Management-System
Library Management System - a Client Server Based Enterprise Application using Visual C# and .NET framework.

# About
The library management system is aimed at helping the library staff in the daily routine jobs. Basic functions handled including search for book by single criteria, advanced search which display search results by various filters and only those books that are available to rent in the library, member registration, transactions of issuing and returning a book, maintenance of the book and member database.

We have included two logins, guest and librarian. Guest can perform search and advanced search only. The librarian being the major user, can perform all functions. The system authenticates the identity of registered librarian by password upon login.

# Assumption
The system is built considering a default borrowing period as 10 days and renew period as 5 days. 

# Software Required
The software required for running the program file is Microsoft Visual Studio .Net, SAP Crystal reports (64-bit) and Microsoft SQL Server Management Studio. For running SAP Crystal reports, .NET framework should be version 4.0 and above.

# Brief Design of screens, entities and reports
Screens:
•	We have tried to maximise the functionality of every screen, keeping in mind that a busy librarian is able to perform the job smoothly throughout the day.

•	The design is interactive, messages are displayed to the user in case a search result is not found (please refer to any screen). Value added features like help provider, tool tips and progress bar to know the progress of the function  are an integral part of the design. 

•	Used masked textboxes for password and phone number field

•	Implemented shortcuts as 
    1. Search - Alt + S
    2. Advanced search - Alt + A
    3. Issue book - Alt + I
    4. Return book - Alt + T
    5. Book maintenance - Alt + B
    6. Member maintenance - Alt + M
    7. Reports - Alt + R

•	We have also incorporated exception handling in our design to make robust. 

•	We have displayed knowledge of typed dataset and entity framework model. 

•	We have implemented two methods (displayBook, displayMem, clearMem) via interface. These methods are used in the screen for book maintenance and member maintenance respectively.

•	The issue date is default to today’s date and the due date is set to 10 days after issue date.

•	If actual date of return is more than the due date, message box indicating fine amount will be displayed. Else, he can return successfully.

•	If the book status is OUT and the due date is not more than the current date, the user will be able to renew the book for another 5 days.

•	The user will not be able to renew or return a book if the book status is IN.

# Entities:  
•	Implement database with primary and foreign keys

•	Implemented check constraint in IssueTrans table for status as IN and OUT and in StockAdjustment table for status as ADD and REMOVE 

•	Implemented delete on cascade to delete records in the author entity where the record with foreign key is deleted in the book entity.
Reports:

•	Cross – tab report for monthly analysis of books rented by the library

•	Demonstrated the use of stored procedures in crystal reports

•	The entities are as per below:
  1.	Employee
  2.	EmployeeMaster
  3.	Book
  4.	Member
  5.	Author
  6.	IssueTran
  7.	StockAdjustment
