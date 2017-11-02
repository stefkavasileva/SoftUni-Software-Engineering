# <p align="center">   Joins, Subqueries, CTE and Indices </p>

This document defines the **exercise assignments** for the [&quot;Databases Basics - MSSQL&quot; course @ Software University.](https://softuni.bg/courses/databases-basics-ms-sql-server) For problems from 1 to 11 (inclusively) use &quot; **SoftUni**&quot; database and for the other problems – &quot; **Geography**&quot;.

## Problem 1.Employee Address

Write a query that selects:

- **EmployeeId**
- **JobTitle**
- **AddressId**
- **AddressText**

Return the **first 5** rows **sorted** by **AddressId** in **ascending** order.

### Example:

| **EmployeeId** | **JobTitle** | **AddressId** | **AddressText** |
| --- | --- | --- | --- |
| 142 | Production Technician | 1 | 108 Lakeside Court |
| 30 | Human Resources Manager | 2 | 1341 Prospect St |
| … | … | … | … |

## Problem 2.Addresses with Towns

Write a query that selects:

- **FirstName**
- **LastName**
- **Town**
- **AddressText**

**Sorted** by **FirstName** in **ascending** order then by **LastName**. Select **first 50** employees.

### Example:

| **FirstName** | **LastName** | **Town** | **AddressText** |
| --- | --- | --- | --- |
| A.Scott | Wright | Newport Hills | 1400Gate Drive |
| Alan | Brewer | Kenmore | 8192 Seagull Court |
| … | … | … | … |

## Problem 3.Sales Employee

Write a query that selects:

- **EmployeeID**
- **FirstName**
- **LastName**
- **DepartmentName**

**Sorted** by **EmployeeID** in **ascending** order. Select only **employees** from &quot; **Sales**&quot; department.

### Example:

| **EmployeeID** | **FirstName** | **LastName** | **DepartmentName** |
| --- | --- | --- | --- |
| 268 | Stephen | Jiang | Sales |
| 273 | Brian | Welcker | Sales |
| … | … | … | … |

## Problem 4.Employee Departments

Write a query that selects:

- **EmployeeID**
- **FirstName**
- **Salary**
- **DepartmentName**

Filter only **employees** with **salary higher than 15000**. Return the **first 5** rows **sorted** by **DepartmentID** in **ascending** order.

### Example:

| **EmployeeID** | **FirstName** | **Salary** | **DepartmentName** |
| --- | --- | --- | --- |
| 3     | Roberto                                             | 43300.00 | Engineering |
| 9 | Gail | 32700.00 | Engineering |
| … | … | … | … |

## Problem 5.Employees Without Project

Write a query that selects:

- **EmployeeID**
- **FirstName**

Filter only **employees**** without **a** project **. Return the** first 3 **rows** sorted **by** EmployeeID **in** ascending** order.

### Example:

| **EmployeeID** | **FirstName** |
| --- | --- |
| 2 | Kevin |
| 6 | David |
| … | … |

## Problem 6.Employees Hired After

Write a query that selects:

- **FirstName**
- **LastName**
- **HireDate**
- **DeptName**

Filter only **employees**** hired after 1.1.1999 **and are from either**&quot;Sales&quot; **or**&quot;Finance&quot; **departments, s** orted **by** HireDate**(**ascending**).

### Example:

| **FirstName** | **LastName** | **HireDate** | **DeptName** |
| --- | --- | --- | --- |
| Debora     | Poe | 2001-01-19 00:00:00 | Finance |
| Wendy | Kahn | 2001-01-26 00:00:00 | Finance |
| … | … | … | … |

## Problem 7.Employees with Project

Write a query that selects:

- **EmployeeID**
- **FirstName**
- **ProjectName**

Filter only **employees**** with **a** project **which has** started after 13.08.2002 **and it is still** ongoing**(no end date). Return the**first 5 **rows** sorted **by** EmployeeID **in** ascending** order.

### Example

| **EmployeeID** | **FirstName** | **ProjectName** |
| --- | --- | --- |
| 1 | Guy | Racing Socks |
| 1 | Guy | Road Bottle Cage |
| … | … | … |

## Problem 8.Employee 24

Write a query that selects:

- **EmployeeID**
- **FirstName**
- **ProjectName**

Filter all the **projects** of **employee** with **Id 24**. If the project has **started during or**** after ****2005** the **returned** value should be **NULL**.

### Example

| **EmployeeID** | **FirstName** | **ProjectName** |
| --- | --- | --- |
| 24 | David | NULL |
| 24 | David | Road-650 |
| … | … | … |

## Problem 9.Employee Manager

Write a query that selects:

- **EmployeeID**
- **FirstName**
- **ManagerID**
- **ManagerName**

Filter all **employees** with a **manager** who has **ID** equals to **3 or 7**. Return all the rows, **sorted** by **EmployeeID** in **ascending** order.

### Example

| **EmployeeID** | **FirstName** | **ManagerID** | **ManagerName** |
| --- | --- | --- | --- |
| 4 | Rob | 3 | Roberto |
| 9 | Gail | 3 | Roberto |
| … | … | … | … |

## Problem 10.Employee Summary

Write a query that selects:

- **EmployeeID**
- **EmployeeName**
- **ManagerName**
- **DepartmentName**

Show **first 50 employees** with their **managers** and the **departments** they are in (show the departments of the employees). **Order** by **EmployeeID**.

### Example

| **EmployeeID** | **EmployeeName** | **ManagerName** | **DepartmentName** |
| --- | --- | --- | --- |
| 1 | Guy Gilbert | Jo Brown | Production |
| 2 | Kevin Brown | David Bradley | Marketing |
| 3 | Roberto Tamburello | Terri Duffy | Engineering |
| … | … | … | … |

## Problem 11.Min Average Salary

Write a query that **returns** the value of the **lowest**** average ****salary** of all **departments**.

### Example:

| **MinAverageSalary** |
| --- |
| 10866.6666 |

## Problem 12.Highest Peaks in Bulgaria

Write a query that selects:

- **CountryCode**
- **MountainRange**
- **PeakName**
- **Elevation**

Filter all **peaks** in **Bulgaria** with **elevation**** over ****2835**. **Return** all the rows **sorted** by **elevation** in **descending** order.

### Example

| **CountryCode** | **MountainRange** | **PeakName** | **Elevation** |
| --- | --- | --- | --- |
| BG | Rila | Musala | 2925 |
| BG | Pirin | Vihren | 2914 |
| … | … | … | … |

## Problem 13.Count Mountain Ranges

Write a query that selects:

- **CountryCode**
- **MountainRanges**

Filter the **count** of the **mountain**** ranges **in the** United ****States** , **Russia** and **Bulgaria**.

### Example

| **CountryCode** | **MountainRanges** |
| --- | --- |
| BG | 6 |
| RU | 1 |
| … | … |

## Problem 14.Countries with Rivers

Write a query that selects:

- **CountryName**
- **RiverName**

Find the **first**** 5 ****countries** with or without **rivers** in **Africa**. **Sort** them by **CountryName** in **ascending** order.

### Example

| **CountryName** | **RiverName** |
| --- | --- |
| Algeria | Niger |
| Angola | Congo |
| Benin | Niger |
| Botswana | NULL |
| Burkina Faso | Niger |

## Problem 15.\*Continents and Currencies

Write a query that selects:

- **ContinentCode**
- **CurrencyCode**
- **CurrencyUsage**

Find all **continents** and their **most**** used ****currency**. Filter any **currency** that is used in **only**** one ****country**. **Sort** your results by **ContinentCode**.

### Example

| **ContinentCode** | **CurrencyCode** | **CurrencyUsage** |
| --- | --- | --- |
| AF | XOF | 8 |
| AS | AUD | 2 |
| AS | ILS | 2 |
| EU | EUR | 26 |
| NA | XCD | 8 |
| OC | USD | 8 |

## Problem 16.Countries without any Mountains

Write a query that selects **CountryCode.** Find all the **count** of all **countries,** which **don&#39;t**** have **a** mountain**.

### Example

| **CountryCode** |
| --- |
| 231 |

## Problem 17.Highest Peak and Longest River by Country

For each country, find the elevation of **the highest peak** and **the length of the longest river** , **sorted** by the **highest peak elevation** (from highest to lowest), then by the **longest river length** (from longest to smallest), then by **country name** (alphabetically). Display **NULL** when no data is available in some of the columns. Limit only the **first 5** rows.

| **CountryName** | **HighestPeakElevation** | **LongestRiverLength** |
| --- | --- | --- |
| China | 8848 | 6300 |
| India | 8848 | 3180 |
| Nepal | 8848 | 2948 |
| Pakistan | 8611 | 3180 |
| Argentina | 6962 | 4880 |

## Problem 18.\* Highest Peak Name and Elevation by Country

For each country, find the **name** and **elevation** of **the highest peak** , along with its **mountain**. When no peaks are available in some country, display elevation **0** , &quot;**(no highest peak)**&quot; as **peak name** and &quot;**(no mountain)**&quot; as **mountain name**. When **multiple peaks** in some country have the **same elevation** , display **all of them**. **Sort** the results by **country name alphabetically** , then by **highest peak name alphabetically**. Limit only the **first 5** rows.

| **Country** | **Highest Peak Name** | **Highest Peak Elevation** | **Mountain** |
| --- | --- | --- | --- |
| Afghanistan | (no highest peak) | 0 | (no mountain) |
| … | … | … | … |
| Argentina | Aconcagua | 6962 | Andes |
| … | … | … | … |
| Bulgaria | Musala | 2925 | Rila |
| Burkina Faso | (no highest peak) | 0 | (no mountain) |
| … | … | … | … |
| United States | Mount McKinley | 6194 | Alaska Range |