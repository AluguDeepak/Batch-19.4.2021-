// JavaScript source code
var obj = { Sid: 1, Sname: 'Rohan', Age: 10 }; //javascript object.
var emp = { "EID": 1, "Ename": 'Karan', "Salary": 12000 }; //Json Object.
//console.log(obj.Sid);
//console.log(obj.Sname);
//console.log(obj.Age);
let list = [
    { Sid: 1, Sname: 'Rohan', Age: 10 },
    { Sid: 2, Sname: 'Charan', Age: 10 },
    { Sid: 3, Sname: 'Rama', Age: 10 },
    { Sid: 4, Sname: 'Krishna', Age: 10 },
    { Sid: 5, Sname: 'Robert', Age: 10 },
    { Sid: 6, Sname: 'Jeson', Age: 10 },
];
for (let ob of list) {
    console.log(ob.Sid, ob.Sname, ob.Age);
}
