// JavaScript source code
//Arrays
var a = [12, 23, 34, 45, 56, 67]
a[6] = 34;
console.log(a[0]); //12
console.log(a.length);
//print array values
//for (var i = 0; i < a.length; i++) {
//    console.log(a[i])
//}
a.push(100);
for (let k of a) {
    console.log(k)
}
var ar1 = [13, 12.3, true, null] //store mixed values