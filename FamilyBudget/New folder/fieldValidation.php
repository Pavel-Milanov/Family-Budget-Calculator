<?php
include "./dbManipulation.php";

$errors = array();
$targetPhotoFile = basename($_FILES["photo"]["name"]);

function isTheFieldFilled($input, &$errors)
{
    $tmp = $_POST["$input"];

    if (!$tmp) {
        $errors['$input'] = "$input полето е задължително!" . "<br>";
    }
}

function validateMinLength($input, $minLength, &$errors)
{
    $tmp = $_POST["$input"];

    if (strlen($tmp) < $minLength) {
        $errors['$input'] = "$input полето трябва да бъде по-голямо от $minLength символа!" . "<br>";
    }
}
function validateMaxLength($input, $maxLength, &$errors)
{
    $tmp = $_POST["$input"];

    if (strlen($tmp) > $maxLength) {
        $errors['$input'] = "$input полето трябва да бъде по-малко от $maxLength символа!" . "<br>";
    }
}
function validateMinValue($input, $minValue, &$errors)
{
    $tmp = $_POST["$input"];

    if ($tmp < $minValue) {
        $errors['$input'] = "Числото $input трябва да бъде по-голямо от $minValue!" . "<br>";
    }
}
function validateMaxValue($input, $maxValue, &$errors)
{
    $tmp = $_POST["$input"];

    if ($tmp > $maxValue) {
        $errors['$input'] = "Числото $input трябва да бъде по-малко от $maxValue!" . "<br>";
    }
}
function validateName($input, &$errors)
{
    if (!preg_match('/^[a-zA-Z-\p{Cyrillic}]+$/u', $input)) {
        $errors['$input'] = "Въведеното име има невалидни символи!" . "<br>";
    }
}
function validateBirthDate($input, &$errors, $min, $max)
{
    if (!preg_match("/^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])$/", $input)) {
        $errors['$input'] = "Въведенените ден, месец и година имат невалидни символи!" . "<br>";
    }
    $inputToUnix = strtotime($input);
    $minToUnix = strtotime($min);
    $maxToUnix = strtotime($max);
    if ($inputToUnix < $minToUnix || $inputToUnix > $maxToUnix) {
        $errors['$input'] = "Въведенените година след 1930 и преди 2004!" . "<br>";
    }
}
function validateLink($link, &$errors)
{
    if (!preg_match("/\b(?:(?:https?|ftp):\/\/|www\.)[-a-z0-9+&@#\/%?=~_|!:,.;]*[-a-z0-9+&@#\/%=~_|]/i", $link)) {
        $errors['$link'] = "Въведеният линк е невалиден!" . "<br>";
    }
}
function isPhotoFieldFilled($photo, &$errors)
{
    $target_dir = ".";
    $targetPhotoFile = $target_dir . basename($_FILES["photo"]["name"]);
    if (!$targetPhotoFile) {
        echo "Не е въведено изображение!" . "<br>";
    }
}

function validatePhoto($targetPhotoFile, &$errors)
{
    $target_dir = ".";
    $targetPhotoFile = $target_dir . $_POST['facultyNumber'] . basename($_FILES["photo"]["name"]);
    $isUploadOk = 1;
    $imageFileExtension  = strtolower(pathinfo($targetPhotoFile, PATHINFO_EXTENSION));

    if (isset($_POST["submit"])) {
        $check = getimagesize($_FILES["photo"]["tmp_name"]);
        if ($check !== false) {
            echo "File is an image - " . $check["mime"] . "." . "<br>";
            $isUploadOk = 1;
        } else {
            echo "Файлът не е изображение!" . "<br>";
            $isUploadOk = 0;
        }
    }

    if ($_FILES["photo"]["size"] > 500000) {
        echo "Размерът на изображението е прекалено голям!" . "<br>";
        $isUploadOk = 0;
    }

    if ($imageFileExtension != "jpg" && $imageFileExtension != "png" && $imageFileExtension != "jpeg" && $imageFileExtension != "gif") {
        echo "Форматът на каченото изображение не се поддържа! Поддържаните формати са JPG, JPEG, PNG и GIF." . "<br>";
        $isUploadOk = 0;
    }

    if ($isUploadOk == 0) {
        echo "Изображението не беше качено!" . "<br>";
    } else {
        if (move_uploaded_file($_FILES["photo"]["tmp_name"], $targetPhotoFile)) {
        } else {
            echo "При качването на изображението възникна грешка!" . "<br>";
        }
    }
    return $isUploadOk;
}
