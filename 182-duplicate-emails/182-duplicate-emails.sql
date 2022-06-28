/* Write your T-SQL query statement below */
select email from (
    select email,count(email) as num
    from person
    group by email  
    
)
as Email
where num > 1

