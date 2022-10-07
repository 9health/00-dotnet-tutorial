--
-- HELP
--    From cmd
--    sqlite3 -init sql\delete_foods.sql db\food.sqlite .quit
-- 
-- List all food
DELETE FROM Foods;
DELETE FROM sqlite_sequence WHERE NAME='Foods';
SELECT * FROM sqlite_sequence;

