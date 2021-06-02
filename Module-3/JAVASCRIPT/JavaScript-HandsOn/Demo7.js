// JavaScript source code
function Greet() {
    console.log('Hello World');
}
Greet()
function Add(a, b) {
    let c = a + b;
    console.log('Addition:' + c);
}
Add(2, 3)
function Square(a) {
    return a * a;
}
let result = Square(3);
console.log(result);

//arrow functions
let Mul = (a, b) => {
    let c = a * b;
    console.log(c);
}
Mul(12, 2)
let GetFlowers = () => {
    return [
        "Rose",
        "Lilly",
        "Jasmine",
        "Tulips"
    ];
}
for (let k of GetFlowers()) {
    console.log(k);
}