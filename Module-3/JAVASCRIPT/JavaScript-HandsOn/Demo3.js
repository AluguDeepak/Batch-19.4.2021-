// JavaScript source code
//IF-Else
let a = 11;
if (a % 2 == 0) {
    console.log('Even');
}
else
    console.log('Odd');
let obj = new Date();
let day = obj.getDay();
let result = '';
switch (day) {
    case 1:
        result = 'Monday';
        break;
    case 3:
        result = "WednesDay";
        break;
}
console.log("Today is :" + result);
