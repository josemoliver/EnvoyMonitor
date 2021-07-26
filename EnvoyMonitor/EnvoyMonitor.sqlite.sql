BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS "Logs" (
	"LogID"	INTEGER,
	"StartTime"	INTEGER,
	"EndTime"	INTEGER,
	PRIMARY KEY("LogID" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "Readings" (
	"ReadingTime"	INTEGER,
	"PowerProduced"	NUMERIC,
	"PowerConsumed"	NUMERIC,
	"PowerNetConsumed"	NUMERIC,
	"PowerProducedLifetime"	NUMERIC,
	"PowerConsumedLifetime"	NUMERIC,
	"Comment"	TEXT,
	PRIMARY KEY("ReadingTime")
);
COMMIT;
