//function student() {
//    var name="xiaolong", age=20, female="ture";
//    return function () {
//        return name+ age+ female;
//    }
//}
//var classmate = student();

//console.log(classmate());

//function foo(x) {
//    var tmp = 3;
//    return function (y) {
//        x = x ? x + 1 : 1;
//        console.log(x + y + tmp);
//    }
//}

//var bar = foo(-1);
//bar(10);

function buildList(list) {
    var result = [];
    for (var i = 0; i < list.length; i++) {
        result.push(function () {
            console.log('item' + i + ': ' + list[i])
        });
    }
    return result;
}

(function () {
    var fnlist = buildList([1, 2, 3]);
    for (var i = 0; i < fnlist.length; i++) {
        fnlist[i]();
    }
})();