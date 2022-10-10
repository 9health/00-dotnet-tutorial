--
-- HELP
--    From cmd
--    sqlite3 -init sql\delete_meals.sql db\food.sqlite .quit
-- 
-- List all meal
DELETE FROM Meals;
DELETE FROM sqlite_sequence WHERE NAME='Meals';
SELECT * FROM sqlite_sequence;

