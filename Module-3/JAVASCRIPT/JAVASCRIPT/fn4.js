function f()
{
    return [12,23,34];
}
[a,b,c]=f();
console.log(a);
console.log(b);
console.log(c);
[a]=f();
console.log(a);
function f1(a,b)
{
    return [a,b]
}
[i,j]=f1('sachin','rahul');
console.log(i);
console.log(j);