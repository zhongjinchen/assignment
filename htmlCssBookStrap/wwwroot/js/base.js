﻿//export { x };
//var x = 6;

//alert(x)
//console.log(x)      在控制台使用
//var add = 1;
//var walk = 1;
//while (((walk * 2) - 1) < 99) {
//    walk += 1;
//    add += (walk * 2) - 1;
//}
//alert(add);
//var student = ["飞哥", "老程", "老赵", "路炜", "小龙", "子祥", "文轩", "明辉", "王峰", "云帆", "小余"];
//student.unshift("头部");
//student.push("尾部")
//for (var i in student) {
//}
//alert(i);
//alert(stutent)
//var rand = new Array;
//for (var i = 0; i < 10; i++) {
//    rand[i] = Math.floor(Math.random() * 100);

//}
//alert(rand);
//var max = 0;
//for (var i = 0; i < 10; i++) {

//    if (max < rand[i]) {
//        max = rand[i]
//    }

//}
//alert(max);

//var arr = '"源栈"：飞哥小班教学，线下免费收看';
//arr = arr.replace('"源栈"：飞哥小班教学，线下', '“大神"小"班教学，线上');
//// arr= arr.replace(/"源栈"：飞哥小班教学，线下/i,'“大神"小"班教学，线上');
//alert(arr)

//var arry = ['why', 'gIT', 'vs2019', 'community', 'VERSION'];
//for (var i = 0; i < arry.length; i++) {
//    arry[i] = arry[i].toLowerCase();
//    //arry[i] = arry[i].replace(arry[i][0], arry[i][0].toUpperCase());    //把首字母替换成大写
//    arry[i] = arry[i][0].toUpperCase() + arry[i].substring(1);             //把首字母大写如何与后面的字母拼接起来
//}
//alert(arry);


//for (var i = 0; i < arry.length; i++) {
//    arry[i] = arry[i].substring(0, 6);
//}
//alert(arry);

//function findPrime(max) {
//    var array = new Array;
//    var arry = [];
//    for (var i = 2; i < max + 1; i++) {
//        if (i == 2) {
//            arry[i] = 2;
//        }
//        for (var x = 2; x < i; x++) {
//            if (i % x == 0) {
//                arry[i] = 0//undefined;
//                break;
//            }
//            if (i % x !== 0) {
//                arry[i] = i;
//            }
//        }
//    }
//    var y = 0;
//    for (var i = 2; i < max + 1; i++) {
//        if (arry[i] > 0) {

//            array[y] = arry[i];
//            y++;
//        }

//    }
//    return array;
//}
//alert(findPrime(100));

//function getMaxNumber() {
//    var array = [];
//    var x = 0;
//    for (var i = 0; i < arguments.length; i++) {
//        if (typeof arguments[i] == "number") {
//            array[x] = arguments[i];
//            x++;
//        }
//    }
//    var max = 0;
//    for (var i = 0; i < arguments.length; i++) {
//        if (max < array[i]) {
//            max = array[i];
//        }
//    }
//    return max;
//}
//alert(getMaxNumber(1, "sg", -2, 5, true, 9999.9999))
////function getRandomArray(length, max) {
////    var array = [];
////    for (var i = 0; i < length; i++) {
////        array[i] = Math.floor(Math.random() * max);
////    }
////    return (array);
////}
////alert(getRandomArray(10,100))
//var array = [2, 1, 3, "3", "3", "3", "3", 3, 3, 3, 5, 7, 4, "11", 5, "a", 8, "1", "b", "b", 9, "a", 0, 2, 4, 6,];
//array.sort();
//for (var i = 0; i < array.length - 1; i++) {
//    if (array[i] === array[i + 1] || array[i] === array[i + 2]) {
//        //delete array[i];    //数组的长度不变，删除的元素变为undefined
//        array.splice(i, 1)
//        //数组长度缩短，后一位元素前移
//        --i;
//    }
//}
//for (var x = 0; x < array.length - 1; x++) {
//    if (array[x] === array[x + 1] || array[x] === array[x + 2]) {
//        // delete array[x];    //数组的长度不变，删除的元素变为undefined
//        array.splice(x, 1)     //数组长度缩短，后一位元素前移
//        i--;
//    }
//}
//alert(array);
//function Money(people, discont) {
//    var money = 19.8 * (people - 1) * discont;
//    return money;
//}
//alert(Money(6, 0.3));

////颠倒位置
//var array = "hello,yuanzhan";
//var yz = array.split("");
//for (var i = 0; i < Math.floor(yz.length / 2); i++) {
//    x = array[i];
//    yz[i] = yz[yz.length - 1 - i];
//    yz[yz.length - 1 - i] = x;
//}
//var star = yz[0];
//for (var t = 0; t < yz.length - 1; t++) {
//    star = star + yz[t + 1];
//}
////console.log(star);
//alert(star);
////统计单词的数量
//var text = "There are two ways to create a RegExp object: a literal notation and a constructor.To indicate strings, the parameters to the literal notation do not use quotation marks while the parameters to the constructor function do use quotation - marks.So the following expressions create the same regular expression";
//text = text.replace(",", "");
//text = text.replace(".", " ");
//text = text.replace("-", "");
//text = text.replace(":", "");
//var are = text.split(" ");
//alert(are.length);

//yz.fei.get986()中嵌入不带参数的函数has9() / has8() / has6(), 并调用上述函数，找出10000以内有多少个数字包含：9或者8或者6。
//var yz = {}
//yz.fei = {}
//yz.fei.get986 = function (max) {
//    function has9() {
//        var amount1 = 0;

//        for (var i = 0; i < max + 1; i++) {
//            if ((i - 9) % 10 === 0) {
//                amount1++;
//            }
//        }
//        return amount1;
//    }

//    function has8() {
//        var amount2 = 0;
//        for (var i = 0; i < max + 1; i++) {
//            if ((i - 8) % 10 === 0) {
//                amount2++;
//            }
//        }
//        return amount2;
//    }


//    function has6() {
//        var amount3 = 0;
//        for (var i = 0; i < max + 1; i++) {
//            if ((i - 6) % 10 === 0) {
//                amount3++;
//            }
//        }
//        return amount3;
//    }
//    return has9();
//    //has8();
//    //has6();
//}
//console.log(yz.fei.get986(10000));