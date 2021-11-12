CREATE TRIGGER UpdateIngredient_DELETE
AFTER DELETE ON Ingredient_Detailed
    BEGIN
        UPDATE Ingredient
            SET 
                TOTAL_UNITS_AVAILABLE = (
                    SELECT
			TOTAL(A.UNITS_AVAILABLE)
                    FROM Ingredient_Detailed AS A
		    WHERE A.INGREDIENT_CODE = old.INGREDIENT_CODE
                ),
		AVERAGE_PRICE = (
			SELECT 
			    coalesce(avg(A.UNIT_PRICE), 0)
                    	FROM Ingredient_Detailed AS A
			WHERE A.INGREDIENT_CODE = old.INGREDIENT_CODE
		),
		AVERAGE_MINIMUM_PRICE= (
			SELECT 
			    coalesce(avg(A.MINIMUM_PRICE_PER_UNIT), 0)
                    	FROM Ingredient_Detailed AS A
			WHERE A.INGREDIENT_CODE = old.INGREDIENT_CODE
		)
		WHERE CODE = old.INGREDIENT_CODE;
    END;

CREATE TRIGGER UpdateIngredient_INSERT
AFTER INSERT ON Ingredient_Detailed
    BEGIN
        UPDATE Ingredient
            SET 
                TOTAL_UNITS_AVAILABLE = (
                    SELECT
                        TOTAL(A.UNITS_AVAILABLE)
                    FROM Ingredient_Detailed AS A
		    WHERE A.INGREDIENT_CODE = new.INGREDIENT_CODE
                ),
		AVERAGE_PRICE = (
			SELECT 
				coalesce(avg(A.UNIT_PRICE), 0)
                    	FROM Ingredient_Detailed AS A
			WHERE A.INGREDIENT_CODE = new.INGREDIENT_CODE
		),
		AVERAGE_MINIMUM_PRICE= (
			SELECT 
			    coalesce(avg(A.MINIMUM_PRICE_PER_UNIT), 0)
                    	FROM Ingredient_Detailed AS A
			WHERE A.INGREDIENT_CODE = new.INGREDIENT_CODE
		) 

		WHERE CODE = new.INGREDIENT_CODE;
    END;

CREATE TRIGGER UpdateIngredient_UPDATE
AFTER UPDATE ON Ingredient_Detailed
    BEGIN
        UPDATE Ingredient
            SET 
                TOTAL_UNITS_AVAILABLE = (
                    SELECT
                        TOTAL(A.UNITS_AVAILABLE)
                    FROM Ingredient_Detailed AS A
		    WHERE A.INGREDIENT_CODE = new.INGREDIENT_CODE
                ),
		AVERAGE_PRICE = (
		    SELECT 
		        coalesce(avg(A.UNIT_PRICE), 0)
                    FROM Ingredient_Detailed AS A
		    WHERE A.INGREDIENT_CODE = new.INGREDIENT_CODE
		),
		AVERAGE_MINIMUM_PRICE= (
			SELECT 
			    coalesce(avg(A.MINIMUM_PRICE_PER_UNIT), 0)
                    	FROM Ingredient_Detailed AS A
			WHERE A.INGREDIENT_CODE = new.INGREDIENT_CODE
		) 
		WHERE CODE = new.INGREDIENT_CODE;
    END;

CREATE TRIGGER UpdateUnitName_UPDATE
AFTER UPDATE ON Measurement_Unit
    BEGIN
        UPDATE Ingredient
            SET 
                UNIT_OF_MEASURE = (
                    SELECT
						NAME
                    FROM Measurement_UNIT
                ) WHERE UNIT_OF_MEASURE = old.name;
    END;

CREATE TRIGGER UpdateRecipe_DELETE
AFTER DELETE ON Recipe_Step
    BEGIN
        UPDATE Recipe
            SET 
                TOTAL_PRICE = (
                    SELECT
			TOTAL(A.PRICE_FOR_AMOUNT_USED)
                    FROM Recipe_Step AS A
		    WHERE A.RECIPE_CODE = old.RECIPE_CODE
                )
		WHERE CODE = old.RECIPE_CODE;
    END;

CREATE TRIGGER UpdateRecipe_INSERT
AFTER INSERT ON Recipe_Step
    BEGIN
        UPDATE Recipe
            SET 
                TOTAL_PRICE = (
                    SELECT
                        TOTAL(A.PRICE_FOR_AMOUNT_USED)
                    FROM Recipe_Step AS A
		    WHERE A.RECIPE_CODE = new.RECIPE_CODE
                )

		WHERE CODE = new.RECIPE_CODE;
    END;

CREATE TRIGGER UpdateRecipe_UPDATE
AFTER UPDATE ON Recipe_Step
    BEGIN
        UPDATE Recipe
            SET 
                TOTAL_PRICE = (
                    SELECT
                        TOTAL(A.PRICE_FOR_AMOUNT_USED)
                    FROM Recipe_Step AS A
		    WHERE A.RECIPE_CODE = new.RECIPE_CODE
                )		
		WHERE CODE = new.RECIPE_CODE;
    END;
	
