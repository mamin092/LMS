module App {

    class HomeController {

        constructor() {
            console.log("I am in home class");
            this.now = new Date().toString();
        }
        now: string;

    }

    angular.module("app").controller("HomeController", (HomeController) as any);

}