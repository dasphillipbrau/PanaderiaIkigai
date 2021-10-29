CREATE TABLE "Measurement_Unit" (
	"NAME"	TEXT,
	PRIMARY KEY("NAME")
);

CREATE TABLE "Ingredient" (
	"CODE"	INTEGER,
	"NAME"	TEXT NOT NULL UNIQUE COLLATE NOCASE,
	"UNIT_OF_MEASURE"	TEXT NOT NULL,
	"AVERAGE_PRICE"	REAL DEFAULT 0,
	"AVERAGE_MINIMUM_PRICE"	REAL DEFAULT 0,
	"TOTAL_UNITS_AVAILABLE"	INTEGER DEFAULT 0,
	FOREIGN KEY("UNIT_OF_MEASURE") REFERENCES "Measurement_Unit"("NAME"),
	PRIMARY KEY("CODE" AUTOINCREMENT)
);

CREATE TABLE "Ingredient_Detailed" (
	"INGREDIENT_CODE"	INTEGER NOT NULL,
	"BRAND" TEXT NOT NULL,
	"INGREDIENT_SOURCE"	TEXT NOT NULL,
	"UNIT_PRICE"	REAL NOT NULL DEFAULT 0,
	"AMOUNT_IN_UNIT"	REAL NOT NULL,
	"MINIMUM_PRICE_PER_UNIT"	REAL NOT NULL,
	"QUALITY"	INTEGER NOT NULL DEFAULT 1,
	"UNITS_AVAILABLE"	INTEGER NOT NULL DEFAULT 0,
	"DETAILED_INGREDIENT_ID" UNIQUE GENERATED ALWAYS AS (
		INGREDIENT_CODE || '-' || INGREDIENT_SOURCE || '-' || BRAND
	)
);

CREATE TABLE "Product_Category" (
	"NAME"	TEXT,
	PRIMARY KEY("NAME")
);

CREATE TABLE "Recipe" (
	"CODE"	INTEGER,
	"NAME"	TEXT NOT NULL,
	"CATEGORY_NAME"	TEXT NOT NULL,
	"AUTHOR"	TEXT NOT NULL DEFAULT 'Kendall Monge',
	"TOTAL_PRICE"	REAL DEFAULT 0,
	"UNITS_PREPARED"	INTEGER NOT NULL DEFAULT 0,
	"MAIN_INGREDIENT_QUANTITY"	REAL NOT NULL DEFAULT 0,
	"PREPARATION_NOTES"	TEXT DEFAULT 'Por definir',
	"IMAGE"	BLOB,
	PRIMARY KEY("CODE" AUTOINCREMENT),
	FOREIGN KEY("CATEGORY_NAME") REFERENCES "Product_Category"("NAME")
);

CREATE TABLE "Recipe_Step" (
	"RECIPE_STEP_CODE"	TEXT,
	"RECIPE_CODE"	INTEGER,
	"INGREDIENT_NAME"	TEXT,
	"INGREDIENT_PERCENTAGE"	REAL DEFAULT 0,
	"INGREDIENT_QUANTITY"	REAL DEFAULT 0,
	"PRICE_FOR_AMOUNT_USED"	REAL DEFAULT 0,
	FOREIGN KEY("RECIPE_CODE") REFERENCES "Recipe"("CODE"),
	FOREIGN KEY("INGREDIENT_NAME") REFERENCES "Ingredient"("NAME"),
	PRIMARY KEY("RECIPE_STEP_CODE")
);
