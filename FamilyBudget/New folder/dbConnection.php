<?php

function dbConnection()
{
    $host = "localhost";
    $dbname = "62134_dimitar_lazarov";
    $username = "root";
    $pass = "";

    try {
        $connection = new PDO("mysql:host=$host;dbname=$dbname;charset=utf8", $username, $pass);

        return $connection;
    } catch (PDOException $error) {
        echo "Грешка: Неуспешна връзка с базата данни!" . "<br>";
        die();
    }
}
