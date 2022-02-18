SELECT  (
            SELECT COUNT(ID) AS TOTALCITY FROM STATION
        ) -
        (
            SELECT COUNT(DISTINCT CITY) FROM STATION
        );