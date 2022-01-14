--Part 1
/*list the columns and their data types in the Jobs table.
SELECT * FROM tech_jobs.jobs;
Id INT
Name VARCHAR
EmployeeId 



--Part 2
/*write a query to list the names of the employers in St. Louis City
SELECT Name
FROM employers
WHERE Location="St.Louis City"



--Part 3
/*write a query to return a list of the names and descriptions of all skills that are attached to jobs in alphabetical order. 
If a skill does not have a job listed, it should not be included in the results of this query.

SELECT skills, Name, Description
FROM skills
INNER JOIN jobs
ON skills.Id =  jobs.Id
ORDER BY Name ASC;