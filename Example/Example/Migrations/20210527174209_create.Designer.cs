// <auto-generated />
using Example.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Example.Migrations
{
    [DbContext(typeof(StudentContext))]
    [Migration("20210527174209_create")]
    partial class create
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Example.Database.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Example.Database.StudentSubject", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<int>("SubjectID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("StudentID");

                    b.HasIndex("SubjectID");

                    b.ToTable("StudentSubjects");
                });

            modelBuilder.Entity("Example.Database.Subject", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("English")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Informatics")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logic")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("Example.Database.StudentSubject", b =>
                {
                    b.HasOne("Example.Database.Student", "Student")
                        .WithMany("StudentSubjects")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Example.Database.Subject", "Subject")
                        .WithMany("StudentSubjects")
                        .HasForeignKey("SubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Example.Database.Student", b =>
                {
                    b.Navigation("StudentSubjects");
                });

            modelBuilder.Entity("Example.Database.Subject", b =>
                {
                    b.Navigation("StudentSubjects");
                });
#pragma warning restore 612, 618
        }
    }
}
