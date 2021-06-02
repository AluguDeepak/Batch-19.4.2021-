function Sum(...a)
{
    let r=0;
    for(let i of a)
    {
        r=r+i;
    }
    console.log("sum of array no's: "+r);
}
Sum(12,23,34,45);
function Info(a,...b)
{
    console.log("I love: "+a);
    console.log("Other Optional Language i am interested:"+b[0]+','+b[1]+","+b[2]);
}
Info('JavaScript','C#','Java','C++');