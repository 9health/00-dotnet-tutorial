--
-- HELP
--    From cmd
--    sqlite3 -init sql\delete_food.sql db\food.sqlite .quit
-- 
-- List all food
DELETE FROM foods;
DELETE FROM sqlite_sequence WHERE NAME='foods';

