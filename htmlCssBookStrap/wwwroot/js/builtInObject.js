//-------笔记
//var reg = document.getElementsByTagName("body")[0].innerHTML;
///<a/.test(reg);                  //返回true
//reg.search(/<a/);      //与指定查找的字符串或者正则表达式相匹配的 String 对象起始位置,如果没有找到返回-1
//    / <div /.exec(reg);
//var m = new Map([['小程', 95], ['老赵', 75], ['两开花', 85]]);





//作业
//1,完成详细的、可测试的需求文档：学费计算器（Web版）。实现以下功能： 
//用户可以选择在源栈学习的开始时间、共学习多少天 / 周 / 月
//然后，系统自动计算出截至日期和总学费 
//(function () {
//    var inputBox = document.querySelectorAll("[zjc-input]");
//    inputBox[5].onclick = function () {
//        var inputDate = new Date(inputBox[0].value);

//        var countTime = parseInt(inputBox[1].value);
//        var hourlyBasis = document.getElementsByClassName("checkbox-inline")

//        if (hourlyBasis[0].children[0].checked) {
//            var expiryDate1 = new Date(inputDate.setDate(inputDate.getDate() + countTime));

//            inputBox[6].value = `截止日期${expiryDate1.getFullYear()}年${expiryDate1.getMonth() + 1}月${expiryDate1.getDay()}日，学费${(986 / 5) * countTime}元`;
//        }
//        else if (hourlyBasis[1].children[0].checked) {
//            var expiryDate2 = new Date(inputDate.setDate(inputDate.getDate() + (countTime * 7)));

//            inputBox[6].value = `截止日期${expiryDate2.getFullYear()}年${expiryDate2.getMonth() + 1}月${expiryDate2.getDay()}日，学费${986 * countTime}元`;
//        }
//        else if (hourlyBasis[2].children[0].checked) {
//            var expiryDate3 = new Date(inputDate.setDate(inputDate.getDate() + (countTime * 30)));

//            inputBox[6].value = `截止日期${expiryDate3.getFullYear()}年${expiryDate3.getMonth() + 1}月${expiryDate3.getDay()}日，学费${(986 / 7) * 30 * countTime}元`;
//        }
//    }
//})();


//使用正则表达式判断某个字符串:
//是否是合格的Email格式
//是否是小数（正负小数都可以）
//将所有以zyf - 开头的属性去掉zyf - （尽可能多的制造测试用例，比如：<a lzyf-old='',或者：<span>zyf---+---fyz</span> ……）
//(^[\w|_]|^[\w|_][\w|.|_]*[\w|_])[@][?=\w|?=_][\w|.|_]*[.][\w|.|_]*[\w|_]$  //只能判断一个
//([\w|_]|[\w|_][\w|.|_]*[\w|_])[@][?=\w|?=_][\w|.|_]*[.][\w|.|_]*[\w|_]  //可以找出多个
//^\d+[.]\d+$
//function deletezyf(str) {
//    //var str = document.getElementsByTagName("body")[0].innerHTML,
//    var reg = /<.*?>/g,
//        secondReg = /\s(zyf\-)[\S]*?=/g,
//        firstSelect = str.match(reg),
//        result = [];
//    for (var i = 0; i < firstSelect.length; i++) {
//        result.push(firstSelect[i].replace(secondReg, function (match, content) {
//            return match.replace(content,'');
//        }));
//    }

//    return result;
//}





//JSON生成和解析：
//按自己的情况，生成一个JSON字符串，包括真实姓名、QQ昵称、年龄、性别、兴趣爱好、自我介绍……，上传到QQ群：一起帮·有意向（729600626）
//var littleDragon = {
//    name: "小龙",
//    nickname: "江流儿",
//    age: 3,
//    isFamel: true,
//    hobby: ["eat", "drink", "goWhoring", "gamble"],
//    indroduce: "神一样男人"
//}
//console.log(JSON.stringify(littleDragon));

////根据其他同学的JSON获得其个人资料，生成一个表格显示。 
//< table class="table table-bordered" >      ////----最终添加到html页面的代码
//        <tbody>
//            <tr>
//                <td>name</td>
//                <td>小龙</td>
//            </tr>
//            <tr>
//                <td>Sachin</td>
//                <td>Mumbai</td>
//            </tr>
//        </tbody>
//</table >

//console.log(JSON.stringify(littleDragon));
//var bigDragon = JSON.parse('{ "name": "小龙", "nickname": "江流儿", "age": 3, "isFamel": true, "hobby": ["eat", "drink", "goWhoring", "gamble"], "indroduce": "神一样男人" }')

//var table = document.createElement("table");
//table.setAttribute("class", "table table-bordered");
//var tbody = document.createElement("tbody");

//var tr = document.createElement("tr");
//var td1 = document.createElement("td");
//var text1 = document.createTextNode("name");
//var td2 = document.createElement("td");
//var text2 = document.createTextNode(bigDragon.name);
//td1.appendChild(text1);
//td2.appendChild(text2);
//tr.appendChild(td1);
//tr.appendChild(td2);

//var tr2_tr = document.createElement("tr");
//var tr2_td1 = document.createElement("td");
//var tr2_text1 = document.createTextNode("nickname");
//var tr2_td2 = document.createElement("td");
//var tr2_text2 = document.createTextNode(bigDragon.nickname);
//tr2_td1.appendChild(tr2_text1);
//tr2_td2.appendChild(tr2_text2);
//tr2_tr.appendChild(tr2_td1);
//tr2_tr.appendChild(tr2_td2);

//tbody.appendChild(tr);
//tbody.appendChild(tr2_tr);
//table.appendChild(tbody);
//document.getElementsByTagName("aside")[0].appendChild(table);