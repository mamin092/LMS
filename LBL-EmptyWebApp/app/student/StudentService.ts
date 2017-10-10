module App {
    export class StudentService {

        students: Student[];

        static $inject = [];
        constructor() {
            this.students = [];
            console.info('initiating student service', this.students);
        }
    }

    angular.module('app').service("StudentService", StudentService);
}