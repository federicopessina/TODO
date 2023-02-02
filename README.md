# TODO

The //TODO App is Bugtracker WebApp ASP.NET MVC WebApp written in C#.
With a very minimalistic style, it gives the basic functionalities of a bugtracker that can be used in a real world working environment.

## Main

The Main page does not display information to a malicious user that did not provide identification through login and password.

![Main](https://github.com/federicopessina/TODO/blob/master/Screenshots/TODOBugtracker%20MainPage.jpeg)


## Index

the Index page gives a list of all current bugs registered from the users. 
It gives 3 options for each bug to fix or feature to implement:
1) Edit: giving the opportunity of providing more information about the bug/feature
2) Details: for a read-only view of the characteristics
3) Delete: when the job is done. However, these are not deleted totally from the program and there is a way to recover from a deletion.

## Register

Page to register a new User.

![CreatePage](https://github.com/federicopessina/TODO/blob/master/Screenshots/TODOBugtracker%20CreatePage.jpeg)
![LoginPage](https://github.com/federicopessina/TODO/blob/master/Screenshots/TODOBugtracker%20LoginPage.jpeg)
![RegisterConfirmationPage](https://github.com/federicopessina/TODO/blob/master/Screenshots/TODOBugtracker%20RegisterConfirmationPage.jpeg)
![20RegisterNewAccountPage](https://github.com/federicopessina/TODO/blob/master/Screenshots/TODOBugtracker%20RegisterNewAccountPage.jpeg)

## Edit

![Edit](https://github.com/federicopessina/TODO/blob/master/Screenshots/TODOBugtracker%20EditPage.jpeg)

## Details

![Details](https://github.com/federicopessina/TODO/blob/master/Screenshots/TODOBugrtracker%20DetailsPage.jpeg)

## Search

![Search](https://github.com/federicopessina/TODO/blob/master/Screenshots/TODOBugtracker%20SearchPage.jpeg)


# Technologies

ASP.NET Core | MVC | Entity Framework Object Relational Mapper (ORM) to generate the DB

In Package MAnager Console input the following commands:
	update-database
	Check in SQL Server Object Explorer if the DB is created
	

