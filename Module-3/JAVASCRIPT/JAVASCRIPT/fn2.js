function Add(a,b=10)
{
    console.log(a+b);
}
Add(19);
Add(12,12);
Add();
function Sum(a)
{
    let res=0;
    for(var i of a)
    {
        res=res+i;
    }
    console.log("Sum or Array no's "+res);
}
Sum([12,23,34,45,56]);
let a=[1,2,3,34];
Sum(a);
Sum(12,23,34);