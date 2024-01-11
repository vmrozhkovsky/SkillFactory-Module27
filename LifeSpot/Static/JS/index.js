let userData = new Map();
function getUserData (){
    userData.set('UserName', prompt('Введите своё имя:'));
}
function getUserAgentString (){
    userData.set('UserAgentString', window.navigator.userAgent);
    userData.set("StartSessionDate", new Date().toLocaleString())
}
function checkAge (){
    userData.set('UserAge', prompt('Введите свой возраст:'));
    if (userData.get('UserAge') < 18) {
        alert('Ваш возраст меньше 18 лет!');
        window.location.href = "http://www.google.com";
    }
}
let sessionLog = function logSession() {
    for (let result of userData){
        console.log(result)
    }
}
function askForInstagram (){
    setTimeout(function () {

        alert('Подпишитесь на наш Инстаграм!')

    }, 10000);
}