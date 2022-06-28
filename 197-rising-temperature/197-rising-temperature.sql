/* Write your T-SQL query statement below */
SELECT DISTINCT a.Id
FROM Weather a,Weather b
WHERE a.Temperature > b.Temperature
AND DATEDIFF(day,b.Recorddate, a.Recorddate) = 1