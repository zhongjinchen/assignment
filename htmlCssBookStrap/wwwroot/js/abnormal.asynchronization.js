//作业：
//使用setTimeout创建以下三个异步函数，分别使用普通callback方式和Promise方式，完成如下逻辑：
//getPassword(name) ：通过用户名获得他 / 她的密码
//login() ：如果密码正确，返回用户Id；否则，报一个异常
//getRecord() ：根据用户Id，返回该用户“打地鼠”游戏的最高记录
//捕获抛出的异常，输出（console.log）异常信息

function getPassword(name) {
    return 3333;
}


function login(getPassword, name, Id) {
    if (getPassword(name) === 3333) {
        return Id;
    }
    else {
        throw ("异常");
    }
}

function getRecord(login, getPassword, name, Id) {
    if (login(getPassword, name, Id)) {
        return "最高纪录";
    }

}
try {
    getRecord(login, getPassword, "ab", 2);
}
catch (e) {
    console.log(e);
}
finally {
    console.log("管你有没有异常")
}


console.log("有没有走到");


