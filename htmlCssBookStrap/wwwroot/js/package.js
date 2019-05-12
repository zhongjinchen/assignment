////1,用class声明一个课程（Course），包含属性：name，startDate，
////endDate，students，以及方法：begin()和end()

//class Course {
//    constructor(name, start, students) {
//        this.name = name;
//        this.startDate = start;
//        this.endDate;
//        this.students = students;
//        this.end = function () {
//            console.log("富可敌国");
//        }
//    }
//    begin() {
//        console.log("穷困潦倒");
//    }
//    set EndDate(endDate) {
//        var gap = Date.parse(this.endDate) - Date.parse(this.startDate);
//        var oneYear = 365 * 24 * 60 * 60 * 1000;
//        if (gap > 0 && gap < oneYear) {
//            return this.endDate;
//        }
//        else {
//            console.log("抛出异常");
//        }

//    }
//    get EndDate() {
//        this.EndDate = endDate;
//    }
//}


////////2,生成两个课程对象：JavaScript和SQL
////var javascript = new Course();
//var sql = new Course("sql","2019,1,1",["xl","wp","wf"]);

////3,调用对象的begin()和end()方法，可以在控制台输出开课信息，
////如：JavaScript于2019年5月5日开课，共有5名同学（两开花、王枫、王平、采铃、老程）报名。
//javascript.begin();
//javascript.end();
//sql.begin();
//sql.end();

////4,不修改class，动态的改变begin()方法，使其能影响所有Course对象
//Object.getPrototypeOf.sql.begin = function () { console.log("神须大成"); }

////5,让end()方法为各自对象“自有”，其他对象无法修改
//javascript.end = function () {
//    console.log("JavaScript于2019年5月5日开课，共有5名同学（两开花、王枫、王平、采铃、老程）报名。"); 
//}
//sql.end()

//6,在Course中使用getter和setter包装endDate，保证endDate不会小于startDate，也不会比startDate多出365天
//7,判断并证明以下说法：
//class Course {
//    constructor(sname) {
//        this.sname = sname;
//    }
//    Age(age) {
//        console.log(age);
//    }
//}
//var student = new Course();

//ES里的class其实就是一个function
//typeof Course==="function"

//constructor总是返回class的实例

//当new了一个class之后，class里声明的方法就会被copy到新生成的实例对象上
//是引用而不是复制
//a.prototype.Age = function () { console.log("也太爽了吧！") }
//b.Age();

//JavaScript里面，类就是对象，对象也是类
//a.prototype                     //类的原型就是一个对象
//b.__proto__                    //对象的原型包含构造函数和方法     ？？？

//只有Function才有prototype
//error
//a.prototype;

//Javascript是动态类型语言，所以对象的类型是可以随意更改的 




////---笔记
//Object.assign(Course.prototype, { score:function() { console.log("成绩极其优秀") }});

////获取器
//class Course {
//    constructor() {
//        this.name = "laozhao";

//        this.end = function () {
//            console.log("富可敌国");
//        }
//    }
//    begin() {
//        console.log("穷困潦倒");
//    }
//    get Name() {
//        return this.name.toUpperCase();
//    }
//    //set Name(value) {
//    //    name = value;
//    //}
//}
//var a = new Course();
//a.Name = "lz";

//Object.getPrototypeOf(a).begin;