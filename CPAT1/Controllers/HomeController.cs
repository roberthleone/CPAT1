using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CPAT1.Models;

namespace CPAT1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult CoursePlan()
        {
            var students = new Student[]
            {
                new Student
                {
                    FirstName = "Ana",
                    MiddleInitial = 'S',
                    LastName = "Smith",
                    N_Number = "N00000001",
                    MajorID = 1
                },
                new Student
                {
                    FirstName = "Banana",
                    LastName = "Spots",
                    N_Number = "N00000002",
                    MajorID = 2
                }
            };

            ViewBag.currentStudent = students[0];

            var courses = new Course[]
            {
                new Course
                {
                    CourseID = "ENC1101",
                    CourseName = "Introduction to Rhetoric and Writing",
                    CreditHours = 3,
                    Description = "This course is an introduction to writing at the college level. Gordon Rule English credit.",
                    Major = "Computer Science",
                    InitialTermNumber = 1,
                    PreRequisites = new string[]
                    {

                    }

                },

                new Course
                {
                    CourseID = "MAC2311",
                    CourseName = "Calculus I",
                    CreditHours = 4,
                    Description = " This course examines the notions of limit, continuity and derivatives of functions " +
                    "of one variable. The course explores differentiation rules for algebraic, trigonometric, exponential " +
                    "and logarithmic functions. The course discusses applications of differential calculus, such as related " +
                    "rates problems, curve sketching, and optimization. The course also introduces students to definite and " +
                    "indefinite integrals and the Fundamental Theorem of Calculus. (This course cannot be used to satisfy " +
                    "upper-level degree requirements by mathematics, statistics or natural science majors. Students completing " +
                    "this course may not enroll in MAC 2233.) ",
                    Major = "Computer Science",
                    InitialTermNumber = 1,
                    PreRequisites = new string[]
                    {
                        "MAC1147"
                    }

                },

                new Course
                {
                    CourseID = "SCI",
                    CourseName = "Select a Science Course for Science Majors",
                    CreditHours = 3,
                    Description = "Select a Science Course for Science Majors",
                    Major = "Computer Science",
                    InitialTermNumber = 1,
                    PreRequisites = new string[]
                    {
                        
                    }

                },

                new Course
                {
                    CourseID = "IDC2000",
                    CourseName = "The Beauty and Joy of Computing",
                    CreditHours = 3,
                    Description = "(Recommended Free Elective) The course focuses on teaching students some " +
                    "of the Big Ideas of Computing such as abstraction, design, " +
                    "recursion, concurrency, simulations, and the limits of " +
                    "computation. The course also provides a historic perspective " +
                    "of Computing and where it is heading. Throughout the course, we " +
                    "will emphasis the relevance of Computing to the students, their " +
                    "future studies, their careers, and society. In this course students " +
                    "will learn Python as the programming language to deliver the " +
                    "concepts. Given that data is pervasive and the need to analyze data " +
                    "is in almost every discipline, learning Python that early will enable " +
                    "students to conduct data analysis which will be helpful for their studies " +
                    "at UNF and in their careers.",
                    Major = "Computer Science",
                    InitialTermNumber = 1,
                    PreRequisites = new string[]
                    {
                        
                    }

                },

                new Course
                {
                    CourseID = "GEN",
                    CourseName = "Select a General Education Course",
                    CreditHours = 3,
                    Description = "Select a General Education Course",
                    Major = "Computer Science",
                    InitialTermNumber = 1,
                    PreRequisites = new string[]
                    {
                        
                    }

                },

                new Course
                {
                    CourseID = "ENC1143",
                    CourseName = "Introduction to Rhetoric and Narrative",
                    CreditHours = 3,
                    Description = "This course introduces students to basic " +
                    "rhetorical features of a range of texts in different genres, " +
                    "with a focus on the elements of narrative. Students will learn " +
                    "how to read critically in preparation for writing critically on " +
                    "the course texts. Gordon Rule English credit. ",
                    Major = "Computer Science",
                    InitialTermNumber = 2,
                    PreRequisites = new string[]
                    {
                        
                    }

                },

                new Course
                {
                    CourseID = "COP2220",
                    CourseName = "Computer Science I",
                    CreditHours = 3,
                    Description = "This course provides an introduction to the programming " +
                    "process. Topics in the course include types, operations, expressions, " +
                    "control flow, I/O, functions, program structure, software design techniques, " +
                    "and problem solving. Course concepts are reinforced with many programming " +
                    "projects throughout the term in the C programming language. ",
                    Major = "Computer Science",
                    InitialTermNumber = 2,
                    PreRequisites = new string[]
                    {
                     
                    }

                },

                new Course
                {
                    CourseID = "SCI",
                    CourseName = "Select a Science Course for Science Majors",
                    CreditHours = 3,
                    Description = "Select a Science Course for Science Majors",
                    Major = "Computer Science",
                    InitialTermNumber = 2,
                    PreRequisites = new string[]
                    {

                    }

                },


                new Course
                {
                    CourseID = "MAC2312",
                    CourseName = "Calculus II",
                    CreditHours = 4,
                    Description = "This course continues the study of definite and " +
                    "indefinite integrals, and the Fundamental Theorem of Calculus begun " +
                    "in MAC 2311. The course presents various integration techniques and " +
                    "their applications, convergence of sequences and series, as well " +
                    "as power series and Taylor series of a function of one variable. (This " +
                    "course cannot be used to satisfy upper-level degree requirements by " +
                    "mathematics, statistics or natural science majors.) ",
                    Major = "Computer Science",
                    InitialTermNumber = 2,
                    PreRequisites = new string[]
                    {
                        "MAC2311",
                        "MAC2241"
                    }

                },

                new Course
                {
                    CourseID = "GEN",
                    CourseName = "Select a General Education Course",
                    CreditHours = 3,
                    Description = "Select a General Education Course",
                    Major = "Computer Science",
                    InitialTermNumber = 2,
                    PreRequisites = new string[]
                    {

                    }

                },

                new Course
                {
                    CourseID = "ENC1101",
                    CourseName = "Introduction to Rhetoric and Writing",
                    CreditHours = 3,
                    Description = "This course is an introduction to writing at the college level. Gordon Rule English credit.",
                    Major = "Computer Science",
                    InitialTermNumber = 3,
                    PreRequisites = new string[]
                    {

                    }

                },

                new Course
                {
                    CourseID = "MAC2311",
                    CourseName = "Calculus I",
                    CreditHours = 4,
                    Description = " This course examines the notions of limit, continuity and derivatives of functions " +
                    "of one variable. The course explores differentiation rules for algebraic, trigonometric, exponential " +
                    "and logarithmic functions. The course discusses applications of differential calculus, such as related " +
                    "rates problems, curve sketching, and optimization. The course also introduces students to definite and " +
                    "indefinite integrals and the Fundamental Theorem of Calculus. (This course cannot be used to satisfy " +
                    "upper-level degree requirements by mathematics, statistics or natural science majors. Students completing " +
                    "this course may not enroll in MAC 2233.) ",
                    Major = "Computer Science",
                    InitialTermNumber = 3,
                    PreRequisites = new string[]
                    {
                        "MAC1147"
                    }

                },

                new Course
                {
                    CourseID = "SCI",
                    CourseName = "Select a Science Course for Science Majors",
                    CreditHours = 3,
                    Description = "Select a Science Course for Science Majors",
                    Major = "Computer Science",
                    InitialTermNumber = 3,
                    PreRequisites = new string[]
                    {

                    }

                },

                new Course
                {
                    CourseID = "IDC2000",
                    CourseName = "The Beauty and Joy of Computing",
                    CreditHours = 3,
                    Description = "(Recommended Free Elective) The course focuses on teaching students some " +
                    "of the Big Ideas of Computing such as abstraction, design, " +
                    "recursion, concurrency, simulations, and the limits of " +
                    "computation. The course also provides a historic perspective " +
                    "of Computing and where it is heading. Throughout the course, we " +
                    "will emphasis the relevance of Computing to the students, their " +
                    "future studies, their careers, and society. In this course students " +
                    "will learn Python as the programming language to deliver the " +
                    "concepts. Given that data is pervasive and the need to analyze data " +
                    "is in almost every discipline, learning Python that early will enable " +
                    "students to conduct data analysis which will be helpful for their studies " +
                    "at UNF and in their careers.",
                    Major = "Computer Science",
                    InitialTermNumber = 3,
                    PreRequisites = new string[]
                    {

                    }

                },

                new Course
                {
                    CourseID = "GEN",
                    CourseName = "Select a General Education Course",
                    CreditHours = 3,
                    Description = "Select a General Education Course",
                    Major = "Computer Science",
                    InitialTermNumber = 3,
                    PreRequisites = new string[]
                    {

                    }

                },

                new Course
                {
                    CourseID = "ENC1143",
                    CourseName = "Introduction to Rhetoric and Narrative",
                    CreditHours = 3,
                    Description = "This course introduces students to basic " +
                    "rhetorical features of a range of texts in different genres, " +
                    "with a focus on the elements of narrative. Students will learn " +
                    "how to read critically in preparation for writing critically on " +
                    "the course texts. Gordon Rule English credit. ",
                    Major = "Computer Science",
                    InitialTermNumber = 4,
                    PreRequisites = new string[]
                    {

                    }

                },

                new Course
                {
                    CourseID = "COP2220",
                    CourseName = "Computer Science I",
                    CreditHours = 3,
                    Description = "This course provides an introduction to the programming " +
                    "process. Topics in the course include types, operations, expressions, " +
                    "control flow, I/O, functions, program structure, software design techniques, " +
                    "and problem solving. Course concepts are reinforced with many programming " +
                    "projects throughout the term in the C programming language. ",
                    Major = "Computer Science",
                    InitialTermNumber = 4,
                    PreRequisites = new string[]
                    {

                    }

                },

                new Course
                {
                    CourseID = "SCI",
                    CourseName = "Select a Science Course for Science Majors",
                    CreditHours = 3,
                    Description = "Select a Science Course for Science Majors",
                    Major = "Computer Science",
                    InitialTermNumber = 4,
                    PreRequisites = new string[]
                    {

                    }

                },


                new Course
                {
                    CourseID = "MAC2312",
                    CourseName = "Calculus II",
                    CreditHours = 4,
                    Description = "This course continues the study of definite and " +
                    "indefinite integrals, and the Fundamental Theorem of Calculus begun " +
                    "in MAC 2311. The course presents various integration techniques and " +
                    "their applications, convergence of sequences and series, as well " +
                    "as power series and Taylor series of a function of one variable. (This " +
                    "course cannot be used to satisfy upper-level degree requirements by " +
                    "mathematics, statistics or natural science majors.) ",
                    Major = "Computer Science",
                    InitialTermNumber = 4,
                    PreRequisites = new string[]
                    {
                        "MAC2311",
                        "MAC2241"
                    }

                },

                new Course
                {
                    CourseID = "GEN",
                    CourseName = "Select a General Education Course",
                    CreditHours = 3,
                    Description = "Select a General Education Course",
                    Major = "Computer Science",
                    InitialTermNumber = 4,
                    PreRequisites = new string[]
                    {

                    }

                },

                new Course
                {
                    CourseID = "ENC1101",
                    CourseName = "Introduction to Rhetoric and Writing",
                    CreditHours = 3,
                    Description = "This course is an introduction to writing at the college level. Gordon Rule English credit.",
                    Major = "Computer Science",
                    InitialTermNumber = 5,
                    PreRequisites = new string[]
                    {

                    }

                },

                new Course
                {
                    CourseID = "MAC2311",
                    CourseName = "Calculus I",
                    CreditHours = 4,
                    Description = " This course examines the notions of limit, continuity and derivatives of functions " +
                    "of one variable. The course explores differentiation rules for algebraic, trigonometric, exponential " +
                    "and logarithmic functions. The course discusses applications of differential calculus, such as related " +
                    "rates problems, curve sketching, and optimization. The course also introduces students to definite and " +
                    "indefinite integrals and the Fundamental Theorem of Calculus. (This course cannot be used to satisfy " +
                    "upper-level degree requirements by mathematics, statistics or natural science majors. Students completing " +
                    "this course may not enroll in MAC 2233.) ",
                    Major = "Computer Science",
                    InitialTermNumber = 5,
                    PreRequisites = new string[]
                    {
                        "MAC1147"
                    }

                },

                new Course
                {
                    CourseID = "SCI",
                    CourseName = "Select a Science Course for Science Majors",
                    CreditHours = 3,
                    Description = "Select a Science Course for Science Majors",
                    Major = "Computer Science",
                    InitialTermNumber = 5,
                    PreRequisites = new string[]
                    {

                    }

                },

                new Course
                {
                    CourseID = "IDC2000",
                    CourseName = "The Beauty and Joy of Computing",
                    CreditHours = 3,
                    Description = "(Recommended Free Elective) The course focuses on teaching students some " +
                    "of the Big Ideas of Computing such as abstraction, design, " +
                    "recursion, concurrency, simulations, and the limits of " +
                    "computation. The course also provides a historic perspective " +
                    "of Computing and where it is heading. Throughout the course, we " +
                    "will emphasis the relevance of Computing to the students, their " +
                    "future studies, their careers, and society. In this course students " +
                    "will learn Python as the programming language to deliver the " +
                    "concepts. Given that data is pervasive and the need to analyze data " +
                    "is in almost every discipline, learning Python that early will enable " +
                    "students to conduct data analysis which will be helpful for their studies " +
                    "at UNF and in their careers.",
                    Major = "Computer Science",
                    InitialTermNumber = 5,
                    PreRequisites = new string[]
                    {

                    }

                },

                new Course
                {
                    CourseID = "GEN",
                    CourseName = "Select a General Education Course",
                    CreditHours = 3,
                    Description = "Select a General Education Course",
                    Major = "Computer Science",
                    InitialTermNumber = 5,
                    PreRequisites = new string[]
                    {

                    }

                },

                new Course
                {
                    CourseID = "ENC1143",
                    CourseName = "Introduction to Rhetoric and Narrative",
                    CreditHours = 3,
                    Description = "This course introduces students to basic " +
                    "rhetorical features of a range of texts in different genres, " +
                    "with a focus on the elements of narrative. Students will learn " +
                    "how to read critically in preparation for writing critically on " +
                    "the course texts. Gordon Rule English credit. ",
                    Major = "Computer Science",
                    InitialTermNumber = 6,
                    PreRequisites = new string[]
                    {

                    }

                },

                new Course
                {
                    CourseID = "COP2220",
                    CourseName = "Computer Science I",
                    CreditHours = 3,
                    Description = "This course provides an introduction to the programming " +
                    "process. Topics in the course include types, operations, expressions, " +
                    "control flow, I/O, functions, program structure, software design techniques, " +
                    "and problem solving. Course concepts are reinforced with many programming " +
                    "projects throughout the term in the C programming language. ",
                    Major = "Computer Science",
                    InitialTermNumber = 6,
                    PreRequisites = new string[]
                    {

                    }

                },

                new Course
                {
                    CourseID = "SCI",
                    CourseName = "Select a Science Course for Science Majors",
                    CreditHours = 3,
                    Description = "Select a Science Course for Science Majors",
                    Major = "Computer Science",
                    InitialTermNumber = 6,
                    PreRequisites = new string[]
                    {

                    }

                },


                new Course
                {
                    CourseID = "MAC2312",
                    CourseName = "Calculus II",
                    CreditHours = 4,
                    Description = "This course continues the study of definite and " +
                    "indefinite integrals, and the Fundamental Theorem of Calculus begun " +
                    "in MAC 2311. The course presents various integration techniques and " +
                    "their applications, convergence of sequences and series, as well " +
                    "as power series and Taylor series of a function of one variable. (This " +
                    "course cannot be used to satisfy upper-level degree requirements by " +
                    "mathematics, statistics or natural science majors.) ",
                    Major = "Computer Science",
                    InitialTermNumber = 6,
                    PreRequisites = new string[]
                    {
                        "MAC2311",
                        "MAC2241"
                    }

                },

                new Course
                {
                    CourseID = "GEN",
                    CourseName = "Select a General Education Course",
                    CreditHours = 3,
                    Description = "Select a General Education Course",
                    Major = "Computer Science",
                    InitialTermNumber = 6,
                    PreRequisites = new string[]
                    {

                    }

                },

                new Course
                {
                    CourseID = "ENC1101",
                    CourseName = "Introduction to Rhetoric and Writing",
                    CreditHours = 3,
                    Description = "This course is an introduction to writing at the college level. Gordon Rule English credit.",
                    Major = "Computer Science",
                    InitialTermNumber = 7,
                    PreRequisites = new string[]
                    {

                    }

                },

                new Course
                {
                    CourseID = "MAC2311",
                    CourseName = "Calculus I",
                    CreditHours = 4,
                    Description = " This course examines the notions of limit, continuity and derivatives of functions " +
                    "of one variable. The course explores differentiation rules for algebraic, trigonometric, exponential " +
                    "and logarithmic functions. The course discusses applications of differential calculus, such as related " +
                    "rates problems, curve sketching, and optimization. The course also introduces students to definite and " +
                    "indefinite integrals and the Fundamental Theorem of Calculus. (This course cannot be used to satisfy " +
                    "upper-level degree requirements by mathematics, statistics or natural science majors. Students completing " +
                    "this course may not enroll in MAC 2233.) ",
                    Major = "Computer Science",
                    InitialTermNumber = 7,
                    PreRequisites = new string[]
                    {
                        "MAC1147"
                    }

                },

                new Course
                {
                    CourseID = "SCI",
                    CourseName = "Select a Science Course for Science Majors",
                    CreditHours = 3,
                    Description = "Select a Science Course for Science Majors",
                    Major = "Computer Science",
                    InitialTermNumber = 7,
                    PreRequisites = new string[]
                    {

                    }

                },

                new Course
                {
                    CourseID = "IDC2000",
                    CourseName = "The Beauty and Joy of Computing",
                    CreditHours = 3,
                    Description = "(Recommended Free Elective) The course focuses on teaching students some " +
                    "of the Big Ideas of Computing such as abstraction, design, " +
                    "recursion, concurrency, simulations, and the limits of " +
                    "computation. The course also provides a historic perspective " +
                    "of Computing and where it is heading. Throughout the course, we " +
                    "will emphasis the relevance of Computing to the students, their " +
                    "future studies, their careers, and society. In this course students " +
                    "will learn Python as the programming language to deliver the " +
                    "concepts. Given that data is pervasive and the need to analyze data " +
                    "is in almost every discipline, learning Python that early will enable " +
                    "students to conduct data analysis which will be helpful for their studies " +
                    "at UNF and in their careers.",
                    Major = "Computer Science",
                    InitialTermNumber = 7,
                    PreRequisites = new string[]
                    {

                    }

                },

                new Course
                {
                    CourseID = "GEN",
                    CourseName = "Select a General Education Course",
                    CreditHours = 3,
                    Description = "Select a General Education Course",
                    Major = "Computer Science",
                    InitialTermNumber = 7,
                    PreRequisites = new string[]
                    {

                    }

                },

                new Course
                {
                    CourseID = "ENC1143",
                    CourseName = "Introduction to Rhetoric and Narrative",
                    CreditHours = 3,
                    Description = "This course introduces students to basic " +
                    "rhetorical features of a range of texts in different genres, " +
                    "with a focus on the elements of narrative. Students will learn " +
                    "how to read critically in preparation for writing critically on " +
                    "the course texts. Gordon Rule English credit. ",
                    Major = "Computer Science",
                    InitialTermNumber = 8,
                    PreRequisites = new string[]
                    {

                    }

                },

                new Course
                {
                    CourseID = "COP2220",
                    CourseName = "Computer Science I",
                    CreditHours = 3,
                    Description = "This course provides an introduction to the programming " +
                    "process. Topics in the course include types, operations, expressions, " +
                    "control flow, I/O, functions, program structure, software design techniques, " +
                    "and problem solving. Course concepts are reinforced with many programming " +
                    "projects throughout the term in the C programming language. ",
                    Major = "Computer Science",
                    InitialTermNumber = 8,
                    PreRequisites = new string[]
                    {

                    }

                },

                new Course
                {
                    CourseID = "SCI",
                    CourseName = "Select a Science Course for Science Majors",
                    CreditHours = 3,
                    Description = "Select a Science Course for Science Majors",
                    Major = "Computer Science",
                    InitialTermNumber = 8,
                    PreRequisites = new string[]
                    {

                    }

                },


                new Course
                {
                    CourseID = "MAC2312",
                    CourseName = "Calculus II",
                    CreditHours = 4,
                    Description = "This course continues the study of definite and " +
                    "indefinite integrals, and the Fundamental Theorem of Calculus begun " +
                    "in MAC 2311. The course presents various integration techniques and " +
                    "their applications, convergence of sequences and series, as well " +
                    "as power series and Taylor series of a function of one variable. (This " +
                    "course cannot be used to satisfy upper-level degree requirements by " +
                    "mathematics, statistics or natural science majors.) ",
                    Major = "Computer Science",
                    InitialTermNumber = 8,
                    PreRequisites = new string[]
                    {
                        "MAC2311",
                        "MAC2241"
                    }

                },

                new Course
                {
                    CourseID = "GEN",
                    CourseName = "Select a General Education Course",
                    CreditHours = 3,
                    Description = "Select a General Education Course",
                    Major = "Computer Science",
                    InitialTermNumber = 8,
                    PreRequisites = new string[]
                    {

                    }

                }

                /*
                new Course
                {
                    CourseID = "MAC2311",
                    CourseName = "Calculus",
                    CreditHours = 4,
                    Description = "Calculus",
                    Major = "Computer Science",
                    InitialTermNumber = 1,
                    PreRequisites = new string[]
                    {
                        "MAC1147"
                    }

                },
                
                new Course
                {
                    CourseID = 99,
                    CourseName = "PreCalculus",
                    CreditHours = 3,
                    Description = "Topics will include linear and quadratic functions and their applications; " +
                    "systems of equations; inequalities, polynomials, exponentials, logarithms, trigonometric " +
                    "functions and their inverses and their graphs; trigonometric identities, and complex numbers.",
                    Major = "Computer Science",
                    PreRequisites = new int[]
                    {

                    },
                    CoRequisites = new int[]
                    {

                    }

                },

                new Course
                {
                    CourseID = 99,
                    CourseName = "PreCalculus",
                    CreditHours = 3,
                    Description = "Topics will include linear and quadratic functions and their applications; " +
                    "systems of equations; inequalities, polynomials, exponentials, logarithms, trigonometric " +
                    "functions and their inverses and their graphs; trigonometric identities, and complex numbers.",
                    Major = "Computer Science",
                    PreRequisites = new int[]
                    {

                    },
                    CoRequisites = new int[]
                    {

                    }

                },

                new Course
                {
                    CourseID = 99,
                    CourseName = "PreCalculus",
                    CreditHours = 3,
                    Description = "Topics will include linear and quadratic functions and their applications; " +
                    "systems of equations; inequalities, polynomials, exponentials, logarithms, trigonometric " +
                    "functions and their inverses and their graphs; trigonometric identities, and complex numbers.",
                    Major = "Computer Science",
                    PreRequisites = new int[]
                    {

                    },
                    CoRequisites = new int[]
                    {

                    }

                },


                new Course
                {
                    CourseID = 100,
                    CourseName = "Intro to Visual & Procedural Programming",
                    CreditHours = 3,
                    Description = "This course provides an introduction to the fundamentals of visual programming as " +
                    "well as procedural language structure and capabilities. Students learn about visual programming " +
                    "development, including problem definition, problem solving and algorithms, procedures, controls, " +
                    "arrays, structures, coding, visual interface design, testing, and debugging. ",
                    Major = "Computer Science",
                    PreRequisites = new int[]
                    {

                    },
                    CoRequisites = new int[]
                    {

                    }
                },

                new Course
                {
                    CourseID = 101,
                    CourseName = "Intro to Object Oriented Programming",
                    CreditHours = 3,
                    Description = "This course introduces the principles and practices of Object Oriented (OO) programming. " +
                    "Topics include user interface and problem data classes; class versus instance properties and " +
                    "methods; abstraction; encapsulation; inheritance and multiple inheritance; polymorphism; " +
                    "software design techniques; and problem solving. The concepts are utilized in numerous programming projects. ",
                    Major = "Computer Science",
                    PreRequisites = new int[]
                    {
                        100
                    },
                    CoRequisites = new int[]
                    {

                    }
                },

                new Course
                {
                    CourseID = 200,
                    CourseName = "Computational Structures",
                    CreditHours = 3,
                    Description = "This course covers the applications of finite mathematics to CIS. Topics include sets, " +
                    "relations, functions, and number theory; algebraic and combinatorial structures; applications of graphs; " +
                    "Boolean algebra and switching theory, and logic.",
                    Major = "Computer Science",
                    PreRequisites = new int[]
                    {
                        99
                    },
                    CoRequisites = new int[]
                    {

                    }
                },

                new Course
                {
                    CourseID = 201,
                    CourseName = "Web Systems Development",
                    CreditHours = 3,
                    Description = "Students learn about the influence of E-Business, local and global transaction processing, " +
                    "Internet, web design and development, and Electronic Data Interchange on information systems. After an " +
                    "introduction to the basic concepts of relational database systems, students will practice connectivity to a " +
                    "database to retrieve information. The course includes a design and implementation project involving a database " +
                    "in the Web environment.",
                    Major = "Computer Science",
                    PreRequisites = new int[]
                    {
                        100, 101
                    },
                    CoRequisites = new int[]
                    {
                        200
                    }
                }
                */
            };

            int? sumHours = null;

            foreach (Course c in courses)
            {
                if (sumHours == null)
                    sumHours = 0;
                sumHours += c.CreditHours;
            }
            ViewBag.TotalHours = sumHours;

            ViewBag.CourseDetails = new Course
                                    {
                                        CourseID = "",
                                        CourseName = "Select a course",
                                        CreditHours = null,
                                        Description = "Course description will display once it is selected."
                                    };

            
            var semesters = new Semester[]
            {
                new Semester
                {
                    SemesterID = "Fall 2018",
                    semesterCourses = courses
                },
                new Semester
                {
                    SemesterID = "Spring 2019",
                    semesterCourses = courses
                },
                new Semester
                {
                    SemesterID = "Summer 2019",
                    semesterCourses = courses
                },
                new Semester
                {
                    SemesterID = "Fall 2019",
                    semesterCourses = courses
                }
            };

            return View(courses);
        }

        public IActionResult AdminView()
        {
            var semesters = new Semester[]
            {
                new Semester
                {
                    SemesterID = "Fall 2018"
                },
                new Semester
                {
                    SemesterID = "Sprint 2019"
                },
                new Semester
                {
                    SemesterID = "Summer 2019"
                },
                new Semester
                {
                    SemesterID = "Fall 2019"
                },
                new Semester
                {
                    SemesterID = "Spring 2020"
                }

            };

            var courses = new Course[]
            {
                new Course
                {
                    CourseID = "ENC1101",
                    CourseName = "Introduction to Rhetoric and Writing",
                    CreditHours = 3,
                    Description = "This course is an introduction to writing at the college level. Gordon Rule English credit.",
                    Major = "Computer Science",
                    InitialTermNumber = 1,
                    courseDemand = 10,
                    PreRequisites = new string[]
                    {

                    }

                },

                new Course
                {
                    CourseID = "MAC2311",
                    CourseName = "Calculus I",
                    CreditHours = 4,
                    Description = " This course examines the notions of limit, continuity and derivatives of functions " +
                    "of one variable. The course explores differentiation rules for algebraic, trigonometric, exponential " +
                    "and logarithmic functions. The course discusses applications of differential calculus, such as related " +
                    "rates problems, curve sketching, and optimization. The course also introduces students to definite and " +
                    "indefinite integrals and the Fundamental Theorem of Calculus. (This course cannot be used to satisfy " +
                    "upper-level degree requirements by mathematics, statistics or natural science majors. Students completing " +
                    "this course may not enroll in MAC 2233.) ",
                    Major = "Computer Science",
                    InitialTermNumber = 1,
                    courseDemand = 20,
                    PreRequisites = new string[]
                    {
                        "MAC1147"
                    }

                },

                new Course
                {
                    CourseID = "SCI",
                    CourseName = "Select a Science Course for Science Majors",
                    CreditHours = 3,
                    Description = "Select a Science Course for Science Majors",
                    Major = "Computer Science",
                    InitialTermNumber = 1,
                    courseDemand = 30,
                    PreRequisites = new string[]
                    {

                    }

                },

                new Course
                {
                    CourseID = "IDC2000",
                    CourseName = "The Beauty and Joy of Computing",
                    CreditHours = 3,
                    Description = "(Recommended Free Elective) The course focuses on teaching students some " +
                    "of the Big Ideas of Computing such as abstraction, design, " +
                    "recursion, concurrency, simulations, and the limits of " +
                    "computation. The course also provides a historic perspective " +
                    "of Computing and where it is heading. Throughout the course, we " +
                    "will emphasis the relevance of Computing to the students, their " +
                    "future studies, their careers, and society. In this course students " +
                    "will learn Python as the programming language to deliver the " +
                    "concepts. Given that data is pervasive and the need to analyze data " +
                    "is in almost every discipline, learning Python that early will enable " +
                    "students to conduct data analysis which will be helpful for their studies " +
                    "at UNF and in their careers.",
                    Major = "Computer Science",
                    InitialTermNumber = 1,
                    courseDemand = 40,
                    PreRequisites = new string[]
                    {

                    }

                },

                new Course
                {
                    CourseID = "GEN",
                    CourseName = "Select a General Education Course",
                    CreditHours = 3,
                    Description = "Select a General Education Course",
                    Major = "Computer Science",
                    InitialTermNumber = 1,
                    courseDemand = 50,
                    PreRequisites = new string[]
                    {

                    }

                }
            };

            /*var courses = new Course[]
            {
                new Course
                {
                    CourseName = "A",
                    courseDemand = 50
                },
                new Course
                {
                    CourseName = "B",
                    courseDemand = 20
                },
                new Course
                {
                    CourseName = "C",
                    courseDemand = 10
                },
                new Course
                {
                    CourseName = "D",
                    courseDemand = 70
                }
            };
            */

            ViewBag.CourseList = courses;
            ViewBag.Semesters = semesters;

            return View();
        }

        //[HttpPost]
        public IActionResult CourseDetails (Course c)
        {
            ViewBag.CourseDetails = c;
            return View("AdvisorView");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [HttpPost]
        public IActionResult LoginAuthenticate(string uname, string psw)
        {
            string destination = "index";

            if (uname == "admin" && psw == "foo")
            {
                destination = "AdminView";
            }
            if (uname == "student" && psw == "bar")
            {
                destination = "CoursePlan";
            }

            return RedirectToAction(destination);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
