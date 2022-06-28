CREATE FUNCTION getNthHighestSalary(@N INT) RETURNS INT AS
BEGIN
    RETURN (
        /* Write your T-SQL query statement below. */
        SELECT MAX(SALARY) AS getNthHighestSalary FROM
        (SELECT SALARY,DENSE_RANK() OVER(ORDER BY SALARY DESC) AS RN FROM EMPLOYEE)E WHERE E.RN = @N
    );
END