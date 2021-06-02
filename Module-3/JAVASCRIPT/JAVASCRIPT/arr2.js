function Sum(a,b)
{
    console.log(a()+b());
}
Sum(function(){return 10},function(){return 11});
Sum(()=>12,()=>13);