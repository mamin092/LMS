module App {
    export class Student {
        name: string;
        phone: string;

        getInfo(): string {
            return this.name + " " + this.phone;
        }
    }

    class StudentController {

        student: Student;
        information: string;
        studentService: StudentService;

        static $inject = ["StudentService"];
        constructor(studentService: StudentService) {
            this.student = new Student();
            this.studentService = studentService;
            console.log("I am in student controller");
        }

        display(): void {
            this.information = this.student.getInfo();
        }

        add(): void {
            this.studentService.students.push(this.student);
            this.student = new Student();
        }

        reset(): void {
            this.student = new Student();
        }
    }

    angular.module('app').controller("StudentController", (StudentController) as any);


    class StudentsController {

        students: Student[];
        studentService: StudentService;

        static $inject = ["StudentService"];
        constructor(studentService: StudentService) {
            this.studentService = studentService;
            this.students = this.studentService.students;
            console.log("I am in students controller", this.students);
        }
    }

    angular.module('app').controller("StudentsController", (StudentsController) as any);
}