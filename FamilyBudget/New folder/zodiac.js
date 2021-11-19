function zodiacOutput() {
    var result;
    var inp = document.getElementById("birthDate").value;
    var d = new Date(inp);
    var birthDay = d.getDate();
    var birthMonth = d.getMonth() + 1;

    if (birthMonth == 1 && birthDay >= 20 || birthMonth == 2 && birthDay <= 18) {
        result = ("Водолей");
    }
    if (birthMonth == 2 && birthDay >= 19 || birthMonth == 3 && birthDay <= 20) {
        result = ("Риби");
    }
    if (birthMonth == 3 && birthDay >= 21 || birthMonth == 4 && birthDay <= 19) {
        result = ("Овен");
    }
    if (birthMonth == 4 && birthDay >= 20 || birthMonth == 5 && birthDay <= 20) {
        result = ("Телец");
    }
    if (birthMonth == 5 && birthDay >= 21 || birthMonth == 6 && birthDay <= 20) {
        result = ("Близнаци");
    }
    if (birthMonth == 6 && birthDay >= 21 || birthMonth == 7 && birthDay <= 22) {
        result = ("Рак");
    }
    if (birthMonth == 7 && birthDay >= 23 || birthMonth == 8 && birthDay <= 22) {
        result = ("Лъв");
    }
    if (birthMonth == 8 && birthDay >= 23 || birthMonth == 9 && birthDay <= 22) {
        result = ("Дева");
    }
    if (birthMonth == 9 && birthDay >= 23 || birthMonth == 10 && birthDay <= 22) {
        result = ("Везни");
    }
    if (birthMonth == 10 && birthDay >= 23 || birthMonth == 11 && birthDay <= 21) {
        result = ("Скорпион");
    }
    if (birthMonth == 11 && birthDay >= 22 || birthMonth == 12 && birthDay <= 21) {
        result = ("Стрелец");
    }
    if (birthMonth == 12 && birthDay >= 22 || birthMonth == 1 && birthDay <= 19) {
        result = ("Козирог");
    }

    document.getElementById("zodiac").value = result;
}
