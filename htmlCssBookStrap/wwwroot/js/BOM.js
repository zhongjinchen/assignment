//////使用setTimeout()实现每隔1秒钟依次显示：第n周，源栈同学random人 
/*
 * 1.每次弹出窗口间隔1秒
 * 2.从第1周开始每次递增一周
 * 3.源栈同学数量random每次弹出数量随机
 * 4.
 * 
 * 
*/
//function classmatess() {
//    let n = 1;

//    function classmates() {

//        let random = Math.floor(Math.random() * 100);
//        alert(`第${n}周，源栈同学${random}人 `);
//        setTimeout(classmates, 1000); 
//        n++;
//    } 
//    classmates();
//};
//classmatess();

//完成猜数字的游戏：
//弹出游戏玩法说明，等待用户点击“确认”，开始游戏；
//浏览器生成一个不大于1000的随机正整数；
//用户输入猜测；
//如果用户没有猜对，浏览器比较后告知结果：“大了”或者“小了”。如果用户：
//只用了不到6次就猜到，弹出：碉堡了！
//只用了不到8次就猜到，弹出：666！
//用了8 - 10次猜到，弹出：猜到了。
//用了10次都还没猜对，弹出：^ (*￣(oo) ￣)^ 
/*
 * 
 * 
 * 
 * 
 * /
(function guess() {
    alert("游戏说明");
    var random = Math.floor(Math.random() * 1000);
    var i = 0;
    (function compare() {
        var ipt = prompt();
        i++
        if (ipt === random) {
            if (i < 6) {
                alert("碉堡了！");
                compare();
            }
            if (i >= 6 && i < 8) {
                alert("666");
                compare()
            }
            if (i >= 8 && i <= 10) {
                alert("猜到了。");
                compare()
            }
        }
        if (typeof ipt !== "number") {
            alert("反手就是一个巴掌");
            compare();
        }
        else {
            if (i <10 && ipt < random) {
                alert("猜小了")
                compare()
            }
            if (i < 10 && ipt > random) {
                alert("猜大了")
                compare()
            }
            else {
                alert("^ (*￣(oo) ￣) ^");
            }
        }
    })();
})();


//(function () {
//    var n = 1;
//    (function fgclassmates() {
//        let random = Math.floor(Math.random() * 100);
//        alert(`第${n}周，源栈同学${random}人 `);

//        setTimeout(fgclassmates, 1000);
//        n++;
//    })()
//})();



