class A
{
    static M()
    {
        console.log("I am a Static M")
    }
}
class B extends A 
{
    static N()
    {
        console.log("I am a Static N")
    }
}
A.M();
B.M();
B.N();