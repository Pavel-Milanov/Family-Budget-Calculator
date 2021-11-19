<?php

include "./dbConnection.php";

$tableName = "user_information";

function insertInTable($firstName, $lastName, $specialty, $year, $facultyNumber, $groupNumber, $birthDate, $zodiac, $link, $photo, $motivation)
{
    try {
        $connection = dbConnection();
        $sql = "INSERT INTO user_information(firstName, lastName, specialty, year, facultyNumber, groupNumber, birthDate, zodiac, link, photo, motivation) 
            VALUES (:firstName, :lastName, :specialty, :year, :facultyNumber, :groupNumber, :birthDate, :zodiac, :link,  :photo, :motivation)";

        $preparedSql = $connection->prepare($sql) or die("Свързването е неуспешно!" . "<br>");
        $preparedSql->bindParam(':firstName', $firstName);
        $preparedSql->bindParam(':lastName', $lastName);
        $preparedSql->bindParam(':specialty', $specialty);
        $preparedSql->bindParam(':year', $year);
        $preparedSql->bindParam(':facultyNumber', $facultyNumber);
        $preparedSql->bindParam(':groupNumber', $groupNumber);
        $preparedSql->bindParam(':birthDate', $birthDate);
        $preparedSql->bindParam(':zodiac', $zodiac);
        $preparedSql->bindParam(':link', $link);
        $preparedSql->bindParam(':photo', $photo);
        $preparedSql->bindParam(':motivation', $motivation);

        $preparedSql->execute() or die("Неуспешно изпълнение на SQL заявката!" . "<br>");
        echo "Данните са добавени успешно!" . "<br>";
    } catch (PDOException $error) {
        echo $error->getMessage();
    }
}

function checkFacultyNumber($facultyNumber)
{
    global $tableName;
    try {
        $connection = dbConnection();
        $sql = "SELECT facultyNumber FROM $tableName WHERE facultyNumber=$facultyNumber";
        $result = $connection->prepare($sql) or die("Свързването е неуспешно!" . "<br>");
        $result->execute() or die("Неуспешно изпълнение на SQL заявката!" . "<br>");
        if ($result->rowCount() > 0) {
            echo "Потребител с този факултетен номер вече е въведен!" . "<br>";
            return 0;
        } else return 1;
    } catch (PDOException $error) {
        echo $error->getMessage();
    }
}
