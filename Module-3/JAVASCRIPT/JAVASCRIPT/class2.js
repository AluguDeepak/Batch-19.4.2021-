class Employee
{
    constructor(eid,ename,desig,jd,sal)
    {
        this.Eid=eid;
        this.Ename=ename;
        this.Desig=desig;
        this.JoinDate=jd;
        this.Salary=sal;
    }
    Info()
    {
        console.log("Eid: "+this.Eid);
        console.log("Ename: "+this.Ename);
        console.log("Designation: "+this.Desig);
        console.log("JoinDate: "+this.JoinDate);
        console.log("Salary: "+this.Salary);
        
    }
}
class Manager extends Employee
{
    constructor(eid,ename,desig,jd,sal,level)
    {
        super(eid,ename,desig,jd,sal);
        this.Level=level;
    }
    Info()
    {
        super.Info();
        console.log("Manager: "+this.Level);
    }
    
}
let obj=new Manager(100,'Rajan','TeamLeader',new Date(2010,12,21),560000,'Level1');
obj.Info();
let ob1=new Employee(100,'Rajan','TeamLeader',new Date(2010,12,21),560000);
ob1.Info();