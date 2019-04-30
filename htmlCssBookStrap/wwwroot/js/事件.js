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

//    nam[4].onclick = function isrepeat() {
        

//        for (var i = 0; i < arr.length; i++) {
//            if (nam[0].value === arr[i]) {
//                event.preventDefault();
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







