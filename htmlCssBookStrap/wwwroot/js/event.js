﻿//作业
//参考求助首页侧边栏关键字，实现：当鼠标移动到关键字上，显示关键字被使用次数
//function many() {
//    var a = document.getElementsByClassName("keywords")[0].getElementsByTagName("a")
//    for (let i = 2; i < a.length; i++) {
//        function count() {
//            var show = document.getElementsByClassName("keywords")[0].children[i].getAttribute("data-used");
//            console.log(show);
//        }
//       a.onmouseover = count;

//    }
//}
//many();

//function many() {
//    var a = document.getElementsByClassName("keywords")[0].getElementsByTagName("a")
//    for (var i = 0; i < a.length; i++) {
//        function count() {
//            var show = this.getAttribute("data-used");
//            console.log(show);
//        }
//        a[i].onmouseover = count;

//    }
//}

//参考文章的全系列阅读功能，当滚动到页面底部时，将页面现有内容粘贴到页面底部，
//直到5次过后，在页面底部显示：已经没有更多内容了 
//{
//let scrolHeight1 = document.documentElement.scrollTop;
//(function () {
//    var a = document.body;

//    var h = 0;
//    document.body.onscroll = function () {
//        let height = document.documentElement.clientHeight;
//        let contentHeight = document.documentElement.offsetHeight;
//        let scrolHeight = document.documentElement.scrollTop;
//        if (contentHeight - height === scrolHeight && h < 5) {
//            h++;
//            let b = a.cloneNode(true);
//            document.getElementsByTagName("html")[0].appendChild(b);
//        }
//    }
//})();
//}




////参考消息页面：完成勾选全选功能
//function Tick() {
//    var inpu = document.getElementsByClassName("select")[0].getElementsByTagName("input");
//    inpu[0].onclick = function () {
//        if (inpu[0].checked) {
//            for (var i = 1; i < inpu.length; i++) {
//                inpu[i].checked = true;
//            }
//        }
//        else {
//            for (var i = 1; i < inpu.length; i++) {
//                inpu[i].checked = false;
//            }
//        }
//    }
//}
//Tick();

//参考注册页面：
//提交时，如果用户名重复（已有用户名用数组保存），阻止form提交，提示“用户名重复”。
//重新输入用户名，一旦输入用户名部分没有重复，“用户名重复”的提示消失 
//当用户名或密码等有值时，关闭页面前弹出确认框 
//(function () {
//    var arr = ["xiaolong", "laozhao", "wenxuan"];
//    var nam = document.getElementsByClassName("framesecond")[0].getElementsByTagName("input");

//    nam[4].onsubmit = function isrepeat() {


//        for (var i = 0; i < arr.length; i++) {
//            if (nam[0].value === arr[i]) {
//                event.preventDefault();
//               // return false;

//                var div = document.createElement("div");
//                div.style.color = "red";
//                var text = document.createTextNode("用户名重复");
//                div.appendChild(text);
//                document.getElementsByClassName("framesecond")[0].children[0].appendChild(div);
//            }
//        }
//    }

//    nam[0].onkeydown = function () {
//        var x = 0;
//        var add = document.getElementsByClassName("framesecond")[0].children[0].getElementsByTagName("div")[0];
//        for (var i = 0; i < arr.length; i++) {
//            if (nam[0].value !== arr[i]) {
//                x++;
//                if (x === arr.length && add !== undefined) {
//                    add.remove();
//                }
//            }
//            else {

//            }
//        }
//    }
//    window.onbeforeunload = function() {
//        var ipu = document.getElementsByTagName("input");
//        var x = 0;
//        for (var i = 0; i < ipu.length; i++) {
//            if (ipu[i].value !== "") {
//                x++;
//                if (x > 0) {
//                    return confirm("确认要关闭吗？");
//                }
//            }
//        }

//    }

//})();

//参考求助首页侧边栏“免费广告发布”弹出Modal，实现（不需要弹出Modal）：
//根据下拉列表选中项，填充“文字内容”和“链接”文本框
//勾选修改的checkbox，实现“文字内容”和“链接”文本框的禁用和启用

//(function () {
//    var op = document.getElementsByTagName("option");
//    var ipt = document.getElementsByTagName("section")[0].getElementsByTagName("input");
//    for (var i = 0; i < op.length; i++) {
//        op[i].onclick = function () {

