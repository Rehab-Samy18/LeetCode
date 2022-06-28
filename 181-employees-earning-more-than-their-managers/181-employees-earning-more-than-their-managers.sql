/* Write your T-SQL query statement below */
SELECT a.name as Employee
FROM EMPLOYEE a,Employee b
where b.id = a.managerId
and a.salary > b.salary