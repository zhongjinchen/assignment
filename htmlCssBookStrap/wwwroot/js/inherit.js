//class person {
//    constructor(sname) {
//        this.sname = sname;
//    }
//    hello() {
//        console.log(`${sname}，你好！`);
//    }
//}
//class student extends person {
//    constructor(sname, sId) {
//         super(sname);
//        this.sId = sId;
//    }
//    poetry() {
//        super.hello();
//        console.log("清风徐来，水波不兴");
//    }
//}
//var fg = new student("fg");

//class MajorCourse {
//    Exam(student) {
//        end();
//        student.score = 88;
//    }
//}

//new MajorCourse().Exam(new Student());

////----作业
//1,在封装作业的基础上，为Course添加两个子类：主修课（MajorCourse）和辅修课（ElectiveCourse)






////说明：为什么子类可以继承父类的实例和静态方法？
//class Course {
//    constructor(name, start, students) {
//        this.name = name;
//        this.startDate = start;
//        this.endDate;
//        this.students = students;

//    }

//    //6,给Course声明一个静态的GetStudentsByName(name) ，
//    //能根据不同的name返回不同的整数值（参加该course的学生数量）
//    static GetStudentsByName(sname) {
//        console.log(`${sname.name}课程，有${sname.students.length}同学学习`)
//    }
//    end() {
//        console.log("课程结束");
//    }
//    begin() {
//        console.log(`${this.sname}于${this.startDate}开课，共有${this.students.length}名同学（${this.students}）报名。`);

//    }

//}

////2,声明一个Student类，包含name和score两个属性，让Course的Students包含的是Student的对象
//class Student {
//    constructor(name, score) {

//        this.name = name;
//        this.score = score;
//    }

//}
//var wf = new Student("wangfen", 80);

////var csharp = new Course("csharp", "2019,3,2", StudentObject)

////3,主修课需要参加考试，所以有一个Exam(student)方法；辅修课只需要测评，所以有一个方法Assess(student)
//class MajorCourse extends Course {
//    constructor(name, start, students) {
//        super(name, start, students);
//    }
//    Exam(student) {
//        console.log(`${student.name}考试`);
//        super.end();
//        student.score = Math.floor(Math.random() * (100 - 50)) + 50;

//        //7,在子类调用GetStudentsByName(name)
//        Course.GetStudentsByName(wangping);
//    }
//}
//var wangping = new MajorCourse("SQL", "2019,6,7", ["wenxuan", "laochen"]);

//let wp = new Student("wangping");
//wangping.Exam(wp);

////4,声明一个MajorCourse的实例，运行它的Exam(student)方法，结束课程（使用end()方法）
////，并给该student的score赋值为50 - 100的随机整数
////var xiaolong = new MajorCourse("SQL", "2019,1,1", ["小龙", "文轩"]);
////xiaolong.Exam("小龙");


////5,声明一个ElectiveCourse的实例，运行它的Exam(student)方法，
////结束课程（使用end()方法），给该student的score赋值为ABCDE中的一个随机值
//class ElectiveCourse extends Course {
//    constructor(name, start, students) {
//        super(name, start, students);
   
//    }
//    Assess(student) {
//        console.log(`${student.name}测评`);
//        super.end();
     
//        var alphabet = "ABCDE";
//        var rand = Math.floor(Math.random() * (alphabet.length - 1));
//        student.score = alphabet.substring(rand, rand + 1);
//    }
//}
//var wenxuan = new ElectiveCourse("SQL", "2019,6,7", ["wenxuan", "laochen"]);

//let wx = new Student("wenxuan");
//wenxuan.Assess(wx);