/* Write your T-SQL query statement below */
SELECT score,DENSE_RANK() OVER (ORDER BY score Desc) as rank from SCORES
