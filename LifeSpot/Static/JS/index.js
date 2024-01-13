let userName = function ( newVisit ){
    if (newVisit){
        window.sessionStorage.setItem('UserName', prompt('Введите своё имя:'));
    }
}
let userDate = function ( newVisit ){
    if (newVisit){
        window.sessionStorage.setItem('UserAgentString', window.navigator.userAgent);
        window.sessionStorage.setItem('StartSessionDate', new Date().toLocaleString());
    }
}
let userAge = function ( newVisit ){
    if (newVisit){
        window.sessionStorage.setItem('UserAge', prompt('Введите свой возраст:'));
        if (window.sessionStorage.getItem('UserAge') < 18) {
            alert('Ваш возраст меньше 18 лет!');
            window.location.href = "http://www.google.com";
        }
    }
}
let logger = function () {
    console.log(`Дата входа: ${window.sessionStorage.getItem('StartSessionDate')}`);
    console.log(`Строка: ${window.sessionStorage.getItem('UserAgentString')}`);
    console.log(`Имя: ${window.sessionStorage.getItem('UserName')}`);
    console.log(`Возраст: ${window.sessionStorage.getItem('UserAge')}`);
}
function askForInstagram (){
    setTimeout(function () {

        alert('Подпишитесь на наш Инстаграм!')

    }, 10000);
}
function handleSession (userNameFunc, userAgeFunc, userDateFunc, loggerFunc) {
    if (window.sessionStorage.getItem('UserAge') == null){
        userNameFunc(true);
        userAgeFunc(true);
        userDateFunc(true);
    }
    loggerFunc();
}