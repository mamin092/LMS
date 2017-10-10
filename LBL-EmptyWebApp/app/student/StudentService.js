var App;
(function (App) {
    var StudentService = /** @class */ (function () {
        function StudentService() {
            this.students = [];
            console.info('initiating student service', this.students);
        }
        StudentService.$inject = [];
        return StudentService;
    }());
    App.StudentService = StudentService;
    angular.module('app').service("StudentService", StudentService);
})(App || (App = {}));
//# sourceMappingURL=StudentService.js.map