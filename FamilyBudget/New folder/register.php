<?php
include "./fieldValidation.php";

$specialty_Min_Length = 2;
$birthDate_Min = "1930-01-01";

$firstName_Max_Length = 128;
$lastName_Max_Length = 128;
$specialty_Max_Length = 128;
$year_Max_Length = 2;
$groupNumber_Max_Length = 2;
$link_Max_Length = 80;
$motivation_Max_Length = 1024;
$birthDate_Max = "2003-12-31";

$year_Min_Value = 1;
$facultyNumber_Min_Value = 1;
$groupNumber_Min_Value = 1;

$year_Max_Value = 20;
$facultyNumber_Max_Value = 99999999999999999999;
$groupNumber_Max_Value = 20;

$errors = array();

if ($_POST) {
    $firstName = $_POST['firstName'];
    $lastName = $_POST['lastName'];
    $specialty = $_POST['specialty'];
    $year = $_POST['year'];
    $facultyNumber = $_POST['facultyNumber'];
    $groupNumber = $_POST['groupNumber'];
    $birthDate = $_POST['birthDate'];
    $zodiac = $_POST['zodiac'];
    $link = $_POST['link'];
    $motivation = $_POST['motivation'];
    $photo;

    if (count($errors) == 0) {
        if (checkFacultyNumber($facultyNumber)) {
            isTheFieldFilled('firstName', $errors);
            isTheFieldFilled('lastName', $errors);
            isTheFieldFilled('specialty', $errors);
            isTheFieldFilled('year', $errors);
            isTheFieldFilled('facultyNumber', $errors);
            isTheFieldFilled('groupNumber', $errors);
            isTheFieldFilled('birthDate', $errors);
            isTheFieldFilled('link', $errors);
            isPhotoFieldFilled('photo', $errors);
            isTheFieldFilled('motivation', $errors);

            validateMaxLength('firstName', $firstName_Max_Length, $errors);
            validateMaxLength('lastName', $lastName_Max_Length, $errors);
            validateMaxLength('specialty', $specialty_Max_Length, $errors);
            validateMaxLength('link', $link_Max_Length, $errors);
            validateMaxLength('motivation', $motivation_Max_Length, $errors);

            validateMinLength('specialty', $specialty_Min_Length, $errors);

            validateMinValue('year', $year_Min_Value, $errors);
            validateMinValue('facultyNumber', $facultyNumber_Min_Value, $errors);
            validateMinValue('groupNumber', $groupNumber_Min_Value, $errors);

            validateMaxValue('year', $year_Max_Value, $errors);
            validateMaxValue('facultyNumber', $facultyNumber_Max_Value, $errors);
            validateMaxValue('groupNumber', $groupNumber_Max_Value, $errors);

            if (count($errors) == 0) {
                validateName($firstName, $errors);
                validateName($lastName, $errors);
                validateBirthDate($birthDate, $errors, $birthDate_Min, $birthDate_Max);
                if (validatePhoto('photo', $errors)) {
                    $photo = $targetPhotoFile;
                }
                validateLink($link, $errors);

                if (count($errors) == 0) {
                    insertInTable($firstName, $lastName, $specialty, $year, $facultyNumber, $groupNumber, $birthDate, $zodiac, $link, $photo, $motivation);
                }
            } else {
                foreach ($errors as $err) {
                    echo $err . "<br>";
                }
                echo "Моля поправете грешките!" . "<br>";
            }
        } else {
            foreach ($errors as $err) {
                echo $err . "<br>";
            }
            echo "Моля поправете грешките!" . "<br>";
        }
    } else {
        foreach ($errors as $err) {
            echo $err . "<br>";
        }
        echo "Моля поправете грешките!" . "<br>";
    }
}
