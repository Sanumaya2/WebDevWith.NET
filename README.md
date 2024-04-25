# WebDevWith.NET

# Web Development with .net
1. www - Early 1990's
2. ASP-MS , JSP-SUN - (USE VV)
3. .NET Framework- Early 2000's - windows only, last version 4.8
4. ASP.NET (Web Forms)
5. MVC -2007
6. ASP.NET MVC - 2008


7. 2015/16 - .NET Core(cross platform, open source)
8. ASP.NET Core
9. 2020 - .NET 5, 2021 - .NET 6, 2022 - .NET 7, 2023 - .NET 8, 2024 - .NET 9


## SDLC 
## Environments(physical server and app urls)
 CollegeMonitor - https://collegemonitor.com
1. Developer  - local:Dev Environment(Localhost)
2. QA -  code changes deployed, Tst environment(https://tst.collegemonitor.com)
3. INT -All code changes, Integration Environment(https://int.collegemonitor.com)
4. UAT - PO/TPO/BA , User Acceptance Testing(https://uat.collegemonitor.com)
5. PROD - Production Environment(https://collegemonitor.com)

# collegemonitor requirement
## Entities/Tables/MOdels
1. Class - Id , Title , Start , Duration , Details
1. Course - Id , Name, Textbook, Credithrs
1. Student - Id , Name , Address, Email, Program, Semester

Course has multiple classes(one to many)
Student may enroll on multiple courses and a course can be studied by multiple students(many to many)
