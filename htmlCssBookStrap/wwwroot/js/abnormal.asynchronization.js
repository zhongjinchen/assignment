////作业：
////使用setTimeout创建以下三个异步函数，分别使用普通callback方式和Promise方式，完成如下逻辑：
////getPassword(name) ：通过用户名获得他 / 她的密码
////login() ：如果密码正确，返回用户Id；否则，报一个异常
////getRecord() ：根据用户Id，返回该用户“打地鼠”游戏的最高记录
////捕获抛出的异常，输出（console.log）异常信息

function getPassword(number) {
    setTimeout(function () {
        var pass = 3333;
        number(pass);
    }, 300);
}


function login(number) {
 
    setTimeout(function () {
        getPassword(number);
        if (number === 3333) {
            return Id;
        }
        else {
            throw ("异常");
        }
    }, 300);


}

login(function (pass) {
    return pass;
})

//function getRecord(id) {

//    setTimeout(function () {
//        if (id) {
//            return "最高纪录";
//        }
//    }, 300);
//}


//try {
//    login(getPassword);
//    getRecord(login);
//}
//catch (e) {
//    console.log(e);
//}
//finally {
//    console.log("管你有没有异常")
//}



//function step1(result) {
//    setTimeout(() => {
//        var a = true;
//        result(a);
//    }, 300);
//}

//function step2(result) {

//    setTimeout(() => { step1(result); }, 300);
//}

//function step3(result) {

//    setTimeout(() => { step2(result); }, 300);
//}

//function step4(result) {
//    step3(result);

//}

//step4(function (a) {
//    if (a) {
//        console.log('oh yeah!');
//    } else {
//        console.log('what happen?')
//    }
//});




