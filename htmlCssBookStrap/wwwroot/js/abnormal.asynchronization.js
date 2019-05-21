////作业：
////使用setTimeout创建以下三个异步函数，分别使用普通callback方式和Promise方式，完成如下逻辑：
////getPassword(name) ：通过用户名获得他 / 她的密码
////login() ：如果密码正确，返回用户Id；否则，报一个异常
////getRecord() ：根据用户Id，返回该用户“打地鼠”游戏的最高记录
////捕获抛出的异常，输出（console.log）异常信息

function getPassword(callback,name) {
    setTimeout(function (name) {
        if (name) {
            var pass = 333;
            callback(pass);
        }
    }, 300);
}

function login(callback) {
    setTimeout(function () {
        getPassword(callback);    
    }, 300);
}

login((pass) => {
    if (pass === 333) {
        var Id = 1;
        console.log(Id);
        console.log('record:500');

    }
    else {
        try {
            throw ("异常");
        }
        catch (e) {
            console.log(e);
        }
        finally {
            console.log("管你有没有异常")
        }

    }
})

//function getRecord(callback) {
//    setTimeout(() => { login(callback) }, 1000);
//}

//getRecord((id) => {
//    if (id === 1) {
//        console.log("最高纪录");

//        return "最高纪录";
//    }
//})
//let name = "222";
//new Promise((resolve, reject) => {
//    setTimeout((name) => {
//        if (name) {
//            var pass = 333;

//        }
//        resolve(pass);
//    }, 500)
//}, name)
//    .then((result) => {
//        return new Promise((resolve, reject) => {
//            setTimeout(() => {
//                if (pass === 333) {
//                    Id = 1;
//                    console.log(Id);
//                    resolve(pass);
//                }
//            }, 500)
//        })
//    }).then((result) => {
//        return new Promise((resolve, reject) => {
//            setTimeout(() => {
//                resolve(Id);
//            }, 500)

//        })
//    }).then((result) => {
//        if (pass === 333) {
//            Id = 1;
//            console.log(Id);
          
//        }})



        //new Promise((resolve, reject) => {
        //    setTimeout(() => {
        //        console.log('第 1 次resolve');
        //        resolve(false);
        //    }, 500)
        //}).then((result) => {
        //    return new Promise((resolve, reject) => {
        //        setTimeout(() => {
        //            console.log('第 2 次resolve');
        //            resolve(result);
        //        }, 500)
        //    });
        //}).then((result) => {
        //    if (result) {
        //        console.log('oh yeah!');
        //    } else {
        //        console.log('what happen?')
        //    }
        //})






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




