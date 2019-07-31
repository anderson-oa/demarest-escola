using DemarestEscolaBackend.Infra.Data.Context;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using DemarestEscolaBackend.Domain.Entities;
using System.Linq;
using DemarestEscolaBackend.Domain.Interfaces.Services;
using DemarestEscolaBackend.Domain.Services;
using DemarestEscolaBackend.Domain.Interfaces.Repositories;
using DemarestEscolaBackend.Infra.Data.Repositories;

namespace DemarestEscolaBackend.Infra.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void Services(IServiceCollection services, string connectionString)
        {
            // Initial            
            services.AddDbContext<MainContext>(options => options.UseSqlServer(connectionString));

            // Service
            services.AddScoped<IClasseService, ClasseService>();
            services.AddScoped<IExamService, ExamService>();
            services.AddScoped<IStudentClasseService, StudentClasseService>();
            services.AddScoped<IStudentService, StudentService>();

            // Repository
            services.AddScoped<IClasseRepository, ClasseRepository>();
            services.AddScoped<IExamRepository, ExamRepository>();
            services.AddScoped<IStudentClasseRepository, StudentClasseRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();
        }

        public static void SeedData(IServiceScope scope)
        {
            using (MainContext context = scope.ServiceProvider.GetService<MainContext>())
            {
                context.Database.Migrate();

                if (!context.Set<Classe>().Any())
                {
                    IEnumerable<Classe> classes = new List<Classe>
                    {
                         new Classe
                         {
                             Name = "matematica",
                             DaysAttended = 41
                         },
                         new Classe
                         {
                             Name = "historia",
                             DaysAttended = 38
                         },
                         new Classe
                         {
                             Name = "espanhol",
                             DaysAttended = 46,
                         },
                         new Classe
                         {
                             Name = "ingles",
                             DaysAttended = 46
                         },
                         new Classe
                         {
                             Name = "portugues",
                             DaysAttended = 40,
                         },
                         new Classe
                         {
                             Name = "fisica",
                             DaysAttended = 36,
                         }
                    };

                    context.Set<Classe>().AddRange(classes);
                }

                if (!context.Set<Student>().Any())
                {
                    IEnumerable<Student> students = new List<Student>
                    {
                        new Student
                        {
                            Name = "Ruby",
                            Surname = "Cooley",
                            Email = "ruby.cooley@contoso.io",
                            Address = "722 Schroeders Avenue, Stewartville, New Mexico, 9143",
                            Classes = new List<StudentClasse>
                            {
                                new StudentClasse { ClasseId = 1 },
                                new StudentClasse { ClasseId = 2 },
                                new StudentClasse { ClasseId = 4 },
                                new StudentClasse { ClasseId = 5 },
                                new StudentClasse { ClasseId = 6 },
                            }
                        },
                        new Student
                        {
                            Name = "Cantu",
                            Surname = "Branch",
                            Email = "cantu.branch@contoso.co.uk",
                            Address = "227 Rockwell Place, Hilltop, Delaware, 8662",
                            Classes = new List<StudentClasse>
                            {
                                 new StudentClasse { ClasseId = 1 },
                                 new StudentClasse { ClasseId = 2 },
                                 new StudentClasse { ClasseId = 3 },
                                 new StudentClasse { ClasseId = 5 },
                                 new StudentClasse { ClasseId = 6 },
                            }
                        },
                        new Student
                        {
                            Name = "Jimenez",
                            Surname = "Rivas",
                            Email = "jimenez.rivas@contoso.com",
                            Address = "673 Grimes Road, Katonah, Federated States Of Micronesia, 4847",
                            Classes = new List<StudentClasse>
                            {
                                 new StudentClasse { ClasseId = 1 },
                                 new StudentClasse { ClasseId = 2 },
                                 new StudentClasse { ClasseId = 3 },
                                 new StudentClasse { ClasseId = 5 },
                                 new StudentClasse { ClasseId = 6 },
                            }
                        },
                        new Student
                        {
                            Name = "Staci",
                            Surname = "Hoffman",
                            Email = "staci.hoffman@contoso.us",
                            Address = "435 Moore Street, Lorraine, Wyoming, 2191",
                            Classes = new List<StudentClasse>
                            {
                                 new StudentClasse { ClasseId = 1 },
                                 new StudentClasse { ClasseId = 2 },
                                 new StudentClasse { ClasseId = 3 },
                                 new StudentClasse { ClasseId = 5 },
                                 new StudentClasse { ClasseId = 6 },
                            }
                        },
                        new Student
                        {
                            Name = "Carver",
                            Surname = "Hess",
                            Email = "carver.hess@contoso.info",
                            Address = "344 Roder Avenue, Springhill, Northern Mariana Islands, 8636",
                            Classes = new List<StudentClasse>
                            {
                                new StudentClasse { ClasseId = 1 },
                                new StudentClasse { ClasseId = 2 },
                                new StudentClasse { ClasseId = 4 },
                                new StudentClasse { ClasseId = 5 },
                                new StudentClasse { ClasseId = 6 },
                            }
                        },
                        new Student
                        {
                            Name = "Yesenia",
                            Surname = "Hale",
                            Email = "yesenia.hale@contoso.ca",
                            Address = "410 Lincoln Road, Defiance, Puerto Rico, 766",
                            Classes = new List<StudentClasse>
                            {
                                new StudentClasse { ClasseId = 1 },
                                new StudentClasse { ClasseId = 2 },
                                new StudentClasse { ClasseId = 4 },
                                new StudentClasse { ClasseId = 5 },
                                new StudentClasse { ClasseId = 6 },
                            }
                        },
                        new Student
                        {
                            Name = "Blackwell",
                            Surname = "Blanchard",
                            Email = "blackwell.blanchard@contoso.biz",
                            Address = "976 Ocean Court, Tryon, Guam, 598",
                            Classes = new List<StudentClasse>
                            {
                                 new StudentClasse { ClasseId = 1 },
                                 new StudentClasse { ClasseId = 2 },
                                 new StudentClasse { ClasseId = 3 },
                                 new StudentClasse { ClasseId = 5 },
                                 new StudentClasse { ClasseId = 6 },
                            }
                        },
                        new Student
                        {
                            Name = "Sophia",
                            Surname = "Workman",
                            Email = "sophia.workman@contoso.tv",
                            Address = "224 Kenmore Terrace, Staples, New Hampshire, 4619",
                            Classes = new List<StudentClasse>
                            {
                                new StudentClasse { ClasseId = 1 },
                                new StudentClasse { ClasseId = 2 },
                                new StudentClasse { ClasseId = 4 },
                                new StudentClasse { ClasseId = 5 },
                                new StudentClasse { ClasseId = 6 },
                            }
                        },
                        new Student
                        {
                            Name = "Ellis",
                            Surname = "Klein",
                            Email = "ellis.klein@contoso.org",
                            Address = "316 Bristol Street, Ernstville, Texas, 7698",
                            Classes = new List<StudentClasse>
                            {
                                 new StudentClasse { ClasseId = 1 },
                                 new StudentClasse { ClasseId = 2 },
                                 new StudentClasse { ClasseId = 3 },
                                 new StudentClasse { ClasseId = 5 },
                                 new StudentClasse { ClasseId = 6 },
                            }
                        }
                    };

                    context.Set<Student>().AddRange(students);
                }

                context.SaveChanges();
            }
        }
    }
}
