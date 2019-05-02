//-------笔记
//var reg = document.getElementsByTagName("body")[0].innerHTML;
///<a/.test(reg);                  //返回true
//reg.search(/<a/);      //与指定查找的字符串或者正则表达式相匹配的 String 对象起始位置,如果没有找到返回-1
//    / <div /.exec(reg);



//1,完成详细的、可测试的需求文档：学费计算器（Web版）。实现以下功能： 
//用户可以选择在源栈学习的开始时间、共学习多少天 / 周 / 月
//然后，系统自动计算出截至日期和总学费 
//(function () {
//    var inputDate =new Date(prompt());
//    var secondinputDate = prompt();
//    var countTime = parseInt(secondinputDate.substring(0, secondinputDate.length - 1));
//    var hourlyBasis = secondinputDate.substring(secondinputDate.length - 1);
//    if (hourlyBasis === "天") {
//        var expiryDate1 = new Date(inputDate.setDate(inputDate.getDate() + countTime));

//        alert(`截止日期${expiryDate1}+，学费${(986 / 5) * countTime}元`);
//    }
//    else if (hourlyBasis === "周") {
//        var expiryDate2 = new Date(inputDate.setDate(inputDate.getDate() + (countTime * 7)));

//        alert(`截止日期${expiryDate2}+，学费${986 * countTime}元`);
//    }
//    else if (hourlyBasis === "月") {
//        var expiryDate3 = new Date(inputDate.setDate(inputDate.getDate() + (countTime * 30)));

//        alert(`截止日期${expiryDate3}+，学费${986 * countTime}元`);
//    }
//}) ();

//使用正则表达式判断某个字符串:
//是否是合格的Email格式
//是否是小数（正负小数都可以）
//将所有以zyf - 开头的属性去掉zyf - （尽可能多的制造测试用例，比如：<a lzyf-old=''， 或者：<span>zyf---+---fyz</span> ……）

