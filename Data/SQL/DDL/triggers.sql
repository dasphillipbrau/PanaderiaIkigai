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
    END