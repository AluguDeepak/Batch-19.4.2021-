let m1=89,m2=78,m3=89,m4=67,m5=90;
let tot=m1+m3+m2+m4+m5;
let avg=Math.round(tot/5);
let res=null;
if(avg>=70)

res="Distinction"
else if(avg>=60 && avg<70)
{
   res="FirstClass";
}
else if(avg>=50 && avg<60)
{
    res="Second Class";
}
else if(avg>=35 && avg<50)
res="Third Class";
else
res="Fail";
console.log("Total: "+tot)
console.log("Result: "+res);