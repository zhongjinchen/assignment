
////参考求助列表页面，使用iframe，不刷新页面，动态加载不同的关键字
(function () {
    let i = 2;
    document.querySelector("[zjc-button]").onclick = function () {

        var iframe = document.getElementsByTagName("iframe")[0];
        iframe.removeAttribute("src");
        iframe.setAttribute("src", `/KeyWords${i}`);
        if (i === 2) {
            i = 0;
        }
        i++;
    }
})();

////绘制一个canvas画布，当鼠标移到上面，显示鼠标所在位置的canvas坐标

let canvas = $("canvas");
canvas.mousemove(function (event) {
    canvas.next().remove();
    canvas.after(`<span>(${event.clientX},${event.clientY})</span>`);

});
canvas.mouseout(function () {
    canvas.next().remove();
})