//            if (this.innerText !== op[0].innerText) {
//                ipt[2].value = "不以物喜不以己悲";
//                ipt[3].value = "http://localhost:54018/problem";
//                if (ipt[0].checked === false) {
//                    ipt[2].readOnly = "readonly";
//                    ipt[3].readOnly = "readonly";
//                }

//            }
//            else if (this.innerText === op[0].innerText) {
//                ipt[2].value = "";
//                ipt[3].value = "";
//            }

//        }
//    }
//    ipt[0].onclick = function () {
//        if (ipt[0].checked === false) {
//            ipt[2].readOnly = "readonly";
//            ipt[3].readOnly = "readonly";
//        }
//        else {
//            ipt[2].removeAttribute("readOnly");
//            ipt[3].removeAttribute("readOnly");
//        }
//    }
//})();

////参考发布求助，实现其关键字功能：
////没有选择一级关键字，不能选择二级关键字
////选择一级关键字后，二级关键字只能是一级关键字下的子集
////一级关键字和二级关键字被选中后，会显示在下拉列表上方
////自定义关键字输入完成后（按空格键），输入的关键字显示在下拉列表上方
////后输入的关键字显示在前面 
//var buton = document.querySelectorAll("[zjc-group-btn]");
//document.querySelectorAll("[zjc-btn-default]")[0].onclick = function () {
//    if (buton[0].getAttribute("class").toString() === "input-group-btn") {
//        buton[0].setAttribute("class", "input-group-btn open");
//    }
//    else {
//        buton[0].setAttribute("class", "input-group-btn");
//    }
//}
//var li = document.querySelectorAll("[zjc-keyword-dropdownlist]");


////document.querySelectorAll("[zjc-keyword-dropdownlist]")[1].children[0].replaceWith(document.querySelectorAll("[zjc-keyword-dropdownlist]")[0].children[0])

//function add(identifier, sname) {
//    var a = document.createElement("a");
//    var li = document.createElement("li");
//    //var ul = document.createElement("ul");
//    a.setAttribute("data-keyword-id", identifier);
//    var text = document.createTextNode(sname);
//    //ul.setAttribute("class", "dropdown-menu");
//    //ul.setAttribute("zjc-keyword-dropdownlist", "2");
//    a.appendChild(text);
//    li.appendChild(a);
//    document.querySelectorAll("[zjc-keyword-dropdownlist]")[1].appendChild(li);
//    //ul.appendChild(li);
//    //document.querySelectorAll("[zjc-group-btn]")[1].appendChild(ul);
//}
//function addKeyWord(s,i) {
//    var div = document.createElement("div");
//    div.style.cssFloat = "left";
//    document.getElementsByClassName("form-group")[2].getElementsByTagName("span")[0].prepend(div);
//    var span = document.createElement("span");
//    span.setAttribute("class", "badge badge-has-used");
//    span.style.marginRight = "5px";
//    var text = document.createTextNode(li[s].children[i].innerText);
//    span.appendChild(text);
//    document.getElementsByClassName("form-group")[2].getElementsByTagName("div")[0].prepend(span);
//}
//var x = 0;
//li[0].children[0].onclick = function () {

//    if (x === 0) {
//        add("5", "C#");
//        add("6", "JAVA");
//        add("7", "Javascript");
//        add("8", "html");
//        add("9", "SQL");
//        add("10", "Python");
//        addKeyWord(0, 0);
//        x++;
//    }
    
//    //else {
//    //    delete(document.querySelectorAll("[zjc-keyword-dropdownlist]")[1].children);
//    //}
//    buton[0].setAttribute("class", "input-group-btn");

//}
//var a = 0;
////li[1].children[0].onclick = function () {
////    if (a === 0) {
////        addKeyWord(1, 0);
////        a++;
////    }
////    //else {
////    //    delete(document.querySelectorAll("[zjc-keyword-dropdownlist]")[1].children);
////    //}
////    buton[1].setAttribute("class", "input-group-btn");
//}

//document.querySelectorAll("[zjc-btn-default]")[1].onclick = function () {
//    if (buton[1].getAttribute("class").toString() === "input-group-btn") {
//        buton[1].setAttribute("class", "input-group-btn open");
//    }
//    else {
//        buton[1].setAttribute("class", "input-group-btn");
//    }
//}






