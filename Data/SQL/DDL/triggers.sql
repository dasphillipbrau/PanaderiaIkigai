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