CREATE TRIGGER UpdateCategoryName_UPDATE
AFTER UPDATE ON Product_Category
    BEGIN
        UPDATE Recipe
            SET 
                CATEGORY_NAME = (
                    SELECT
						NAME
                    FROM Product_Category
                ) WHERE CATEGORY_NAME = old.name;
    END;

CREATE TRIGGER UpdateOrderAmounts_DELETE
AFTER DELETE ON ORDER_ITEM
    BEGIN
        UPDATE ORDER_BASE
            SET 
                ITEMS_TOTAL_PRICE = (
                    SELECT TOTAL(A.TOTAL_ITEM_PRICE)
                    FROM ORDER_ITEM AS A
		    WHERE A.ORDER_CODE = OLD.ORDER_CODE
            ),
		ITEMS_IN_ORDER = (
			SELECT 
			    coalesce(COUNT(*), 0)
                    	FROM ORDER_ITEM AS A
			WHERE A.ORDER_CODE = OLD.ORDER_CODE
		),
		TAX_TOTAL= (
			SELECT 
			    COALESCE((B.TAX_PERCENTAGE * (B.PREPARATION_COST + TOTAL(A.TOTAL_ITEM_PRICE)) / 100),0)
            FROM ORDER_ITEM AS A
            INNER JOIN ORDER_BASE B ON A.ORDER_CODE = B.CODE
			WHERE A.ORDER_CODE = OLD.ORDER_CODE
		)
		WHERE CODE = OLD.ORDER_CODE;
    END;

CREATE TRIGGER UpdateOrderAmounts_INSERT
AFTER INSERT ON ORDER_ITEM
    BEGIN
        UPDATE ORDER_BASE
            SET 
                ITEMS_TOTAL_PRICE = (
                    SELECT coalesce(total_price, 0) from( select
			a.order_code, TOTAL(A.TOTAL_ITEM_PRICE) as total_price
                    FROM ORDER_ITEM AS A
		    WHERE A.ORDER_CODE = NEW.ORDER_CODE
            group by a.order_code
                ) subquery),
		ITEMS_IN_ORDER = (
			SELECT 
			    coalesce(COUNT(*), 0)
                    	FROM ORDER_ITEM AS A
			WHERE A.ORDER_CODE = NEW.ORDER_CODE
		),
		TAX_TOTAL= (
			SELECT 
			    COALESCE((B.TAX_PERCENTAGE * (B.PREPARATION_COST + TOTAL(A.TOTAL_ITEM_PRICE)) / 100),0)
            FROM ORDER_ITEM AS A
            INNER JOIN ORDER_BASE B ON A.ORDER_CODE = B.CODE
			WHERE A.ORDER_CODE = NEW.ORDER_CODE
		)
		WHERE CODE = NEW.ORDER_CODE;
    END;

CREATE TRIGGER UpdateOrderAmounts_UPDATE
AFTER UPDATE ON ORDER_ITEM
    BEGIN
        UPDATE ORDER_BASE
            SET 
                ITEMS_TOTAL_PRICE = (
                    SELECT TOTAL(A.TOTAL_ITEM_PRICE)
                    FROM ORDER_ITEM AS A
		    WHERE A.ORDER_CODE = NEW.ORDER_CODE
            ),
		ITEMS_IN_ORDER = (
			SELECT 
			    coalesce(COUNT(*), 0)
                    	FROM ORDER_ITEM AS A
			WHERE A.ORDER_CODE = NEW.ORDER_CODE
		),
		TAX_TOTAL= (
			SELECT 
			    COALESCE((B.TAX_PERCENTAGE * (B.PREPARATION_COST + TOTAL(A.TOTAL_ITEM_PRICE)) / 100),0)
            FROM ORDER_ITEM AS A
            INNER JOIN ORDER_BASE B ON A.ORDER_CODE = B.CODE
			WHERE A.ORDER_CODE = NEW.ORDER_CODE
		)
		WHERE CODE = NEW.ORDER_CODE;
    END;

CREATE TRIGGER UpdateOrderFinalPrice_UPDATE
AFTER UPDATE ON ORDER_BASE
    BEGIN
        UPDATE ORDER_BASE
            SET 
                FINAL_PRICE = coalesce((TAX_TOTAL + PREPARATION_COST + ITEMS_TOTAL_PRICE), 0)
			WHERE
				CODE = new.CODE;
	END


CREATE TRIGGER UpdateClientAmount_UPDATE
AFTER UPDATE ON ORDER_BASE
    BEGIN
        UPDATE CLIENT
            SET 
                TOTAL_SPENT = (
					SELECT TOTAL(FINAL_PRICE)
					FROM ORDER_BASE
					WHERE CLIENT_CODE = NEW.CLIENT_CODE AND NEW.ORDER_STATUS LIKE 'COMPLETADA'
				),
				TOTAL_ORDERS = (
					SELECT COALESCE(COUNT(*), 0)
					FROM Order_Base
					WHERE CLIENT_CODE = NEW.CLIENT_CODE
				)
			WHERE
				CODE = new.CLIENT_CODE;
	END
