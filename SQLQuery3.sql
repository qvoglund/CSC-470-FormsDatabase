SELECT * FROM line_items WHERE id = 190;
WITH counts AS (
	SELECT burger * count AS burger_count,
		line_items.combo_num, line_items.size, count FROM line_items RIGHT OUTER JOIN combos ON line_items.combo_num = combos.combo_num 
		WHERE id = 190 GROUP BY burger, line_items.combo_num, line_items.size, line_items.count
)
UPDATE inventory SET quantity = (SELECT quantity FROM inventory WHERE item = 'Burger' AND size = 'LRG') - (SELECT sum(counts.burger_count) FROM counts) WHERE (item = 'BURGER' AND size = 'LRG') OR (item = 'Burger' AND size = 'SML') OR (item = 'Burger' AND size = 'MED');
WITH counts AS (
	SELECT fish * count AS fish_count, 
		line_items.combo_num, line_items.size, count FROM line_items RIGHT OUTER JOIN combos ON line_items.combo_num = combos.combo_num 
		WHERE id = 190 GROUP BY fish, line_items.combo_num, line_items.size, line_items.count
)
UPDATE inventory SET quantity = (SELECT quantity FROM inventory where item = 'Fish' and size = 'LRG') - (SELECT sum(counts.fish_count) FROM counts) WHERE (item = 'Fish' AND size = 'LRG') OR (item = 'Fish' AND size = 'SML') OR (size = 'MED' AND item = 'Fish');
WITH counts AS (
	SELECT french_fry * count AS fry_count, drink * count AS drink_count,  
		 line_items.size FROM line_items RIGHT OUTER JOIN combos ON line_items.combo_num = combos.combo_num 
		WHERE id = 190 GROUP BY french_fry, drink, line_items.combo_num, line_items.size, line_items.count
)
UPDATE inventory SET quantity = (SELECT quantity FROM inventory WHERE item = 'French Fry' AND size = 'LRG') - (SELECT sum(counts.fry_count) FROM counts WHERE size = 'LRG') WHERE size = 'LRG' AND item = 'French Fry';
WITH counts AS (
	SELECT french_fry * count AS fry_count, drink * count AS drink_count,  
		 line_items.size FROM line_items RIGHT OUTER JOIN combos ON line_items.combo_num = combos.combo_num 
		WHERE id = 190 GROUP BY french_fry, drink, burger, fish, line_items.combo_num, line_items.size, line_items.count
)
SELECT * FROM counts