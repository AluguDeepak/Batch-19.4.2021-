using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HandsOnEFCore_DataBaseFirst.Entities
{
    public partial class Batch2DBContext : DbContext
    {
        public Batch2DBContext()
        {
        }

        public Batch2DBContext(DbContextOptions<Batch2DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Dept> Depts { get; set; }
        public virtual DbSet<Emp> Emps { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Employee1> Employee1s { get; set; }
        public virtual DbSet<MyTable> MyTables { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Printer> Printers { get; set; }
        public virtual DbSet<Prod> Prods { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<VwEmp> VwEmps { get; set; }
        public virtual DbSet<VwEmp1> VwEmp1s { get; set; }
        public virtual DbSet<VwEmpDept> VwEmpDepts { get; set; }
        public virtual DbSet<VwEmployee> VwEmployees { get; set; }
        public virtual DbSet<VwPerson> VwPeople { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=SANTU\\MSSQLSERVER2019;Initial Catalog=Batch2DB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Customer");

                entity.Property(e => e.Cid).ValueGeneratedOnAdd();

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cname)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dept>(entity =>
            {
                entity.HasKey(e => e.Did)
                    .HasName("PK__Dept__C0312218B9FF2177");

                entity.ToTable("Dept");

                entity.HasIndex(e => e.Dname, "UQ__Dept__83BFD8495590F127")
                    .IsUnique();

                entity.Property(e => e.Did)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dname)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Emp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Emp");

                entity.HasIndex(e => e.Eid, "index_Eid")
                    .IsClustered();

                entity.HasIndex(e => e.Salary, "index_salary");

                entity.Property(e => e.Desig)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Did)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ename)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__Employee__C1971B531F49DA18");

                entity.ToTable("Employee");

                entity.Property(e => e.Eid).ValueGeneratedNever();

                entity.Property(e => e.Desig)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Did)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ename)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JoinDate).HasColumnType("date");

                entity.Property(e => e.Salary).HasColumnName("salary");

                entity.HasOne(d => d.DidNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.Did)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__Employee__Did__68487DD7");
            });

            modelBuilder.Entity<Employee1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Employee1");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.Doj)
                    .HasColumnType("datetime")
                    .HasColumnName("DOJ");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MyTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("myTable");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Sname)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.OrderDate)
                    .HasColumnType("date")
                    .HasColumnName("Order_Date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderId).ValueGeneratedOnAdd();

                entity.Property(e => e.OrderName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Order_Name");
            });

            modelBuilder.Entity<Printer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Printer");

                entity.Property(e => e.PrinterId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Printer_ID");

                entity.Property(e => e.PrinterName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Printer_Name");
            });

            modelBuilder.Entity<Prod>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Prod");

                entity.HasIndex(e => e.Pid, "index_Pid")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => e.Pname, "index_Pname")
                    .IsUnique();

                entity.Property(e => e.Pid).ValueGeneratedOnAdd();

                entity.Property(e => e.Pname)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__Product__C5705938BB87F370");

                entity.ToTable("Product");

                entity.Property(e => e.Pid).ValueGeneratedNever();

                entity.Property(e => e.Pname)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Student");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sname)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Supplier", "Sale");

                entity.Property(e => e.SupplierId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Supplier_id");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Supplier_name");
            });

            modelBuilder.Entity<VwEmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Emp");

                entity.Property(e => e.Ename)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwEmp1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Emp1");

                entity.Property(e => e.Desig)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Did)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ename)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<VwEmpDept>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_EmpDept");

                entity.Property(e => e.Did)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dname)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ename)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Employee");

                entity.Property(e => e.Desig)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ename)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwPerson>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Person");

                entity.Property(e => e.Pname)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.HasSequence<int>("SQ1")
                .StartsAt(100)
                .IncrementsBy(25)
                .HasMin(100)
                .HasMax(200)
                .IsCyclic();

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
