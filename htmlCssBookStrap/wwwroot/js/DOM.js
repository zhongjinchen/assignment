
//模拟求助首页，并：
//统计有多少个悬赏大于1的求助 
//function Many() {
//    var rewardmany = document.getElementsByClassName("rew");
//    document.getElementsByClassName("wait")[0]
//    var x = 0;
//    for (let i = 0; i < rewardmany.length; i++) {
//        var reward = rewardmany[i].childNodes[0];
//        if (reward.nodeValue > 1) {
//            x++;
//        }
//    }
//    return x;
//}
 //console.log(Many());

//将状态为“协助中”的求助背景改成灰黑色 
//(function () {
//    var assist = document.getElementsByClassName("wait");
//    var x = 1;
//    for (var i = 0; i < assist.length; i++) {
//        var isassist = assist[i].childNodes[0].nodeValue;
//        if (isassist.trim() === "协助中") {
//            var backcolor = document.getElementsByTagName("main")[0].children[x];
//            // backcolor.setAttribute("style", "background-color:black");
//            backcolor.style.backgroundColor = "blue";

//        }
//        x += 2;
//    }
//})();


//写一个函数，可以统计某个求助使用了多少关键字 
//function kayCount(x){
//    var count = document.getElementsByClassName(x)[0].children[4].children.length;
//    console.log(count);
//}


//如果总结数为0，将其从DOM树中删除
//(function del() {
//    var arr = document.getElementsByClassName("status").length;
//    for (var i = 0; i < arr; i++) {
//        if (parseInt(document.getElementsByClassName("status")[i].children[2].childNodes[0].nodeValue.substring(3, 4)) === 0) {
//            document.getElementsByClassName("status")[i].parentElement.remove();
//        }
//    }
//})();
//kayCount("b");

//参考用户注册页面，创建一下函数： 
//显示密码的长度
//document.getElementsByClassName("framesecond")[0].children[5].value.length;

//如果密码和确认密码不一致，弹出提示
//var iput = document.getElementsByClassName("framesecond")[0].getElementsByTagName("input");
//iput[4].onclick = function prompt() {
//    if (iput[1].value !== iput[2].value) {
//        alert("密码和验证密码不一致");
//    }
//}

//----另一种更加简便的写法（但是必须在body之后使用）
//document.getElementsByClassName("framesecond")[0].children[16].onclick = function prompt() {
//    var pass = document.getElementsByClassName("framesecond")[0].children[5].value;
//    var ispass = document.getElementsByClassName("framesecond")[0].children[9].value;
//    if (pass !== ispass) {
//        alert("密码和验证密码不一致");
//    }
//}
//---还有一种，优点：可用于复杂的代码，可以绑定（addEventListener）也可以取消绑定（remove）
//document.getElementsByClassName("framesecond")[0].children[16].addEventListener("click",prompt)

//参考用户资料页面，控制台显示出用户的：性别 / 出生年月 / 关注（关键字）/ 自我介
//document.getElementsByClassName("checkbox-inline")[0].children[0].checked;
//document.getElementsByClassName("checkbox-inline")[1].children[0].checked;

//document.getElementsByTagName("select")[1].selectedIndex;
//document.getElementsByTagName("select")[1].children[9].innerText;
//document.getElementsByTagName("select")[0].selectedIndex;
//document.getElementsByTagName("select")[0].children[0].innerText;

//document.getElementsByClassName("badge badge-has-used")[0].innerText;
//document.getElementsByClassName("badge badge-has-used")[1].innerText;

//document.getElementsByName("SelfDescription")[0].value

//实现铃铛（没有学bootstrap的同学用文字代替）闪烁效果
//function smallbell () {
//    var i = true;
//    function twinkle() {

//        if (i === true) {
//            document.getElementsByTagName("span")[1].style.color = "black";
//            i = false;
//        }
//        else {
//            document.getElementsByTagName("span")[1].style.color = "gray";
//            i = true;
//        }
          
//    }
//    setInterval(twinkle, 300);
//}
    //smallbell();





//----删除
//remove()                      删除自己
//removeChild(document.getElementsByTagName("main")[0].children[1])
//removeAttribute("href")       删除属性

//----修改
//document.getElementsByTagName("main")[0].children[1].children[2].childNodes[0]
//.replaceWith("十步杀一人，千里不留行")     跟替换差不多

//document.getElementsByTagName("main")[0].children[1].children[2]    ----children和childNodes都可以替换
//.replaceWith(document.getElementsByTagName("main")[0].children[1].children[1])

//replaceChild(newNode, oldNode)
//document.getElementsByTagName("main")[0]replaceChild
//(document.getElementsByTagName("main")[0].children[1], document.getElementsByTagName("main")[0].children[2])

//----添加 prepend(添加到第一个孩子)/appendChild(添加到最后一个孩子)
//var qoute = document.createElement("qoute");
//qoute.setAttribute("class", "lucky-stack");
//qoute.style.cssFloat = "left";
//var text = document.createTextNode("事了拂衣去");
//qoute.appendChild(text);
//document.getElementsByTagName("main")[0].appendChild(qoute);

//尺寸
//function show() {
//    var body = document.getElementsByTagName("body");
//    body.scrollWidth;
//    body.offsetWidth;
//    body.clientWidth;

//    body.scrollLeft / Top;               //鼠标移动的宽度
//    body.clientLeft / Top;                //左边边框的宽度
//}

//事件
//window.onload = function () {
//                            //加载事件
//}                                  
//window.onbeforeunload = function () {
//    return confirm("你确定要离开吗？");       //关闭页面事件
//}                

//window.addEventListener('beforeunload', function (e) {
//    // Cancel the event
//    e.preventDefault();
//    // Chrome requires returnValue to be set
//    e.returnValue = '';
//})  

//document.getElementsByClassName("framefirst")[0].children[2].onmouseover = function () { alert("sddd") }
//document.getElementsByClassName("framefirst")[0].children[2].onmouseout = function () { alert("离开") }  

//resizeBy / resizeTo          ////页面缩放

//scroll

//document.getElementsByClassName("framefirst")[0].children[2].onfocus = function () { alert("focus") }
//document.getElementsByClassName("framefirst")[0].children[2].onblur = function () { alert("blur") }






