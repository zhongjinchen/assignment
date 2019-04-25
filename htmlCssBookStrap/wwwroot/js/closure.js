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

//////var bar = foo(-1);
//var bar = foo(0);
////var bar = foo(1);
//bar(10);

//function buildList(list) {
//    var result = [];
//    for (let i = 0; i < list.length; i++) {
//        result.push(function () {
//            console.log('item' + i + ': ' + list[i])
//        });
//    }
//    return result;
//}

//(function () {
//    var fnlist = buildList([1, 2, 3]);
//    for (var i = 0; i < fnlist.length; i++) {
//        fnlist[i]();
//     }
//})();

//function buildList2(list2) {
//    var result2 = [];
//    let i;
//    for ( i = 0; i < list2.length; i++) {
//        result2.push(function () {
//            console.log('item' + i + ': ' + list2[i])
//        });
//    }
//    return result2;
//}

//(function () {
//    var fnlist2 = buildList2([1, 2, 3]);
//    for (var i = 0; i < fnlist2.length; i++) {
//        fnlist2[i]();
//    }
//})();